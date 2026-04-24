using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Services
{
    public class PartsServices
    {
        public List<object> ProjectForGrid(List<PartsLineItem> items)
        {
            return items.Select(p => (object)new
            {
                p.PartsLineItemId,
                p.PartName,
                p.Quantity,
                UnitCost = p.UnitCost.ToString("C"),
                TotalCost = p.TotalCost.ToString("C")
            }).ToList();
        }
    }
}
