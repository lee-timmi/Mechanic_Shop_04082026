using MechanicShop.Classes;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicShop.Helper
{
    public class DBHelper
    {
        // Private Read-Only
        private readonly CustomerRepository customerRepository;
        private readonly VehicleRepository vehicleRepository;
        private readonly RepairOrderRepository repairOrderRepository;
        private readonly LaborPartRepository laborPartRepository;

        private string connectionString { get; }

        public DBHelper()
        {
            string dbPath = Path.Combine(Application.StartupPath, "MechanicShopDB.accdb");
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";

            customerRepository = new CustomerRepository();
            vehicleRepository = new VehicleRepository(); 
            repairOrderRepository = new RepairOrderRepository();
            laborPartRepository = new LaborPartRepository();
        }

        /*
         *   The DBHelper is referencing from other repositories that inherit the base repo.
         *   This is to help reduce any SOLID principle violations.
         */

        // Customer Delegations
        public Customer GetCustomerByID(int id) => customerRepository.GetByID(id);
        public List<Customer> GetAllCustomers() => customerRepository.GetAll();
        public void AddCustomers(Customer customer) => customerRepository.Add(customer);
        public void UpdateCustomers(Customer customer) => customerRepository.Update(customer);
        public void DeleteCustomers(int id) => customerRepository.Delete(id);

        // Vehicle Delegations
        public List<Vehicle> GetAllVehicle() => vehicleRepository.GetAll();
        public List<Vehicle> GetVehiclesByCustomer(int id) => vehicleRepository.GetByCustomer(id);
        public Vehicle GetVehicleByID(int id) => vehicleRepository.GetById(id);
        public void AddVehicle(Vehicle vehicle) => vehicleRepository.Add(vehicle);
        public void DeleteVehicle(int id) => vehicleRepository.Delete(id);

        // Repair Order Delegations
        public List<RepairOrder> GetAllRepairOrders() => repairOrderRepository.GetAll();
        public List<RepairOrder> SearchRepairOrders(string name, DateTime? startDate, 
                                    DateTime? endDate, string status) => repairOrderRepository.Search(name, startDate, endDate, status);

        public void SaveRepairOrder(RepairOrder repairOrder, List<LaborLineItem> laborItem, 
                                    List<PartsLineItem> partsItem) => repairOrderRepository.Save(repairOrder, laborItem, partsItem);

        public void UpdateRepairOrder(RepairOrder r, List<LaborLineItem> l, List<PartsLineItem> p) => repairOrderRepository.Update(r, l, p);
        public void DeleteRepairOrders(int id) => repairOrderRepository.Delete(id);
        public int GetNextOrderNumber(string year) => repairOrderRepository.GetNextOrderNumber(year);

        // Labor and Parts Delegations
        public List<LaborLineItem> GetLaborItemsByRepairOrder(int id) => laborPartRepository.GetLaborByRepairOrder(id);
        public List<PartsLineItem> GetPartsItemsByRepairOrder(int id) => laborPartRepository.GetPartsByRepairOrder(id);

    } // end of class DBHelper
}
