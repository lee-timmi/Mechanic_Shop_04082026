using System;
using System.Collections.Generic;

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
        public int CurrentMileage { get; set; }
        public string DisplayName
        {
            get
            {
                return Year + " " + Make + " " + Model + " - " + LicensePlate;
            }
        }

        // Navigation properties
        public List<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();
        public int VehicleID { get; internal set; }
        public int CustomerID { get; internal set; }


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
            List<RepairOrder> sortedOrders = new List<RepairOrder>(RepairOrders);

            for (int i = 0; i < sortedOrders.Count - 1; i++)
            {
                for (int j = i + 1; j < sortedOrders.Count; j++)
                {
                    if (sortedOrders[j].DateOpened > sortedOrders[i].DateOpened)
                    {
                        RepairOrder temp = sortedOrders[i];
                        sortedOrders[i] = sortedOrders[j];
                        sortedOrders[j] = temp;
                    }
                }
            }

            return sortedOrders;
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
            decimal total = 0;

            foreach (RepairOrder order in RepairOrders)
            {
                total += order.TotalCost;
            }

            return total;
        }
    }
}
