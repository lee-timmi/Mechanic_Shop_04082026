using System;
using System.Collections.Generic;

namespace MechanicShop.Classes
{
    public class Mechanic
    {
        // Properties (Id, FirstName, LastName, HourlyRate)
        public int MechanicID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Specialty { get; set; }
        public decimal HourlyRate { get; set; }
        public string Phone { get; set; }
        public bool isActive { get; set; }

        // Nav Property
        public List<LaborLineItem> LaborLineItems { get; set; } = new List<LaborLineItem>();

        // Constructor
        public Mechanic()
        {
            LaborLineItems = new List<LaborLineItem>();
        }

        // Public methods
        public List<LaborLineItem> GetAssignedLaborItems()
        {
            return LaborLineItems;
        }

        public decimal GetTotalLaborValue()
        {
            decimal total = 0;

            foreach (LaborLineItem item in LaborLineItems)
            {
                total += item.LaborCost;
            }

            return total;
        }

        public void UpdateHourlyRate(decimal newRate)
        {
            if (HourlyRate <= 0)
            {
                throw new ArgumentException("Hourly rate must be greater than zero.");
            }

            HourlyRate = newRate;
        }
    }
}
