using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Classes
{
    public class PartsLineItem
    {
        // Properties (Id, PartName, Quantity, UnitCost, TotalCost)
        public int Id { get; set; }
        public string PartName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalCost { get; set; }

        // Constructor
        public PartsLineItem(int id, string partName, int quantity, decimal unitCost)
        {
            Id = id;
            PartName = partName;
            Quantity = quantity;
            UnitCost = unitCost;
        }

        // Navigation property to the associated RepairOrder
        public RepairOrder repairOrder { get; set; }

        // Public methods
        public decimal CalculateTotalCost()
        {
            TotalCost = Quantity * UnitCost;
            return TotalCost;
        }

        public void UpdateQuantity(int newQuantity)
        {
            if (newQuantity < 0)
            {
                throw new ArgumentException("Quantity cannot be negative.");
            }

            Quantity = newQuantity;
            CalculateTotalCost();
        }

        public void UpdateUnitCost(decimal newUnitCost)
        {
            if (newUnitCost <= 0)
            {
                throw new ArgumentException("Unit cost cannot be negative.");
            }
            UnitCost = newUnitCost;
            CalculateTotalCost();
        }
    }
}
