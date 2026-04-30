using MechanicShop.Classes;
using MechanicShop.Helper;
using System.Collections.Generic;

namespace MechanicShop.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _repo;
        private readonly AuditService _audit;

        public CustomerService(CustomerRepository repo, AuditService audit)
        {
            _repo  = repo;
            _audit = audit;
        }

        public List<Customer> GetAll()
        {
            return _repo.GetAll();
        }

        public void Add(Customer customer)
        {
            _repo.Add(customer);
            if (_audit != null)
            {
                _audit.Log("Created", "Customer", customer.CustomerID,
                    customer.FirstName + " " + customer.LastName + " added");
            }
        }

        public void Update(Customer customer)
        {
            _repo.Update(customer);
            if (_audit != null)
            {
                _audit.Log("Updated", "Customer", customer.CustomerID,
                    customer.FirstName + " " + customer.LastName + " updated");
            }
        }

        public void Delete(int customerId)
        {
            _repo.Delete(customerId);
            if (_audit != null)
            {
                _audit.Log("Deleted", "Customer", customerId,
                    "Customer " + customerId + " deleted");
            }
        }

        public List<Customer> Search(string term)
        {
            List<Customer> all    = _repo.GetAll();
            List<Customer> result = new List<Customer>();

            if (string.IsNullOrWhiteSpace(term))
                return all;

            string lowerTerm = term.ToLower();

            for (int i = 0; i < all.Count; i++)
            {
                Customer c = all[i];
                if (c.FirstName.ToLower().Contains(lowerTerm) ||
                    c.LastName.ToLower().Contains(lowerTerm) ||
                    c.Email.ToLower().Contains(lowerTerm) ||
                    c.PhoneNumber.ToLower().Contains(lowerTerm))
                {
                    result.Add(c);
                }
            }

            return result;
        }
    }
}
