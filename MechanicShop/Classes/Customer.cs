using System.Collections.Generic;

namespace MechanicShop.Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        // Navigation property
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();
        public int CustomerID { get; internal set; }


        // Methods
        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public List<Vehicle> GetVehicles()
        {
            return Vehicles;
        }

        public List<RepairOrder> GetRepairHistory()
        {
            return RepairOrders;
        }
    }
}
