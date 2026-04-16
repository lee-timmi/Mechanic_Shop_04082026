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
using MechanicShop.Classes;
using MechanicShop.Helper;
using MehcnicShop.Helper;
using System.Net.Http;

namespace MechanicShop.Forms
{
    public partial class frmVehicle : Form
    {
        VehicleApiService _vehicleAPI;
        private int customerID;

        public frmVehicle()
        {
            InitializeComponent();
            // Initialize the API service so the field is not null when used
            _vehicleAPI = new VehicleApiService();
        }

        public frmVehicle(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            // Initialize the API service so the field is not null when used
            _vehicleAPI = new VehicleApiService();
            LoadCustomerInfo();
        }

        private async void btnVINLookup_Click(object sender, EventArgs e)
        {
            // Normalize and validate VIN before any network call
            string vin = txtVIN.Text.Trim().ToUpper();

            if (vin.Length != 17)
            {
                lblStatus.Text = "Invalid VIN. Must be 17 characters.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            // Clear previous values and set loading state
            ClearVehicleFields();
            btnVINLookup.Enabled = false;
            lblStatus.Text = "Looking up VIN...";
            lblStatus.ForeColor = Color.Blue;

            try
            {
                // Use the initialized field (avoid creating a local unused service)
                var vehicle = await _vehicleAPI.GetVehicleByVIN(vin);

                if (vehicle != null && !string.IsNullOrEmpty(vehicle.Make))
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
                    // Allow manual entry
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
            if (string.IsNullOrWhiteSpace(txtMake.Text))
            {
                MessageBox.Show("Make is required. Please enter the vehicle make.", "Validation Error");
                txtMake.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Model is required. Please enter the vehicle make.", "Validation Error");
                txtModel.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVIN.Text))
            {
                MessageBox.Show("VIN is required. Please enter the vehicle make.", "Validation Error");
                txtVIN.Focus();
                return;
            }

            // Creating vehicle obj
            var vehicle = new Vehicle
            {
                CustomerID = customerID,
                VIN = txtVIN.Text.Trim().ToUpper(),
                Make = txtMake.Text.Trim(),
                Model = txtModel.Text.Trim(),
                Year = int.TryParse(txtYear.Text, out int year) ? year : 0,
                LicensePlate = txtLicensePlate.Text.Trim().ToUpper(),
                CurrentMileage = (int)nudCurrentMileage.Value
            };

            DBHelper dbHelper = new DBHelper();
            dbHelper.AddVehicle(vehicle);

            MessageBox.Show("Vehicle added successfully!");
            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Load customer info for display
        private void LoadCustomerInfo()
        {
            var dbHelper = new DBHelper();
            var customer = dbHelper.GetCustomerById(customerID);
            if (customer != null)
            {
                lblCustomer.Text = $"Adding Vehicle for: {customer.FirstName} {customer.LastName}";
            }

        }
    }
}
