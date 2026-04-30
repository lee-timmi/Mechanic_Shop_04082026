using MechanicShop.Classes;
using System.Collections.Generic;

namespace MechanicShop.Services
{
    public static class CostCalculator
    {
        public static decimal LaborTotal(List<LaborLineItem> items)
        {
            decimal total = 0;

            foreach (LaborLineItem item in items)
            {
                total += item.LaborCost;
            }

            return total;
        }

        public static decimal PartsTotal(List<PartsLineItem> items)
        {
            decimal total = 0;

            foreach (PartsLineItem item in items)
            {
                total += item.TotalCost;
            }

            return total;
        }

        public static decimal GrandTotal(List<LaborLineItem> labor, List<PartsLineItem> parts)
        {
            return LaborTotal(labor) + PartsTotal(parts);
        }
    }
}
