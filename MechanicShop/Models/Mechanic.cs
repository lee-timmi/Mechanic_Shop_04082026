using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Models
{
    public class Mechanic
    {
        // Properties (Id, FirstName, LastName, HourlyRate)
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal HourlyRate { get; set; }

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
            return LaborLineItems.Sum(item => item.LaborCost);
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
