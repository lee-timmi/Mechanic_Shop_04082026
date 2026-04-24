using MechanicShop.Classes;
using MechanicShop.Helper;
using System.Collections.Generic;

namespace MechanicShop.Services
{
    public class VehicleService
    {
        private readonly VehicleRepository _repo;
        private readonly CustomerRepository _customerRepo;
        private readonly AuditService _audit;

        public VehicleService(VehicleRepository repo, CustomerRepository customerRepo,
                                 AuditService audit)
        {
            _repo = repo;
            _customerRepo = customerRepo;
            _audit = audit;
        }

        public List<Vehicle> GetAll()
        {
            return _repo.GetAll();
        }
        public List<Vehicle> GetByCustomer(int customerId) => _repo.GetByCustomer(customerId);
        public void Add(Vehicle vehicle)
        {
            _repo.Add(vehicle);
            _audit.Log("Created", "Vehicle", vehicle.VehicleID,
                $"{vehicle.Year} {vehicle.Make} {vehicle.Model} added");
        }
        public void Update(Vehicle vehicle) 
        { 
            _repo.Update(vehicle);
            _audit.Log("Updated", "Vehicle", vehicle.VehicleID,
                $"{vehicle.Year} {vehicle.Make} {vehicle.Model} updated");
        }
        public void Delete(int vehicleId)
        {
            _repo.Delete(vehicleId);
            _audit.Log("Deleted", "Vehicle", vehicleId,
                $"Vehicle {vehicleId} deleted");
        }

        public string GetCustomerDisplayName(int customerId)
        {
            var customer = _customerRepo.GetByID(customerId);
            return customer != null ? $"Vehicles for: {customer.FirstName} {customer.LastName}" : "";
        }
    }
}
