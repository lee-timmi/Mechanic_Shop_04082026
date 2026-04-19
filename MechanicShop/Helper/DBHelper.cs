using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechanicShop.Classes;

namespace MechanicShop.Helper
{
    public class DBHelper
    {
        private string connectionString;

        public DBHelper()
        {
            string dbPath = Path.Combine(Application.StartupPath, "MechanicShopDB.accdb");
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";
        }

        // Expose the connection string so other services can reuse the same database configuration
        public string ConnectionString => connectionString;

        // Customers
        public Customer GetCustomerById(int customerId)
        {
            string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Customer
                        {
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            PhoneNumber = reader["Phone"]?.ToString() ?? "",
                            Email = reader["Email"]?.ToString() ?? "",
                            Address = reader["Address"]?.ToString() ?? ""
                        };
                    }
                }
            }
            return null;
        }

        public List<Customer> GetAllCustomers()
        {
            var customers = new List<Customer>();
            string query = "SELECT * FROM Customers ORDER BY LastName, FirstName";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            PhoneNumber = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString()
                        });
                    }
                }
            }

            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            string query = "INSERT INTO Customers (FirstName, LastName, Phone, Email, Address) VALUES (@FirstName, @LastName, @Phone, @Email, @Address)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@Phone", (object)customer.PhoneNumber ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object)customer.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)customer.Address ?? DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            string query = "UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Email = @Email, Address = @Address WHERE CustomerID = @CustomerID";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@Phone", (object)customer.PhoneNumber ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object)customer.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)customer.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCustomer(int customerId)
        {
            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Repair Orders
        public List<RepairOrder> GetAllRepairOrders()
        {
            var repairOrders = new List<RepairOrder>();
            string query = @"
                SELECT r.*, c.FirstName, c.LastName, v.Make, v.Model, v.Year
                FROM (RepairOrders r
                INNER JOIN Customers c ON r.CustomerID = c.CustomerID)
                INNER JOIN Vehicles v ON r.VehicleID = v.VehicleID
                ORDER BY r.DateOpened DESC";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            { 
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        repairOrders.Add(new RepairOrder
                        {
                            RepairOrderId = Convert.ToInt32(reader["RepairOrderID"]),
                            
                            CustomerId = Convert.ToInt32(reader["CustomerID"]),
                            VehicleId = Convert.ToInt32(reader["VehicleID"]),
                            DateOpened = Convert.ToDateTime(reader["DateOpened"]),
                            DateClosed = reader["DateClosed"] == DBNull.Value ? (DateTime?)null : 
                                            Convert.ToDateTime(reader["DateClosed"]),
                            MileageAtService = Convert.ToInt32(reader["MileageAtService"]),
                            RepairStatus = reader["RepairStatus"].ToString(),
                            CustomerComplaint = reader["CustomerComplaint"].ToString(),
                            CustomerName = $"{reader["FirstName"]} {reader["LastName"]}",
                            VehicleDisplay = $"{reader["Year"]} {reader["Make"]} {reader["Model"]}"
                        });
                    }
                }
            }
            return repairOrders;
        }

        public List<RepairOrder> SearchRepairOrders(string customerName, DateTime? startDate, DateTime? endDate, string status)
        {
            var repairOrders = new List<RepairOrder>();
            string query = @"
                SELECT r.*, c.FirstName, c.LastName, v.Make, v.Model, v.Year 
                FROM (RepairOrders r
                INNER JOIN Customers c ON r.CustomerId = c.CustomerId)
                INNER JOIN Vehicles v ON r.VehicleId = v.VehicleId
                WHERE 1=1";

            if (!string.IsNullOrEmpty(customerName))
            {
                query += " AND (c.FirstName LIKE @customer OR c.LastName LIKE @customer)";
            }

            if (startDate.HasValue)
            {
                query += " AND r.DateOpened >= @startDate";
            } if (endDate.HasValue)
            {
                query += " AND r.DateOpened <= @endDate";
            }
            if (!string.IsNullOrEmpty(status) && status != "All")
            {
                query += " AND r.RepairStatus = @RepairStatus";
            }

            query += " ORDER BY r.DateOpened DESC";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(customerName))
                {
                    cmd.Parameters.AddWithValue("@customer", $"%{customerName}%");
                }
                if (startDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate.Value);
                }
                if (endDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@endDate", endDate.Value);
                }
                if (!string.IsNullOrEmpty(status) && status != "All")
                {
                    cmd.Parameters.AddWithValue("@status", status);
                }

                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        repairOrders.Add(new RepairOrder
                        {
                            RepairOrderId = Convert.ToInt32(reader["RepairOrderID"]),
                            CustomerId = Convert.ToInt32(reader["CustomerID"]),
                            VehicleId = Convert.ToInt32(reader["VehicleID"]),
                            DateOpened = Convert.ToDateTime(reader["DateOpened"]),
                            RepairStatus = reader["RepairStatus"].ToString(),
                            CustomerName = $"{reader["FirstName"]} {reader["LastName"]}",
                            VehicleDisplay = $"{reader["Year"]} {reader["Make"]} {reader["Model"]}"
                        });
                    }
                }
            }
            return repairOrders;
        }

        public void DeleteRepairOrders(int repairOrderID)
        {
            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                using (OleDbTransaction trans  = conn.BeginTransaction())
                {
                    try
                    {
                        using (OleDbCommand cmd = new OleDbCommand("DELETE FROM LaborLineItems WHERE RepairOrderID = @RepairOrderID", conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@RepairOrderID", repairOrderID);
                            cmd.ExecuteNonQuery();
                        }

                        using (OleDbCommand cmd = new OleDbCommand("DELETE FROM PartsLineItems WHERE RepairOrderID = @RepairOrderID", conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@RepairOrderID", repairOrderID);
                            cmd.ExecuteNonQuery();
                        }

                        using (OleDbCommand cmd = new OleDbCommand("DELETE FROM RepairOrders WHERE RepairOrderID = @RepairOrderID", conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@RepairOrderID", repairOrderID);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        // Labor and Parts Line Items
        public List<LaborLineItem> GetLaborItemsByRepairOrder(int repairOrderId)
        {
            var items = new List<LaborLineItem>();
            string query = "SELECT * FROM LaborLineItems WHERE RepairOrderId = @RepairOrderId";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@RepairOrderId", repairOrderId);
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(new LaborLineItem
                        {
                            LaborLineItemId = Convert.ToInt32(reader["LaborLineItemID"]),
                            RepairOrderId = Convert.ToInt32(reader["RepairOrderID"]),
                            LaborDescription = reader["LaborDescription"].ToString(),
                            LaborHours = Convert.ToDecimal(reader["LaborHours"]),
                            LaborHourlyRate = Convert.ToDecimal(reader["LaborHourlyRate"]),
                            MechanicID = reader["MechanicID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["MechanicID"])
                        });
                    }
                }
            }
            return items;
        }

        public List<PartsLineItem> GetPartsItemsByRepairOrder(int repairOrderId)
        {
            var items = new List<PartsLineItem>();
            string query = "SELECT * FROM PartsLineItems WHERE RepairOrderId = @RepairOrderId";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@RepairOrderId", repairOrderId);
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(new PartsLineItem(
                        Convert.ToInt32(reader["PartsLineItemId"]),
                        reader["PartName"].ToString(),
                        Convert.ToInt32(reader["Quantity"]),
                        Convert.ToDecimal(reader["UnitCost"])
)
                        {
                            RepairOrderId = Convert.ToInt32(reader["RepairOrderId"])
                        });
                    }
                }
            }
            return items;
        }

        public void SaveRepairOrder(RepairOrder repairOrder, List<LaborLineItem> lineItems,
                                    List<PartsLineItem> partItems)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Insert or update RepairOrder
                        string repairOrderQuery = @"
                                INSERT INTO RepairOrders (OrderNumber, CustomerId, VehicleId, DateOpened, DateClosed, MileageAtService, RepairStatus, CustomerComplaint)
                                VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                        int repairOrderId;

                        using (OleDbCommand cmd = new OleDbCommand(repairOrderQuery, conn, transaction))
                        {
                            cmd.Parameters.Add(new OleDbParameter("@OrderNumber", OleDbType.VarWChar) { Value = (object)repairOrder.OrderNumber ?? DBNull.Value });
                            cmd.Parameters.Add(new OleDbParameter("@CustomerId", OleDbType.Integer) { Value = repairOrder.CustomerId });
                            cmd.Parameters.Add(new OleDbParameter("@VehicleId", OleDbType.Integer) { Value = repairOrder.VehicleId });
                            cmd.Parameters.Add(new OleDbParameter("@DateOpened", OleDbType.DBDate) { Value = repairOrder.DateOpened });
                            cmd.Parameters.Add(new OleDbParameter("@DateClosed", OleDbType.DBDate) { Value = (object)repairOrder.DateClosed ?? DBNull.Value });
                            cmd.Parameters.Add(new OleDbParameter("@MileageAtService", OleDbType.Integer) { Value = repairOrder.MileageAtService });
                            cmd.Parameters.Add(new OleDbParameter("@RepairStatus", OleDbType.VarWChar) { Value = repairOrder.RepairStatus });
                            cmd.Parameters.Add(new OleDbParameter("@CustomerComplaint", OleDbType.LongVarChar) { Value = (object)repairOrder.CustomerComplaint ?? DBNull.Value });

                            cmd.ExecuteNonQuery();
                        }

                        // Retrieve the last inserted identity value using a separate command (required by OleDb/ACE)
                        using (OleDbCommand idCmd = new OleDbCommand("SELECT @@IDENTITY", conn, transaction))
                        {
                            object idResult = idCmd.ExecuteScalar();
                            repairOrderId = Convert.ToInt32(idResult);
                        }

                        // Insert LaborLineItems
                        foreach (var labor in lineItems)
                        {
                            string laborQuery = @"
                                    INSERT INTO LaborLineItems (RepairOrderId, LaborDescription, LaborHours, LaborHourlyRate, MechanicID)
                                    VALUES (?, ?, ?, ?, ?)";

                            using (OleDbCommand cmd = new OleDbCommand(laborQuery, conn, transaction))
                            {
                                cmd.Parameters.Add(new OleDbParameter("@RepairOrderId", OleDbType.Integer) { Value = repairOrderId });
                                cmd.Parameters.Add(new OleDbParameter("@LaborDescription", OleDbType.VarWChar) { Value = (object)labor.LaborDescription ?? DBNull.Value });
                                cmd.Parameters.Add(new OleDbParameter("@LaborHours", OleDbType.Double) { Value = (double)labor.LaborHours });
                                cmd.Parameters.Add(new OleDbParameter("@LaborHourlyRate", OleDbType.Currency) { Value = labor.LaborHourlyRate });
                                cmd.Parameters.Add(new OleDbParameter("@MechanicID", OleDbType.Integer) { Value = (object)labor.MechanicID ?? DBNull.Value });

                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Insert PartsLineItems
                        foreach (var part in partItems)
                        {
                            string partQuery = @"
                                    INSERT INTO PartsLineItems (RepairOrderId, PartName, Quantity, UnitCost)
                                    VALUES (?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(partQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@RepairOrderId", repairOrderId);
                                cmd.Parameters.AddWithValue("@PartName", part.PartName);
                                cmd.Parameters.AddWithValue("@Quantity", part.Quantity);
                                cmd.Parameters.AddWithValue("@UnitCost", part.UnitCost);

                                foreach (OleDbParameter p in cmd.Parameters)
                                {
                                    System.Diagnostics.Debug.WriteLine(
                                        $"Param: {p.ParameterName} | OleDbType: {p.OleDbType} | " +
                                        $"Value: {p.Value} | ValueType: {p.Value?.GetType().Name}");
                                }

                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch 
                    { 
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void UpdateRepairOrder(RepairOrder repair, List<LaborLineItem> laborItems, List<PartsLineItem> partsItems)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Update Repair Order
                        string updateRepair = @"
                            UPDATE RepairOrders 
                            SET CustomerID = ?, VehicleID = ?, DateOpened = ?, DateClosed = ?,
                                MileageAtService = ?, RepairStatus = ?, CustomerComplaint = ?
                            WHERE RepairOrderID = ?";

                        using (OleDbCommand cmd = new OleDbCommand(updateRepair, conn, transaction))
                        {
                            cmd.Parameters.Add(new OleDbParameter("@CustomerID", OleDbType.Integer) { Value = repair.CustomerId });
                            cmd.Parameters.Add(new OleDbParameter("@VehicleID", OleDbType.Integer) { Value = repair.VehicleId });
                            cmd.Parameters.Add(new OleDbParameter("@DateOpened", OleDbType.DBDate) { Value = repair.DateOpened });
                            cmd.Parameters.Add(new OleDbParameter("@DateClosed", OleDbType.DBDate) { Value = (object)repair.DateClosed ?? DBNull.Value });
                            cmd.Parameters.Add(new OleDbParameter("@MileageAtService", OleDbType.Integer) { Value = repair.MileageAtService });
                            cmd.Parameters.Add(new OleDbParameter("@RepairStatus", OleDbType.VarWChar) { Value = repair.RepairStatus });
                            cmd.Parameters.Add(new OleDbParameter("@CustomerComplaint", OleDbType.LongVarChar) { Value = (object)repair.CustomerComplaint ?? DBNull.Value });
                            cmd.Parameters.Add(new OleDbParameter("@RepairOrderID", OleDbType.Integer) { Value = repair.RepairOrderId });

                            cmd.ExecuteNonQuery();
                        }

                        // Delete old labor items and insert new ones
                        using (OleDbCommand cmd = new OleDbCommand("DELETE FROM LaborLineItems WHERE RepairOrderId = @RepairOrderId", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@RepairOrderId", repair.RepairOrderId);
                            cmd.ExecuteNonQuery();
                        }

                        foreach (var labor in laborItems)
                        {
                            string insertLabor = @"
                                INSERT INTO LaborLineItems (RepairOrderId, LaborDescription, LaborHours, LaborHourlyRate, MechanicID)
                                VALUES (?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(insertLabor, conn, transaction))
                            {
                                cmd.Parameters.Add(new OleDbParameter("@RepairOrderId", OleDbType.Integer) { Value = repair.RepairOrderId });
                                cmd.Parameters.Add(new OleDbParameter("@LaborDescription", OleDbType.VarWChar) { Value = (object)labor.LaborDescription ?? DBNull.Value });
                                cmd.Parameters.Add(new OleDbParameter("@LaborHours", OleDbType.Double) { Value = (double)labor.LaborHours });
                                cmd.Parameters.Add(new OleDbParameter("@LaborHourlyRate", OleDbType.Currency) { Value = labor.LaborHourlyRate });
                                cmd.Parameters.Add(new OleDbParameter("@MechanicID", OleDbType.Integer) { Value = (object)labor.MechanicID ?? DBNull.Value });
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Delete old parts items and insert new ones
                        using (OleDbCommand cmd = new OleDbCommand("DELETE FROM PartsLineItems WHERE RepairOrderId = @RepairOrderId", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@RepairOrderId", repair.RepairOrderId);
                            cmd.ExecuteNonQuery();
                        }

                        foreach (var part in partsItems)
                        {
                            string insertPart = @"
                        INSERT INTO PartsLineItems (RepairOrderId, PartName, Quantity, UnitCost)
                        VALUES (@RepairOrderId, @PartName, @Quantity, @UnitCost)";
                            using (OleDbCommand cmd = new OleDbCommand(insertPart, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@RepairOrderId", repair.RepairOrderId);
                                cmd.Parameters.AddWithValue("@PartName", part.PartName);
                                cmd.Parameters.AddWithValue("@Quantity", part.Quantity);
                                cmd.Parameters.AddWithValue("@UnitCost", part.UnitCost);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        // ==== Vehicle Form Methods ====
        public List<Vehicle> GetAllVehicles()
        {
            var vehicles = new List<Vehicle>();
            string queryGet =
                @"SELECT v.*, c.FirstName, c.LastName
                  FROM Vehicles v
                  INNER JOIN Customers c ON v.CustomerID = c.CustomerID
                  ORDER BY c.LastName, v.Year DESC";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(queryGet, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vehicles.Add(new Vehicle
                        {
                            VehicleID = Convert.ToInt32(reader["VehicleID"]),
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            VIN = reader["VIN"].ToString(),
                            Make = reader["Make"].ToString(),
                            Model = reader["Model"].ToString(),
                            Year = Convert.ToInt32(reader["Year"]),
                            LicensePlate = reader["LicensePlate"].ToString(),
                            CurrentMileage = Convert.ToInt32(reader["CurrentMileage"]),
                        });
                    }
                }
            }
            return vehicles;
        }

        public List<Vehicle> GetVehiclesByCustomer(int customerId)
        {
            var vehicles = new List<Vehicle>();
            string queryGetByID =
                "SELECT * FROM Vehicles WHERE CustomerID = @CustomerID ORDER BY Year DESC";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(queryGetByID, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vehicles.Add(new Vehicle
                        {
                            VehicleID = Convert.ToInt32(reader["VehicleID"]),
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            VIN = reader["VIN"].ToString(),
                            Make = reader["Make"].ToString(),
                            Model = reader["Model"].ToString(),
                            Year = Convert.ToInt32(reader["Year"]),
                            LicensePlate = reader["LicensePlate"].ToString(),
                            CurrentMileage = Convert.ToInt32(reader["CurrentMileage"])
                        });
                    }
                }
            }
            return vehicles;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            string queryAdd = 
                "INSERT INTO Vehicles (CustomerID, VIN, Make, Model, [Year], LicensePlate, CurrentMileage) " +
                "VALUES (@CustomerID, @VIN, @Make, @Model, @Year, @LicensePlate, @CurrentMileage)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(queryAdd, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", vehicle.CustomerID);
                cmd.Parameters.AddWithValue("@VIN", vehicle.VIN);
                cmd.Parameters.AddWithValue("@Make", vehicle.Make);
                cmd.Parameters.AddWithValue("@Model", vehicle.Model);
                cmd.Parameters.AddWithValue("@Year", vehicle.Year);
                cmd.Parameters.AddWithValue("@LicensePlate", (object)vehicle.LicensePlate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CurrentMileage", vehicle.CurrentMileage);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
        }

        // Deleting Vehicle 
        public void DeleteVehicle(int vehicleId)
        {
            string queryDelete = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(queryDelete, conn))
            {
                cmd.Parameters.AddWithValue("@VehicleID", vehicleId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Get Vehicle by ID
        public Vehicle GetVehicleById(int vehicleId)
        {
            string query = "SELECT * FROM Vehicles WHERE VehicleID = @VehicleID";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@VehicleID", vehicleId);
                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Vehicle
                        {
                            VehicleID = Convert.ToInt32(reader["VehicleID"]),
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            VIN = reader["VIN"]?.ToString() ?? "",
                            Make = reader["Make"].ToString(),
                            Model = reader["Model"].ToString(),
                            Year = Convert.ToInt32(reader["Year"]),
                            LicensePlate = reader["LicensePlate"]?.ToString() ?? "",
                            CurrentMileage = Convert.ToInt32(reader["CurrentMileage"])
                        };
                    }
                }
            }
            return null;
        }

        public int GetNextOrderNumber(string year)
        {
            string query = @"
                SELECT COUNT(*) 
                FROM RepairOrders
                WHERE OrderNumber LIKE @Pattern";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd  = new OleDbCommand(query, conn))
            {
                // pattern must match GenerateOrderNumber ("RO-YYYY-xxxx")
                cmd.Parameters.AddWithValue("@Pattern", $"RO-{year}-%");
                conn.Open();

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count + 1; 
            }
        }

    } // end of class DBHelper
}
