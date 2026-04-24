using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Helper
{
    public class LaborPartRepository : BaseRepository
    {
        public List<LaborLineItem> GetLaborByRepairOrder(int repairOrderId)
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

        public List<PartsLineItem> GetPartsByRepairOrder(int repairOrderId)
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
    }
}
