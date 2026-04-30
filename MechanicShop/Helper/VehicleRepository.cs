using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace MechanicShop.Helper
{
    public class VehicleRepository : BaseRepository
    {
        public List<Vehicle> GetAll()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string query = @"SELECT v.*, c.FirstName, c.LastName
                             FROM Vehicles v
                             INNER JOIN Customers c ON v.CustomerID = c.CustomerID
                             ORDER BY c.LastName, v.Year DESC";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Vehicle v = new Vehicle();
                    v.VehicleID      = Convert.ToInt32(reader["VehicleID"]);
                    v.CustomerID     = Convert.ToInt32(reader["CustomerID"]);
                    v.VIN            = reader["VIN"].ToString();
                    v.Make           = reader["Make"].ToString();
                    v.Model          = reader["Model"].ToString();
                    v.Year           = Convert.ToInt32(reader["Year"]);
                    v.LicensePlate   = reader["LicensePlate"].ToString();
                    v.CurrentMileage = Convert.ToInt32(reader["CurrentMileage"]);
                    vehicles.Add(v);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading vehicles: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return vehicles;
        }

        public List<Vehicle> GetByCustomer(int customerId)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string query = "SELECT * FROM Vehicles WHERE CustomerID = @CustomerID ORDER BY Year DESC";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Vehicle v = new Vehicle();
                    v.VehicleID      = Convert.ToInt32(reader["VehicleID"]);
                    v.CustomerID     = Convert.ToInt32(reader["CustomerID"]);
                    v.VIN            = reader["VIN"].ToString();
                    v.Make           = reader["Make"].ToString();
                    v.Model          = reader["Model"].ToString();
                    v.Year           = Convert.ToInt32(reader["Year"]);
                    v.LicensePlate   = reader["LicensePlate"].ToString();
                    v.CurrentMileage = Convert.ToInt32(reader["CurrentMileage"]);
                    vehicles.Add(v);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading vehicles by customer: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return vehicles;
        }

        public Vehicle GetById(int vehicleId)
        {
            string query = "SELECT * FROM Vehicles WHERE VehicleID = @VehicleID";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@VehicleID", vehicleId);
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Vehicle v = new Vehicle();
                    v.VehicleID      = Convert.ToInt32(reader["VehicleID"]);
                    v.CustomerID     = Convert.ToInt32(reader["CustomerID"]);
                    v.VIN            = reader["VIN"] == DBNull.Value ? "" : reader["VIN"].ToString();
                    v.Make           = reader["Make"].ToString();
                    v.Model          = reader["Model"].ToString();
                    v.Year           = Convert.ToInt32(reader["Year"]);
                    v.LicensePlate   = reader["LicensePlate"] == DBNull.Value ? "" : reader["LicensePlate"].ToString();
                    v.CurrentMileage = Convert.ToInt32(reader["CurrentMileage"]);
                    reader.Close();
                    return v;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting vehicle: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        public void Add(Vehicle vehicle)
        {
            string query = "INSERT INTO Vehicles (CustomerID, VIN, Make, Model, [Year], LicensePlate, CurrentMileage) " +
                           "VALUES (@CustomerID, @VIN, @Make, @Model, @Year, @LicensePlate, @CurrentMileage)";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@CustomerID",     vehicle.CustomerID);
                cmd.Parameters.AddWithValue("@VIN",            vehicle.VIN);
                cmd.Parameters.AddWithValue("@Make",           vehicle.Make);
                cmd.Parameters.AddWithValue("@Model",          vehicle.Model);
                cmd.Parameters.AddWithValue("@Year",           vehicle.Year);
                cmd.Parameters.AddWithValue("@LicensePlate",   vehicle.LicensePlate);
                cmd.Parameters.AddWithValue("@CurrentMileage", vehicle.CurrentMileage);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding vehicle: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Update(Vehicle vehicle)
        {
            string query = "UPDATE Vehicles SET CustomerID = @CustomerID, VIN = @VIN, Make = @Make, Model = @Model, [Year] = @Year, " +
                           "LicensePlate = @LicensePlate, CurrentMileage = @CurrentMileage WHERE VehicleID = @VehicleID";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@CustomerID",     vehicle.CustomerID);
                cmd.Parameters.AddWithValue("@VIN",            vehicle.VIN);
                cmd.Parameters.AddWithValue("@Make",           vehicle.Make);
                cmd.Parameters.AddWithValue("@Model",          vehicle.Model);
                cmd.Parameters.AddWithValue("@Year",           vehicle.Year);
                cmd.Parameters.AddWithValue("@LicensePlate",   vehicle.LicensePlate);
                cmd.Parameters.AddWithValue("@CurrentMileage", vehicle.CurrentMileage);
                cmd.Parameters.AddWithValue("@VehicleID",      vehicle.VehicleID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating vehicle: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Delete(int vehicleId)
        {
            string query = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@VehicleID", vehicleId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting vehicle: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
