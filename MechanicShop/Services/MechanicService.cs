using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MechanicShop.Classes;

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
            // Ensure there is always a valid connection string when the
            // parameterless constructor is used (maintains backward compatibility).
            // DBHelper centralizes how the connection string is built (Application.StartupPath).
            this.connString = new MechanicShop.Helper.DBHelper().ConnectionString;
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
                            HourlyRate = Convert.ToDecimal(reader["HourlyRate"])
                        });
                    }
                }
            }

            return mechanics;
        }

        public void AddMechanic(Mechanic mechanic)
        {
            string query = "INSERT INTO Mechanics (FirstName, LastName, HourlyRate) VALUES (@FirstName, @LastName, @HourlyRate)";

            using (OleDbConnection conn = new OleDbConnection(connString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", mechanic.FirstName);
                cmd.Parameters.AddWithValue("@LastName", mechanic.LastName);
                cmd.Parameters.AddWithValue("@HourlyRate", mechanic.HourlyRate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMechanic(Mechanic mechanic)
        {
            string query = "UPDATE Mechanics SET FirstName = @FirstName, LastName = @LastName, HourlyRate = @HourlyRate WHERE MechanicID = @MechanicID";

            using (OleDbConnection conn = new OleDbConnection(connString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", mechanic.FirstName);
                cmd.Parameters.AddWithValue("@LastName", mechanic.LastName);
                cmd.Parameters.AddWithValue("@HourlyRate", mechanic.HourlyRate);
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
    } //end of public class
}
