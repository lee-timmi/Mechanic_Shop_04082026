using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public double CurrentMileage { get; set; }

        // Navigation properties
        public List<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();


        // Methods
        public void AddRepairOrder(RepairOrder order)
        {
            if (order != null)
            {
                RepairOrders.Add(order);
            }
        }

        public List<RepairOrder> GetRepairHistory()
        {
            return RepairOrders.OrderByDescending(o => o.DateOpened).ToList();
        }

        public void UpdateMileage(int newMileage)
        {
            if (newMileage < CurrentMileage)
            {
                throw new Exception("New mileage cannot be less than current mileage");
            }
            CurrentMileage = newMileage;
        }

        public decimal GetTotalMaintenanceCost()
        {
            return RepairOrders.Sum(o => o.TotalCost);
        }
    }
}
