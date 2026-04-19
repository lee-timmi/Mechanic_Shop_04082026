using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Services
{
    public static class CostCalculator
    {
        public static decimal LaborTotal(List<LaborLineItem> items)
        => items.Sum(l => l.LaborCost);

        public static decimal PartsTotal(List<PartsLineItem> items)
            => items.Sum(p => p.TotalCost);

        public static decimal GrandTotal(List<LaborLineItem> labor, List<PartsLineItem> parts)
            => LaborTotal(labor) + PartsTotal(parts);
    }
}
