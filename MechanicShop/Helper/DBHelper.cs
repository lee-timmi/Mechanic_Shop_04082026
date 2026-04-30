using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace MechanicShop.Helper
{
    public class DBHelper
    {
        // Private Read-Only
        private readonly CustomerRepository customerRepository;
        private readonly VehicleRepository vehicleRepository;
        private readonly RepairOrderRepository repairOrderRepository;
        private readonly LaborPartRepository laborPartRepository;
        private readonly AuditRepository auditRepository;

        private string ConnectionString { get; }

        public DBHelper()
        {
            string dbPath = Path.Combine(Application.StartupPath, "MechanicShopDB.accdb");
            ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";

            customerRepository = new CustomerRepository();
            vehicleRepository = new VehicleRepository();
            repairOrderRepository = new RepairOrderRepository();
            laborPartRepository = new LaborPartRepository();
            auditRepository = new AuditRepository();
        }

        /*
         *   The DBHelper is referencing from other repositories that inherit the base repo.
         *   This is to help reduce any SOLID principle violations.
         */

        // Customer Delegations
        public Customer GetCustomerByID(int id)
        {
            return customerRepository.GetByID(id);
        }
        public List<Customer> GetAllCustomers()
        {
            return customerRepository.GetAll();
        }
        public void AddCustomers(Customer customer)
        {
            customerRepository.Add(customer);
        }
        public void UpdateCustomers(Customer customer)
        {
            customerRepository.Update(customer);
        }
        public void DeleteCustomers(int id)
        {
            customerRepository.Delete(id);
        }

        // Vehicle Delegations
        public List<Vehicle> GetAllVehicle()
        {
            return vehicleRepository.GetAll();
        }

        public List<Vehicle> GetVehiclesByCustomer(int id)
        {
            return vehicleRepository.GetByCustomer(id);
        }
        public Vehicle GetVehicleByID(int id)
        {
            return vehicleRepository.GetById(id);
        }
        public void AddVehicle(Vehicle vehicle)
        {
            vehicleRepository.Add(vehicle);
        }
        public void UpdateVehicle(Vehicle vehicle)
        {
            vehicleRepository.Update(vehicle);
        }
        public void DeleteVehicle(int id)
        {
            vehicleRepository.Delete(id);
        }

        // Repair Order Delegations
        public List<RepairOrder> GetAllRepairOrders()
        {
            return repairOrderRepository.GetAll();
        }
        public List<RepairOrder> SearchRepairOrders(string name, DateTime? startDate,
                                    DateTime? endDate, string status)
        {
            return repairOrderRepository.Search(name, startDate, endDate, status);
        }
        public void SaveRepairOrder(RepairOrder repairOrder, List<LaborLineItem> laborItem,
                                    List<PartsLineItem> partsItem)
        {
            repairOrderRepository.Save(repairOrder, laborItem, partsItem);
        }
        public void UpdateRepairOrder(RepairOrder r, List<LaborLineItem> l, List<PartsLineItem> p)
        {
            repairOrderRepository.Update(r, l, p);
        }
        public void DeleteRepairOrders(int id)
        {
            repairOrderRepository.Delete(id);
        }
        public int GetNextOrderNumber(string year)
        {
            return repairOrderRepository.GetNextOrderNumber(year);
        }

        // Labor and Parts Delegations
        public List<LaborLineItem> GetLaborItemsByRepairOrder(int id)
        {
            return laborPartRepository.GetLaborByRepairOrder(id);
        }
        public List<PartsLineItem> GetPartsItemsByRepairOrder(int id)
        {
            return laborPartRepository.GetPartsByRepairOrder(id);
        }

        // Audit Log Methods
        public List<AuditLog> GetAllAuditLogs()
        {
            return auditRepository.GetAll();
        }

        public void AddAuditLog(string actionType, string entityType, int entityID,
                                string description, string performedBy)
        {
            auditRepository.Log(new AuditLog
            {
                ActionType = actionType,
                EntityType = entityType,
                EntityID = entityID,
                Description = description,
                Timestamp = DateTime.Now,
                PerformedBy = performedBy
            });
        }

        public void ClearAllAuditLogs()
        {
            auditRepository.DeleteAll();
        }

        // =========================
        // User Authentication Methods
        // =========================

        public User ValidateUser(string username, string password)
        {
            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                string query = @"SELECT UserId, Username, [Password], [Role]
                                 FROM Users
                                 WHERE Username = @Username AND [Password] = @Password AND IsActive = True";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string roleText = reader["Role"].ToString();
                            UserRole parsedRole = UserRole.Staff;

                            Enum.TryParse(roleText, true, out parsedRole);

                            return new User
                            {
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = parsedRole
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool UsernameExists(string username)
        {
            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool AddUser(User user)
        {
            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                string query = @"INSERT INTO Users ([Username], [Password], [Role], [IsActive])
                                 VALUES (@Username, @Password, @Role, @IsActive)";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Role", user.Role.ToString());
                    cmd.Parameters.AddWithValue("@IsActive", true);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                string query = "SELECT UserId, Username, [Password], [Role] FROM Users WHERE IsActive = True";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string roleText = reader["Role"].ToString();
                            UserRole parsedRole = UserRole.Staff;

                            Enum.TryParse(roleText, true, out parsedRole);

                            users.Add(new User
                            {
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = parsedRole
                            });
                        }
                    }
                }
            }

            return users;
        }

    } // end of class DBHelper
}