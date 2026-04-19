using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechanicShop.Helper;

namespace MechanicShop.Services
{
    public class MechanicService
    {
        public readonly string connString;

        public MechanicService(string connString)
        {
            this.connString = connString;
        }

        public MechanicService()
        {
            string dbPath = System.IO.Path.Combine(
                System.Windows.Forms.Application.StartupPath, "MechanicShopDB.accdb");
            this.connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";
        }

        public List<Mechanic> GetAllMechanics()
        {
            var mechanics = new List<Mechanic>();
            string query = "SELECT * FROM Mechanics ORDER BY LastName, FirstName";

            using (OleDbConnection conn = new OleDbConnection(connString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mechanics.Add(new Mechanic
                        {
                            MechanicID = Convert.ToInt32(reader["MechanicID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            HourlyRate = Convert.ToDecimal(reader["HourlyRate"]),
                            Specialty = reader["Specialty"]?.ToString() ?? "",
                            Phone = reader["Phone"]?.ToString() ?? ""
                        });
                    }
                }
            }

            return mechanics;
        }

        public void AddMechanic(Mechanic mechanic)
        {
            string query = "INSERT INTO Mechanics (FirstName, LastName, HourlyRate, Specialty, Phone) " +
                           "VALUES (@FirstName, @LastName, @HourlyRate, @Specialty, @Phone)";

            using (OleDbConnection conn = new OleDbConnection(connString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", mechanic.FirstName);
                cmd.Parameters.AddWithValue("@LastName", mechanic.LastName);
                cmd.Parameters.AddWithValue("@HourlyRate", mechanic.HourlyRate);
                cmd.Parameters.AddWithValue("@Specialty", (object)mechanic.Specialty ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", (object)mechanic.Phone ?? DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMechanic(Mechanic mechanic)
        {
            string query = "UPDATE Mechanics SET FirstName = @FirstName, LastName = @LastName, HourlyRate = @HourlyRate, Specialty = @Specialty, Phone = @Phone " +
                           "WHERE MechanicID = @MechanicID";

            using (OleDbConnection conn = new OleDbConnection(connString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", mechanic.FirstName);
                cmd.Parameters.AddWithValue("@LastName", mechanic.LastName);
                cmd.Parameters.AddWithValue("@HourlyRate", mechanic.HourlyRate);
                cmd.Parameters.AddWithValue("@Specialty", (object)mechanic.Specialty ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", (object)mechanic.Phone ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MechanicID", mechanic.MechanicID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMechanic(int mechanicId)
        {
            string query = "DELETE FROM Mechanics WHERE MechanicID = @MechanicID";

            using (OleDbConnection conn = new OleDbConnection(connString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MechanicID", mechanicId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<Mechanic> Search(string term)
        {
            if (string.IsNullOrWhiteSpace(term)) return GetAllMechanics();

            term = term.ToLower();
            return GetAllMechanics().Where(m =>
                m.FirstName.ToLower().Contains(term) ||
                m.LastName.ToLower().Contains(term)).ToList();
        }
    } //end of public class
}
