using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Models
{
    public class ServiceType
    {
        // Properties
        public int ServiceTypeId { get; set; }
        public string Name { get; set; }
        public decimal ServiceDefaultHours { get; set; }
        public decimal ServiceHourlyRate { get; set; }

        // Public Methods
        public LaborLineItem CreateLaborLineItem()
        {
            LaborLineItem item = new LaborLineItem
            {
                LaborDescription = this.Name,
                LaborHours = this.ServiceDefaultHours,
                LaborHourlyRate = this.ServiceHourlyRate
            };
            item.CalculateLaborCost();
            return item;
        }

        public decimal GetDefaultCost()
        {
            return ServiceDefaultHours * ServiceHourlyRate;
        }
    }
}
