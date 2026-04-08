using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechanicShop.Models;
using MechanicShopSystem.Helpers;

namespace MechanicShop.Forms
{
    public partial class frmVehicle : Form
    {
        VehicleApiService _vehicleAPI;

        public frmVehicle()
        {
            InitializeComponent();
            _vehicleAPI = new VehicleApiService();

            // Make/Model/Year auto-fill from API
            txtMake.ReadOnly = true;
            txtModel.ReadOnly = true;
            txtYear.ReadOnly = true;

            // Status Label for API feedback
            lblStatus.Text = "Ready. Enter VIN and Lookup.";
            lblStatus.ForeColor = Color.Gray;
        }

        private async void btnVINLookup_Click(object sender, EventArgs e)
        {
            string vin = txtVIN.Text.Trim().ToUpper();

            // Validation for VIN
            if (vin.Length != 17)
            {
                lblStatus.Text = "Invalid VIN. Must be 17 characters.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            // Clear previous status
            ClearVehicleFields();

            // Loading status
            btnVINLookup.Enabled = false;
            lblStatus.Text = "Looking up VIN...";
            lblStatus.ForeColor = Color.Blue;

            try
            {
                // Call the API to get vehicle details
                var vehicle = await _vehicleAPI.GetVehicleByVIN(vin);

                if (!string.IsNullOrEmpty(vehicle.Make))
                {
                    txtMake.Text = vehicle.Make;
                    txtModel.Text = vehicle.Model;
                    txtYear.Text = vehicle.Year;
                    lblStatus.Text = "Vehicle details loaded successfully.";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "No details found for this VIN.";
                    lblStatus.ForeColor = Color.Orange;

                    // Optionally, allow manual entry if API fails
                    txtMake.ReadOnly = false;
                    txtModel.ReadOnly = false;
                    txtYear.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error fetching vehicle details.";
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("An error occurred while fetching vehicle details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Allow manual entry on error
                txtMake.ReadOnly = false;
                txtModel.ReadOnly = false;
                txtYear.ReadOnly = false;
            }
            finally
            {
                btnVINLookup.Enabled = true;
            }
        }

        private void ClearVehicleFields()
        {
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();

            // Keep read-only until API fails or user needs to edit
            txtMake.ReadOnly = true;
            txtModel.ReadOnly = true;
            txtYear.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation for required fields
            if (!string.IsNullOrWhiteSpace(txtMake.Text))
            {
                MessageBox.Show("Make is required. Please enter the vehicle make.", "Validation Error");
                txtMake.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Model is required. Please enter the vehicle make.", "Validation Error");
                txtModel.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtVIN.Text))
            {
                MessageBox.Show("VIN is required. Please enter the vehicle make.", "Validation Error");
                txtVIN.Focus();
                return;
            }

            // Creating vehicle obj
            var vehicle = new Vehicle
            {
                VIN = txtVIN.Text.Trim().ToUpper(),
                Make = txtMake.Text.Trim(),
                Model = txtModel.Text.Trim(),
                Year = int.TryParse(txtYear.Text, out int year) ? year : 0,
                LicensePlate = txtLicensePlate.Text.Trim().ToUpper(),
                CurrentMileage = int.TryParse(txtCurrentMileage.Text, out int mileage) ? mileage : 0
            };

            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
