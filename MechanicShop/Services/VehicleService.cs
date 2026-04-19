using MechanicShop.Classes;
using MechanicShop.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Services
{
    public class VehicleService
    {
        private readonly VehicleRepository _repo;
        private readonly CustomerRepository _customerRepo;

        public VehicleService(VehicleRepository repo, CustomerRepository customerRepo)
        {
            _repo = repo;
            _customerRepo = customerRepo;
        }

        public List<Vehicle> GetByCustomer(int customerId) => _repo.GetByCustomer(customerId);
        public void Add(Vehicle vehicle) => _repo.Add(vehicle);
        public void Update(Vehicle vehicle) => _repo.Update(vehicle);
        public void Delete(int vehicleId) => _repo.Delete(vehicleId);

        public string GetCustomerDisplayName(int customerId)
        {
            var customer = _customerRepo.GetByID(customerId);
            return customer != null ? $"Vehicles for: {customer.FirstName} {customer.LastName}" : "";
        }
    }
}
