using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Helper
{
    public class AuditRepository : BaseRepository
    {
        public void Log(AuditLog entry)
        {
            string queryLog = @"INSERT INTO AuditLog
                (ActionType, EntityType, EntityID, Description, [Timestamp], PerformedBy)
                VALUES (?, ?, ?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(queryLog, conn))
            {
                cmd.Parameters.Add(new OleDbParameter("@ActionType", OleDbType.VarWChar) { Value = entry.ActionType });
                cmd.Parameters.Add(new OleDbParameter("@EntityType", OleDbType.VarWChar) { Value = entry.EntityType });
                cmd.Parameters.Add(new OleDbParameter("@EntityID", OleDbType.Integer) { Value = entry.EntityID });
                cmd.Parameters.Add(new OleDbParameter("@Description", OleDbType.VarWChar) { Value = entry.Description });
                cmd.Parameters.Add(new OleDbParameter("@Timestamp", OleDbType.DBDate) { Value = entry.Timestamp });
                cmd.Parameters.Add(new OleDbParameter("@PerformedBy", OleDbType.VarWChar) { Value = entry.PerformedBy });

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<AuditLog> GetAll()
        {
            var logs = new List<AuditLog>();
            string queryGet = "SELECT * FROM AuditLog ORDER BY [Timestamp] DESC";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(queryGet, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        logs.Add(new AuditLog
                        {
                            AuditID = Convert.ToInt32(reader["AuditID"]),
                            ActionType = reader["ActionType"].ToString(),
                            EntityType = reader["EntityType"].ToString(),
                            EntityID = Convert.ToInt32(reader["EntityID"]),
                            Description = reader["Description"].ToString(),
                            Timestamp = Convert.ToDateTime(reader["Timestamp"]),
                            PerformedBy = reader["PerformedBy"].ToString()
                        });
                    }
                }
            }
            return logs;
        }

        public void DeleteAll()
        {
            string queryDelete = "DELETE FROM AuditLog";

            using (OleDbConnection conn  = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(queryDelete, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
