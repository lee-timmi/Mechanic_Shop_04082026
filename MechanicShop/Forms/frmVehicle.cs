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
        public Vehicle selectedVehicle { get; private set; }
        private bool isEditMode = false;
        private DBHelper DBHelper = new DBHelper();
        private List<Vehicle> vehicleList;

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
            LoadVehicles();
            SetupListView();
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

        private void SetupListView()
        {
            lvVehicleList.Columns.Clear();
            lvVehicleList.Columns.Add("Year", 50);
            lvVehicleList.Columns.Add("Make", 80);
            lvVehicleList.Columns.Add("Model", 100);
            lvVehicleList.Columns.Add("VIN", 150);
            lvVehicleList.Columns.Add("Plate", 80);
            lvVehicleList.Columns.Add("Mileage", 80);
            lvVehicleList.View = View.Details;
            lvVehicleList.FullRowSelect = true;
            lvVehicleList.MultiSelect = false;
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

            DBHelper dbHelper = new DBHelper();

            if (isEditMode && selectedVehicle != null)
            {
                selectedVehicle.VIN = txtVIN.Text.Trim().ToUpper();
                selectedVehicle.Make = txtMake.Text.Trim();
                selectedVehicle.Model = txtModel.Text.Trim();
                selectedVehicle.Year = int.TryParse(txtYear.Text, out int editYear) ? editYear : 0;
                selectedVehicle.LicensePlate = txtLicensePlate.Text.Trim().ToUpper();
                selectedVehicle.CurrentMileage = (int)nudCurrentMileage.Value;

                dbHelper.UpdateVehicle(selectedVehicle);
                MessageBox.Show("Vehicle updated successfully!");
            } else
            {
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
                
                dbHelper.AddVehicle(vehicle);
                MessageBox.Show("Vehicle added successfully!");
            }
 
            DialogResult = DialogResult.OK;
            LoadVehicles();
            ClearForm();
        }

        // Load customer info for display
        private void LoadCustomerInfo()
        {
            var dbHelper = new DBHelper();
            var customer = dbHelper.GetCustomerById(customerID);
            if (customer != null)
            {
                lblCustomer.Text = $"Vehicles for: {customer.FirstName} {customer.LastName}";
            }
        }

        public void LoadVehicleForEditing(Vehicle vehicle)
        {
            selectedVehicle = vehicle;
            isEditMode = true;

            txtVIN.Text = vehicle.VIN;
            txtMake.Text = vehicle.Make;
            txtModel.Text = vehicle.Model;
            txtYear.Text = vehicle.Year.ToString();
            txtLicensePlate.Text = vehicle.LicensePlate;
            nudCurrentMileage.Value = vehicle.CurrentMileage;

            this.Text = "Edit Vehicle";
            btnSave.Text = "Update Vehicle";
        }

        private void LoadVehicles()
        {
            vehicleList = DBHelper.GetVehiclesByCustomer(customerID);
            lvVehicleList.Items.Clear();

            foreach (var v in vehicleList)
            {
                ListViewItem item = new ListViewItem(v.Year.ToString());
                item.SubItems.Add(v.Make);
                item.SubItems.Add(v.Model);
                item.SubItems.Add(v.VIN ?? "");
                item.SubItems.Add(v.LicensePlate ?? "");
                item.SubItems.Add(v.CurrentMileage.ToString());
                item.Tag = v;
                lvVehicleList.Items.Add(item);
            }
        }

        private void ClearForm()
        {
            txtVIN.Clear();
            txtLicensePlate.Clear();
            nudCurrentMileage.Value = 0;
            ClearVehicleFields();
            selectedVehicle = null;
            isEditMode = false;
            btnSave.Text = "Add Vehicle";
            lblStatus.Text = "";
        }

        private void btnVehicleEdit_Click(object sender, EventArgs e)
        {
            if (lvVehicleList.SelectedItems.Count == 0) return;

            Vehicle vehicle = (Vehicle)lvVehicleList.SelectedItems[0].Tag;

            frmVehicle editForm = new frmVehicle(customerID);
            editForm.LoadVehicleForEditing(vehicle);

            if (editForm.ShowDialog() == DialogResult.OK)
                LoadVehicles();
        }

        private void btnVehicleDelete_Click(object sender, EventArgs e)
        {
            if (selectedVehicle == null) return;

            DialogResult result = MessageBox.Show(
                $"Delete {selectedVehicle.Year} {selectedVehicle.Make} {selectedVehicle.Model}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DBHelper.DeleteVehicle(selectedVehicle.VehicleID);
                    selectedVehicle = null;
                    ClearForm();
                    LoadVehicles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting vehicle: {ex.Message}", "Error");
                }
            }
        }

        private void lvVehicleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVehicleList.SelectedItems.Count > 0)
            {
                selectedVehicle = (Vehicle)lvVehicleList.SelectedItems[0].Tag;
                LoadVehicleForEditing(selectedVehicle);
                btnVehicleDelete.Enabled = true;
            }
            else
            {
                selectedVehicle = null;
                btnVehicleDelete.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
