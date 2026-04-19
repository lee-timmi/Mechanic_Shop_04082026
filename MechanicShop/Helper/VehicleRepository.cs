using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Helper
{
    public class VehicleRepository : BaseRepository
    {
        public List<Vehicle> GetAll()
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
        public List<Vehicle> GetByCustomer(int customerId)
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
        public Vehicle GetById(int vehicleId)
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
        public void Add(Vehicle vehicle)
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
        public void Update(Vehicle vehicle)
        { /* move UpdateVehicle */ }
        public void Delete(int vehicleId)
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
    }
}
