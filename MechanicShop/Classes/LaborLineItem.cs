using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Classes
{
    public class LaborLineItem
    {
        // Properties (Id, Description, Hours, HourlyRate, LaborCost)
        public int LaborLineItemId { get; set; }
        public string LaborDescription { get; set; }
        public decimal LaborHours { get; set; }
        public decimal LaborHourlyRate { get; set; }
        public decimal LaborCost
        {
            get
            {
                return LaborHours * LaborHourlyRate;
            }
        }

        // Foreign key (association)
        public int RepairOrderId { get; set; }
        public int? MechanicID { get; set; }

        // Parameterless constructor
        public LaborLineItem()
        {
        }

        // Navigation property
        public RepairOrder RepairOrder { get; set; }
        public Mechanic Mechanic { get; set; }
        public ServiceType ServiceType { get; set; }

        // Public Methods
        public decimal CalculateLaborCost()
        {
            return LaborHours * LaborHourlyRate;
        }

        public void AssignMechanic(Mechanic mechanic)
        {
            if (mechanic == null)
            {
                throw new ArgumentNullException(nameof(mechanic), "Mechanic cannot be null.");
            }

            Mechanic = mechanic;
        }

        public void UpdateHours(decimal hours)
        {
            if (hours < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(hours), "Hours cannot be negative.");
            }
            LaborHours = hours;
        }

    }
}
