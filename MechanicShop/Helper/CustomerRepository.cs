using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Helper
{
    public class CustomerRepository : BaseRepository
    {
        public Customer GetByID (int customerId)
        {
            string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Customer
                        {
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            PhoneNumber = reader["Phone"]?.ToString() ?? "",
                            Email = reader["Email"]?.ToString() ?? "",
                            Address = reader["Address"]?.ToString() ?? ""
                        };
                    }
                }
            }
            return null;
        }

        public List<Customer> GetAll()
        {
            var customers = new List<Customer>();
            string query = "SELECT * FROM Customers ORDER BY LastName, FirstName";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            PhoneNumber = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString()
                        });
                    }
                }
            }

            return customers;
        }
        public void Add(Customer customer)
        {
            string query = "INSERT INTO Customers (FirstName, LastName, Phone, Email, Address) VALUES (@FirstName, @LastName, @Phone, @Email, @Address)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@Phone", (object)customer.PhoneNumber ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object)customer.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)customer.Address ?? DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Update(Customer customer)
        {
            string query = "UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Email = @Email, Address = @Address WHERE CustomerID = @CustomerID";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@Phone", (object)customer.PhoneNumber ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object)customer.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)customer.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int customerId)
        {
            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
