using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Classes
{
    public class RepairOrder
    {
        // Properties
        public int RepairOrderId { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime? DateClosed { get; set; }
        public string RepairStatus { get; set; } = "Pending";
        public int MileageAtService { get; set; }
        public decimal TotalCost { get; set; }

        // Foreign keys (associations)
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public List<LaborLineItem> LaborLineItems { get; set; } = new List<LaborLineItem>();
        public List<PartsLineItem> PartsLineItems { get; set; } = new List<PartsLineItem>();

        // Constructor
        public RepairOrder()
        {
            DateOpened = DateTime.Now;
            LaborLineItems = new List<LaborLineItem>();
            PartsLineItems = new List<PartsLineItem>();
        }

        // Public Methods
        public void AddLaborLineItem(LaborLineItem item)
        {
            if (item != null)
            {
                LaborLineItems.Add(item);
                CalculateTotalCost();
            }
        }

        public void AddPartsLineItem(PartsLineItem item)
        {
            if (item != null)
            {
                PartsLineItems.Add(item);
                CalculateTotalCost();
            }
        }

        public decimal CalculateTotalCost()
        {
            decimal laborTotal = GetLaborTotal();
            decimal partsTotal = GetPartsTotal();
            TotalCost = laborTotal + partsTotal;
            return TotalCost;
        }

        public void Close()
        {
            if (RepairStatus != "Completed")
            {
                throw new Exception("Cannot close order that is not completed");
            }
            DateClosed = DateTime.Now;
            RepairStatus = "Closed";
        }

        public decimal GetLaborTotal()
        {
            return LaborLineItems.Sum(item => item.LaborCost);
        }

        public decimal GetPartsTotal()
        {
            return PartsLineItems.Sum(item => item.TotalCost);
        }

        public void UpdateStatus(string newStatus)
        {
            var validStatuses = new[] { "Pending", "In Progress", "Completed", "Closed" };
            if (!validStatuses.Contains(newStatus))
            {
                throw new Exception("Invalid status");
            }
            RepairStatus = newStatus;
        }
    }
}
