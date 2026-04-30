using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace MechanicShop.Helper
{
    public class LaborPartRepository : BaseRepository
    {
        public List<LaborLineItem> GetLaborByRepairOrder(int repairOrderId)
        {
            List<LaborLineItem> items = new List<LaborLineItem>();
            string query = "SELECT * FROM LaborLineItems WHERE RepairOrderID = @RepairOrderID";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@RepairOrderID", repairOrderId);
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LaborLineItem item = new LaborLineItem();
                    item.LaborLineItemId  = Convert.ToInt32(reader["LaborLineItemID"]);
                    item.RepairOrderId    = Convert.ToInt32(reader["RepairOrderID"]);
                    item.LaborDescription = reader["LaborDescription"].ToString();
                    item.LaborHours       = Convert.ToDecimal(reader["LaborHours"]);
                    item.LaborHourlyRate  = Convert.ToDecimal(reader["LaborHourlyRate"]);

                    if (reader["MechanicID"] == DBNull.Value)
                        item.MechanicID = null;
                    else
                        item.MechanicID = Convert.ToInt32(reader["MechanicID"]);

                    items.Add(item);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading labor items: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return items;
        }

        public List<PartsLineItem> GetPartsByRepairOrder(int repairOrderId)
        {
            List<PartsLineItem> items = new List<PartsLineItem>();
            string query = "SELECT * FROM PartsLineItems WHERE RepairOrderID = @RepairOrderID";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@RepairOrderID", repairOrderId);
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PartsLineItem item = new PartsLineItem(
                        Convert.ToInt32(reader["PartsLineItemID"]),
                        reader["PartName"].ToString(),
                        Convert.ToInt32(reader["Quantity"]),
                        Convert.ToDecimal(reader["UnitCost"])
                    );
                    item.RepairOrderId = Convert.ToInt32(reader["RepairOrderID"]);
                    items.Add(item);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading parts items: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return items;
        }
    }
}
