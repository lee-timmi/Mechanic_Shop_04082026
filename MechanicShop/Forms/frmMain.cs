using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechanicShopSystem.Helpers;

namespace MechanicShop
{
    public partial class frmMain : Form
    {
        private VehicleApiService VehicleApiService;
        public frmMain()
        {
            VehicleApiService = new VehicleApiService();
            InitializeComponent();
        }

        private async void btnLoadMakes_Click(object sender, EventArgs e)
        {
            btnLoadMakes.Enabled = false;
            lblStatus.Text = "Loading makes...";

            try
            {
                // Call API asynchronously
                List<string> makes = await VehicleApiService.GetAllMakes();

                // Filter results based on user selection
                var brandSelect = makes.FindAll(m =>
                    m == "HONDA" ||
                    m == "TOYOTA");

                // Display results
                lboMakes.Items.Clear();
                lboMakes.DataSource = brandSelect;

                // Populate combo box with filtered results
                cboSelection.DataSource = brandSelect;

                lblStatus.Text = $"Loaded {brandSelect.Count} makes.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error loading makes.";
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                btnLoadMakes.Enabled = true;
            }
        }

        private void cboSelection_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboSelection.SelectedItem != null)
            {
                string selectedMake = cboSelection.SelectedItem.ToString();
                lblStatus.Text = $"You selected: {selectedMake}";
            }
        }
    }
}
