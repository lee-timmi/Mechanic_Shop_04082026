using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MechanicShop.Services
{
    public class MechanicService
    {
        public readonly string connString;
        private readonly AuditService _audit;

        public MechanicService(AuditService audit)
        {
            string dbPath = System.IO.Path.Combine(
                Application.StartupPath, "MechanicShopDB.accdb");
            this.connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath;
            _audit = audit;
        }

        public List<Mechanic> GetAllMechanics()
        {
            List<Mechanic> mechanics = new List<Mechanic>();
            string query = "SELECT * FROM Mechanics ORDER BY LastName, FirstName";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Mechanic m = new Mechanic();
                    m.MechanicID = Convert.ToInt32(reader["MechanicID"]);
                    m.FirstName  = reader["FirstName"].ToString();
                    m.LastName   = reader["LastName"].ToString();
                    m.HourlyRate = Convert.ToDecimal(reader["HourlyRate"]);
                    m.Specialty  = reader["Specialty"].ToString();
                    m.Phone      = reader["Phone"].ToString();
                    mechanics.Add(m);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading mechanics: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return mechanics;
        }

        public void AddMechanic(Mechanic mechanic)
        {
            string query = "INSERT INTO Mechanics (FirstName, LastName, HourlyRate, Specialty, Phone) " +
                           "VALUES (@FirstName, @LastName, @HourlyRate, @Specialty, @Phone)";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@FirstName",  mechanic.FirstName);
                cmd.Parameters.AddWithValue("@LastName",   mechanic.LastName);
                cmd.Parameters.AddWithValue("@HourlyRate", mechanic.HourlyRate);
                cmd.Parameters.AddWithValue("@Specialty",  mechanic.Specialty);
                cmd.Parameters.AddWithValue("@Phone",      mechanic.Phone);
                conn.Open();
                cmd.ExecuteNonQuery();

                if (_audit != null)
                {
                    _audit.Log("Created", "Mechanic", mechanic.MechanicID,
                        mechanic.FirstName + " " + mechanic.LastName + " added");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding mechanic: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateMechanic(Mechanic mechanic)
        {
            string query = "UPDATE Mechanics SET FirstName = @FirstName, LastName = @LastName, HourlyRate = @HourlyRate, Specialty = @Specialty, Phone = @Phone" +
                           "WHERE MechanicID = @MechanicID";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@FirstName",  mechanic.FirstName);
                cmd.Parameters.AddWithValue("@LastName",   mechanic.LastName);
                cmd.Parameters.AddWithValue("@HourlyRate", mechanic.HourlyRate);
                cmd.Parameters.AddWithValue("@Specialty",  (object)mechanic.Specialty ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone",      (object)mechanic.Phone ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MechanicID", mechanic.MechanicID);
                conn.Open();
                cmd.ExecuteNonQuery();

                if (_audit != null)
                {
                    _audit.Log("Updated", "Mechanic", mechanic.MechanicID,
                        mechanic.FirstName + " " + mechanic.LastName + " updated");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating mechanic: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteMechanic(int mechanicId)
        {
            string query = "DELETE FROM Mechanics WHERE MechanicID = @MechanicID";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@MechanicID", mechanicId);
                conn.Open();
                cmd.ExecuteNonQuery();

                if (_audit != null)
                {
                    _audit.Log("Deleted", "Mechanic", mechanicId,
                        "Mechanic " + mechanicId + " deleted");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting mechanic: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Mechanic> Search(string term)
        {
            List<Mechanic> all    = GetAllMechanics();
            List<Mechanic> result = new List<Mechanic>();

            if (string.IsNullOrWhiteSpace(term))
                return all;

            string lowerTerm = term.ToLower();

            for (int i = 0; i < all.Count; i++)
            {
                Mechanic m = all[i];
                if (m.FirstName.ToLower().Contains(lowerTerm) ||
                    m.LastName.ToLower().Contains(lowerTerm))
                {
                    result.Add(m);
                }
            }

            return result;
        }
    }
}
