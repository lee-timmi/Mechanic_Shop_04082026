using MechanicShop.Classes;
using MechanicShop.Helper;
using System.Collections.Generic;
using System.Linq;

namespace MechanicShop.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _repo;
        private readonly AuditService _audit;

        public CustomerService(CustomerRepository repo, AuditService audit)
        {
            _repo = repo;
            _audit = audit;
        }

        public List<Customer> GetAll() => _repo.GetAll();
        public void Add(Customer customer)
        {
            _repo.Add(customer);
            _audit.Log("Created", "Customer", customer.CustomerID,
                $"{customer.FirstName} {customer.LastName} added");
        }
        public void Update(Customer customer)
        {
            _repo.Update(customer);
            _audit.Log("Updated", "Customer", customer.CustomerID,
                $"{customer.FirstName} {customer.LastName} updated");
        }
        public void Delete(int customerId)
        {
            _repo.Delete(customerId);
            _audit.Log("Deleted", "Customer", customerId,
                $"Customer {customerId} deleted");
        }

        public List<Customer> Search(string term)
        {
            if (string.IsNullOrWhiteSpace(term)) return _repo.GetAll();

            term = term.ToLower();
            return _repo.GetAll().Where(c =>
                c.FirstName.ToLower().Contains(term) ||
                c.LastName.ToLower().Contains(term) ||
                c.Email.ToLower().Contains(term) ||
                c.PhoneNumber.ToLower().Contains(term)).ToList();
        }
    }
}
