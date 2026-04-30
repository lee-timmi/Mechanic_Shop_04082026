using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace MechanicShop.Helper
{
    public class CustomerRepository : BaseRepository
    {
        public Customer GetByID(int customerId)
        {
            string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Customer c = new Customer();
                    c.CustomerID  = Convert.ToInt32(reader["CustomerID"]);
                    c.FirstName   = reader["FirstName"].ToString();
                    c.LastName    = reader["LastName"].ToString();
                    c.PhoneNumber = reader["Phone"].ToString();
                    c.Email       = reader["Email"].ToString();
                    c.Address     = reader["Address"].ToString();
                    reader.Close();
                    return c;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting customer: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            string query = "SELECT * FROM Customers ORDER BY LastName, FirstName";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer c = new Customer();
                    c.CustomerID  = Convert.ToInt32(reader["CustomerID"]);
                    c.FirstName   = reader["FirstName"].ToString();
                    c.LastName    = reader["LastName"].ToString();
                    c.PhoneNumber = reader["Phone"].ToString();
                    c.Email       = reader["Email"].ToString();
                    c.Address     = reader["Address"].ToString();
                    customers.Add(c);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading customers: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return customers;
        }

        public void Add(Customer customer)
        {
            string query = "INSERT INTO Customers (FirstName, LastName, Phone, Email, Address) VALUES (@FirstName, @LastName, @Phone, @Email, @Address)";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName",  customer.LastName);
                cmd.Parameters.AddWithValue("@Phone",     customer.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email",     customer.Email);
                cmd.Parameters.AddWithValue("@Address",   customer.Address);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding customer: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Update(Customer customer)
        {
            string query = "UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Email = @Email, Address = @Address WHERE CustomerID = @CustomerID";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@FirstName",  customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName",   customer.LastName);
                cmd.Parameters.AddWithValue("@Phone",      customer.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email",      customer.Email);
                cmd.Parameters.AddWithValue("@Address",    customer.Address);
                cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating customer: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Delete(int customerId)
        {
            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(query, conn);

            try
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting customer: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
