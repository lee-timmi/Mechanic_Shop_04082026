using MechanicShop.Classes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Services
{
    public class LaborServices
    {
        private readonly MechanicService _mechanicService;

        public LaborServices(MechanicService mechanicService)
        {
            _mechanicService = mechanicService;
        }

        public string GetMechanicName(int? mechanicId)
        {
            if (!mechanicId.HasValue) return "Unassigned";
            var mechanics = _mechanicService.GetAllMechanics();
            var mechanic = mechanics.FirstOrDefault(m => m.MechanicID == mechanicId);
            return mechanic?.FullName ?? "Unknown";
        }

        public List<object> ProjectForGrid(List<LaborLineItem> items)
        {
            return items.Select(l => (object)new
            {
                l.LaborLineItemId,
                l.LaborDescription,
                l.LaborHours,
                l.LaborHourlyRate,
                Mechanic = GetMechanicName(l.MechanicID),
                LaborCost = l.LaborCost.ToString("C")
            }).ToList();
        }

        public int? PromptForMechanic()
        {
            var mechanics = _mechanicService.GetAllMechanics();
            if (mechanics.Count == 0) return null;

            string mechanicNames = string.Join(Environment.NewLine,
                mechanics.Select((m, i) => $"{i + 1}. {m.FullName}"));

            string choice = Interaction.InputBox(
                $"Assign a mechanic (or Cancel to leave unassigned):{Environment.NewLine}{mechanicNames}",
                "Assign Mechanic", "");

            if (int.TryParse(choice, out int index) && index >= 1 && index <= mechanics.Count)
                return mechanics[index - 1].MechanicID;

            return null;
        }
    }
}
