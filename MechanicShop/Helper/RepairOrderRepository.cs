using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace MechanicShop.Helper
{
    public class RepairOrderRepository : BaseRepository
    {
        public List<RepairOrder> GetAll()
        {
            List<RepairOrder> repairOrders = new List<RepairOrder>();
            string query = @"
                SELECT r.*, c.FirstName, c.LastName, v.Make, v.Model, v.Year,
                       (SELECT IIF(SUM(l.LaborHours * l.LaborHourlyRate) IS NULL, 0,
                            SUM(l.LaborHours * l.LaborHourlyRate))
                        FROM LaborLineItems l WHERE l.RepairOrderID = r.RepairOrderID) +
                       (SELECT IIF(SUM(p.UnitCost * p.Quantity) IS NULL, 0,
                            SUM(p.UnitCost * p.Quantity))
                        FROM PartsLineItems p WHERE p.RepairOrderID = r.RepairOrderID) AS GrandTotal
                FROM (RepairOrders r
                INNER JOIN Customers c ON r.CustomerID = c.CustomerID)
                INNER JOIN Vehicles v ON r.VehicleID = v.VehicleID
                ORDER BY r.DateOpened DESC";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RepairOrder order = new RepairOrder();
                    order.RepairOrderId     = Convert.ToInt32(reader["RepairOrderID"]);
                    order.CustomerId        = Convert.ToInt32(reader["CustomerID"]);
                    order.VehicleId         = Convert.ToInt32(reader["VehicleID"]);
                    order.DateOpened        = Convert.ToDateTime(reader["DateOpened"]);
                    order.MileageAtService  = Convert.ToInt32(reader["MileageAtService"]);
                    order.RepairStatus      = reader["RepairStatus"].ToString();
                    order.CustomerComplaint = reader["CustomerComplaint"].ToString();
                    order.CustomerName      = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                    order.VehicleDisplay    = reader["Year"].ToString() + " " + reader["Make"].ToString() + " " + reader["Model"].ToString();
                    order.TotalCost         = Convert.ToDecimal(reader["GrandTotal"]);

                    if (reader["DateClosed"] == DBNull.Value)
                        order.DateClosed = null;
                    else
                        order.DateClosed = Convert.ToDateTime(reader["DateClosed"]);

                    repairOrders.Add(order);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading repair orders: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return repairOrders;
        }

        public void Save(RepairOrder repairOrder, List<LaborLineItem> lineItems, List<PartsLineItem> partItems)
        {
            string repairOrderQuery = "INSERT INTO RepairOrders " +
                "(OrderNumber, CustomerID, VehicleID, DateOpened, DateClosed, MileageAtService, RepairStatus, CustomerComplaint) " +
                "VALUES (@OrderNumber, @CustomerID, @VehicleID, @DateOpened, @DateClosed, @MileageAtService, @RepairStatus, @CustomerComplaint)";

            OleDbConnection conn = new OleDbConnection(connectionString);
            int repairOrderId = 0;

            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand(repairOrderQuery, conn);
                cmd.Parameters.AddWithValue("@OrderNumber",       repairOrder.OrderNumber);
                cmd.Parameters.AddWithValue("@CustomerID",        repairOrder.CustomerId);
                cmd.Parameters.AddWithValue("@VehicleID",         repairOrder.VehicleId);
                cmd.Parameters.AddWithValue("@DateOpened",        repairOrder.DateOpened);
                cmd.Parameters.AddWithValue("@DateClosed",        repairOrder.DateClosed);
                cmd.Parameters.AddWithValue("@MileageAtService",  repairOrder.MileageAtService);
                cmd.Parameters.AddWithValue("@RepairStatus",      repairOrder.RepairStatus);
                cmd.Parameters.AddWithValue("@CustomerComplaint", repairOrder.CustomerComplaint);
                cmd.ExecuteNonQuery();

                OleDbCommand idCmd = new OleDbCommand("SELECT @@IDENTITY", conn);
                repairOrderId = Convert.ToInt32(idCmd.ExecuteScalar());

                for (int i = 0; i < lineItems.Count; i++)
                {
                    LaborLineItem labor = lineItems[i];
                    string laborQuery = "INSERT INTO LaborLineItems " +
                        "(RepairOrderID, LaborDescription, LaborHours, LaborHourlyRate, MechanicID) " +
                        "VALUES (@RepairOrderID, @LaborDescription, @LaborHours, @LaborHourlyRate, @MechanicID)";

                    OleDbCommand laborCmd = new OleDbCommand(laborQuery, conn);
                    laborCmd.Parameters.AddWithValue("@RepairOrderID",    repairOrderId);
                    laborCmd.Parameters.AddWithValue("@LaborDescription", labor.LaborDescription);
                    laborCmd.Parameters.AddWithValue("@LaborHours",       (double)labor.LaborHours);
                    laborCmd.Parameters.AddWithValue("@LaborHourlyRate",  labor.LaborHourlyRate);
                    laborCmd.Parameters.AddWithValue("@MechanicID",       labor.MechanicID);
                    laborCmd.ExecuteNonQuery();
                }

                for (int i = 0; i < partItems.Count; i++)
                {
                    PartsLineItem part = partItems[i];
                    string partQuery = "INSERT INTO PartsLineItems " +
                        "(RepairOrderID, PartName, Quantity, UnitCost) " +
                        "VALUES (@RepairOrderID, @PartName, @Quantity, @UnitCost)";

                    OleDbCommand partCmd = new OleDbCommand(partQuery, conn);
                    partCmd.Parameters.AddWithValue("@RepairOrderID", repairOrderId);
                    partCmd.Parameters.AddWithValue("@PartName",      part.PartName);
                    partCmd.Parameters.AddWithValue("@Quantity",      part.Quantity);
                    partCmd.Parameters.AddWithValue("@UnitCost",      part.UnitCost);
                    partCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving repair order: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Update(RepairOrder repair, List<LaborLineItem> laborItems, List<PartsLineItem> partsItems)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open();

                string updateRepair = "UPDATE RepairOrders " +
                    "SET CustomerID = @CustomerID, VehicleID = @VehicleID, DateOpened = @DateOpened, DateClosed = @DateClosed, " +
                    "MileageAtService = @MileageAtService, RepairStatus = @RepairStatus, CustomerComplaint = @CustomerComplaint " +
                    "WHERE RepairOrderID = @RepairOrderID";

                OleDbCommand updateCmd = new OleDbCommand(updateRepair, conn);
                updateCmd.Parameters.AddWithValue("@CustomerID",        repair.CustomerId);
                updateCmd.Parameters.AddWithValue("@VehicleID",         repair.VehicleId);
                updateCmd.Parameters.AddWithValue("@DateOpened",        repair.DateOpened);
                updateCmd.Parameters.AddWithValue("@DateClosed",        repair.DateClosed);
                updateCmd.Parameters.AddWithValue("@MileageAtService",  repair.MileageAtService);
                updateCmd.Parameters.AddWithValue("@RepairStatus",      repair.RepairStatus);
                updateCmd.Parameters.AddWithValue("@CustomerComplaint", repair.CustomerComplaint);
                updateCmd.Parameters.AddWithValue("@RepairOrderID",     repair.RepairOrderId);
                updateCmd.ExecuteNonQuery();

                OleDbCommand deleteLaborCmd = new OleDbCommand("DELETE FROM LaborLineItems WHERE RepairOrderID = @RepairOrderID", conn);
                deleteLaborCmd.Parameters.AddWithValue("@RepairOrderID", repair.RepairOrderId);
                deleteLaborCmd.ExecuteNonQuery();

                for (int i = 0; i < laborItems.Count; i++)
                {
                    LaborLineItem labor = laborItems[i];
                    string insertLabor = "INSERT INTO LaborLineItems " +
                        "(RepairOrderID, LaborDescription, LaborHours, LaborHourlyRate, MechanicID) " +
                        "VALUES (@RepairOrderID, @LaborDescription, @LaborHours, @LaborHourlyRate, @MechanicID)";

                    OleDbCommand laborCmd = new OleDbCommand(insertLabor, conn);
                    laborCmd.Parameters.AddWithValue("@RepairOrderID",    repair.RepairOrderId);
                    laborCmd.Parameters.AddWithValue("@LaborDescription", labor.LaborDescription);
                    laborCmd.Parameters.AddWithValue("@LaborHours",       (double)labor.LaborHours);
                    laborCmd.Parameters.AddWithValue("@LaborHourlyRate",  labor.LaborHourlyRate);
                    laborCmd.Parameters.AddWithValue("@MechanicID",       labor.MechanicID);
                    laborCmd.ExecuteNonQuery();
                }

                OleDbCommand deletePartsCmd = new OleDbCommand("DELETE FROM PartsLineItems WHERE RepairOrderID = @RepairOrderID", conn);
                deletePartsCmd.Parameters.AddWithValue("@RepairOrderID", repair.RepairOrderId);
                deletePartsCmd.ExecuteNonQuery();

                for (int i = 0; i < partsItems.Count; i++)
                {
                    PartsLineItem part = partsItems[i];
                    string insertPart = "INSERT INTO PartsLineItems " +
                        "(RepairOrderID, PartName, Quantity, UnitCost) " +
                        "VALUES (@RepairOrderID, @PartName, @Quantity, @UnitCost)";

                    OleDbCommand partCmd = new OleDbCommand(insertPart, conn);
                    partCmd.Parameters.AddWithValue("@RepairOrderID", repair.RepairOrderId);
                    partCmd.Parameters.AddWithValue("@PartName",      part.PartName);
                    partCmd.Parameters.AddWithValue("@Quantity",      part.Quantity);
                    partCmd.Parameters.AddWithValue("@UnitCost",      part.UnitCost);
                    partCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating repair order: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Delete(int id)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open();

                OleDbCommand deleteLaborCmd = new OleDbCommand("DELETE FROM LaborLineItems WHERE RepairOrderID = @RepairOrderID", conn);
                deleteLaborCmd.Parameters.AddWithValue("@RepairOrderID", id);
                deleteLaborCmd.ExecuteNonQuery();

                OleDbCommand deletePartsCmd = new OleDbCommand("DELETE FROM PartsLineItems WHERE RepairOrderID = @RepairOrderID", conn);
                deletePartsCmd.Parameters.AddWithValue("@RepairOrderID", id);
                deletePartsCmd.ExecuteNonQuery();

                OleDbCommand deleteOrderCmd = new OleDbCommand("DELETE FROM RepairOrders WHERE RepairOrderID = @RepairOrderID", conn);
                deleteOrderCmd.Parameters.AddWithValue("@RepairOrderID", id);
                deleteOrderCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting repair order: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public int GetNextOrderNumber(string year)
        {
            string query = "SELECT COUNT(*) FROM RepairOrders WHERE OrderNumber LIKE @Pattern";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@Pattern", "RO-" + year + "-%");
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count + 1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting order number: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<RepairOrder> Search(string customerName, DateTime? startDate,
                                        DateTime? endDate, string status)
        {
            List<RepairOrder> all      = GetAll();
            List<RepairOrder> filtered = new List<RepairOrder>();

            for (int i = 0; i < all.Count; i++)
            {
                RepairOrder r = all[i];
                bool matches  = true;

                if (!string.IsNullOrEmpty(customerName))
                {
                    if (!r.CustomerName.ToLower().Contains(customerName.ToLower()))
                        matches = false;
                }

                if (startDate.HasValue)
                {
                    if (r.DateOpened.Date < startDate.Value.Date)
                        matches = false;
                }

                if (endDate.HasValue)
                {
                    if (r.DateOpened.Date > endDate.Value.Date)
                        matches = false;
                }

                if (!string.IsNullOrEmpty(status) && status != "All")
                {
                    if (r.RepairStatus != status)
                        matches = false;
                }

                if (matches)
                    filtered.Add(r);
            }

            return filtered;
        }
    }
}
