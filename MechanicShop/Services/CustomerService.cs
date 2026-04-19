using MechanicShop.Classes;
using MechanicShop.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _repo;

        public CustomerService(CustomerRepository repo)
        {
            _repo = repo;
        }

        public List<Customer> GetAll() => _repo.GetAll();
        public void Add(Customer customer) => _repo.Add(customer);
        public void Update(Customer customer) => _repo.Update(customer);
        public void Delete(int customerId) => _repo.Delete(customerId);

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
