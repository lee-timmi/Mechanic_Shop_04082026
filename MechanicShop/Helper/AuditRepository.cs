using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace MechanicShop.Helper
{
    public class AuditRepository : BaseRepository
    {
        public void Log(AuditLog entry)
        {
            string query = "INSERT INTO AuditLog (ActionType, EntityType, EntityID, Description, [Timestamp], PerformedBy) " +
                           "VALUES (@ActionType, @EntityType, @EntityID, @Description, @Timestamp, @PerformedBy)";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@ActionType",  entry.ActionType);
                cmd.Parameters.AddWithValue("@EntityType",  entry.EntityType);
                cmd.Parameters.AddWithValue("@EntityID",    entry.EntityID);
                cmd.Parameters.AddWithValue("@Description", entry.Description);
                cmd.Parameters.AddWithValue("@Timestamp",   entry.Timestamp);
                cmd.Parameters.AddWithValue("@PerformedBy", entry.PerformedBy);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error logging audit entry: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<AuditLog> GetAll()
        {
            List<AuditLog> logs = new List<AuditLog>();
            string query = "SELECT * FROM AuditLog ORDER BY [Timestamp] DESC";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AuditLog log = new AuditLog();
                    log.AuditID     = Convert.ToInt32(reader["AuditID"]);
                    log.ActionType  = reader["ActionType"].ToString();
                    log.EntityType  = reader["EntityType"].ToString();
                    log.EntityID    = Convert.ToInt32(reader["EntityID"]);
                    log.Description = reader["Description"].ToString();
                    log.Timestamp   = Convert.ToDateTime(reader["Timestamp"]);
                    log.PerformedBy = reader["PerformedBy"].ToString();
                    logs.Add(log);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading audit logs: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return logs;
        }

        public void DeleteAll()
        {
            string query = "DELETE FROM AuditLog";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error clearing audit log: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
