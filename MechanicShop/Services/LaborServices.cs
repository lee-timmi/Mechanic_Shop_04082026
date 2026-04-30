using MechanicShop.Classes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            if (!mechanicId.HasValue)
                return "Unassigned";

            List<Mechanic> mechanics = _mechanicService.GetAllMechanics();

            for (int i = 0; i < mechanics.Count; i++)
            {
                if (mechanics[i].MechanicID == mechanicId.Value)
                    return mechanics[i].FullName;
            }

            return "Unknown";
        }

        public int? PromptForMechanic(out bool cancelled)
        {
            cancelled = false;
            List<Mechanic> mechanics = _mechanicService.GetAllMechanics();

            if (mechanics.Count == 0)
            {
                MessageBox.Show(
                    "No mechanics are registered in the system.\n\nPlease add at least one mechanic before adding labor items.",
                    "No Mechanics Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cancelled = true;
                return null;
            }

            string mechanicList = "";
            for (int i = 0; i < mechanics.Count; i++)
            {
                mechanicList += (i + 1).ToString() + ". " + mechanics[i].FullName;
                if (i < mechanics.Count - 1)
                    mechanicList += Environment.NewLine;
            }

            string choice = Interaction.InputBox(
                "Assign a mechanic (or Cancel to abort):" + Environment.NewLine + mechanicList,
                "Assign Mechanic", "");

            if (string.IsNullOrEmpty(choice))
            {
                cancelled = true;
                return null;
            }

            int index;
            if (int.TryParse(choice, out index) && index >= 1 && index <= mechanics.Count)
                return mechanics[index - 1].MechanicID;

            return null;
        }
    }
}
