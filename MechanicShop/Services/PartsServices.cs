using MechanicShop.Classes;
using System.Collections.Generic;

namespace MechanicShop.Services
{
    public class PartsServices
    {
        public List<object> ProjectForGrid(List<PartsLineItem> items)
        {
            List<object> result = new List<object>();

            foreach (PartsLineItem p in items)
            {
                var row = new
                {
                    PartsLineItemId = p.PartsLineItemId,
                    PartName = p.PartName,
                    Quantity = p.Quantity,
                    UnitCost = p.UnitCost.ToString("C"),
                    TotalCost = p.TotalCost.ToString("C")
                };

                result.Add(row);
            }

            return result;
        }
    }
}