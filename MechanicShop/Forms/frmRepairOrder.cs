using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechanicShop.Classes;
using MechanicShop.Helper;
using Microsoft.VisualBasic;

namespace MechanicShop.Forms
{
    public partial class frmRepairOrder : Form
    {
        // Private fields
        private DBHelper DBHelper;
        private RepairOrder RepairOrder;
        private List<LaborLineItem> LaborLineItems;
        private List<PartsLineItem> PartsLineItems;
        private int nextLaborLineItemId = 1;
        private int nextPartsLineItemId = 1;
        private int editingRepairOrderItemId = 0; // 0 = new, >0 = editing existing item

        // Constructor
        public frmRepairOrder()
        {
            InitializeComponent();
            DBHelper = new DBHelper();
            RepairOrder = new RepairOrder();
            LaborLineItems = new List<LaborLineItem>();
            PartsLineItems = new List<PartsLineItem>();
            LoadCustomers(); // future methods
            SetupForm(); // future methods
        }

        // Constructor for editing existing RepairOrder
        public frmRepairOrder(int repairOrderId)
        {
            InitializeComponent();
            DBHelper = new DBHelper();
            RepairOrder = new RepairOrder();
            LaborLineItems = new List<LaborLineItem>();
            PartsLineItems = new List<PartsLineItem>();
            LoadRepairOrderForEditing(repairOrderId);
            LoadCustomers(); // future methods
            SetupForm(); // future methods
            this.Text = "Edit Repair Order";

        }

        // Methods
        private void SetupForm()
        {
            // Set up form controls (e.g., combo boxes, data grids)
            // This is where you would populate dropdowns, set default values, etc.
            dtpDate.Value = DateTime.Now;
            cboStatus.Items.AddRange(new string[] { "Pending", "In Progress", "Completed", "Invoiced" });
            cboStatus.SelectedIndex = 0; // Default to "Pending"
        }
        private void LoadCustomers()
        {
            // Load customers from the database and populate a combo box
            var customers = DBHelper.GetAllCustomers();
            cboCustomer.DataSource = customers;
            cboCustomer.DisplayMember = "Name";
            cboCustomer.ValueMember = "CustomerId";
        }
        private void LoadRepairOrderForEditing(int repairOrderId)
        {
            // Load the RepairOrder, LaborLineItems, and PartsLineItems from the database
            // and populate the form controls with the existing data
            var repairs = DBHelper.GetAllRepairOrders();
            RepairOrder = repairs.FirstOrDefault(r => r.RepairOrderId == repairOrderId);
            
            if (RepairOrder != null)
            {
                dtpDate.Value = RepairOrder.DateOpened;
                nudMileage.Value = RepairOrder.MileageAtService;
                cboStatus.Text = RepairOrder.RepairStatus;
                txtFeedback.Text = RepairOrder.CustomerComplaint;


                // Load LaborLineItems and PartsLineItems for this RepairOrder
                LaborLineItems = DBHelper.GetLaborItemsByRepairOrder(repairOrderId);
                PartsLineItems = DBHelper.GetPartsItemsByRepairOrder(repairOrderId);

                RefreshLaborGrid();
                RefreshPartsGrid();
                CalculateTotals();

            }
        }

        // Event Handlers
        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedValue != null)
            {
                Customer selected = (Customer)cboCustomer.SelectedItem;
                var vehicles = DBHelper.GetVehiclesByCustomerId(selected.CustomerID);
                cboVehicle.DataSource = vehicles;
                cboVehicle.DisplayMember = "DisplayName";
                cboVehicle.ValueMember = "VehicleId";
                cboVehicle.Enabled = vehicles.Any();
            }
        }

        private void btnAddLabor_Click(object sender, EventArgs e)
        {
            string description = Interaction.InputBox("Enter labor description:", "Add Labor");
            if (string.IsNullOrWhiteSpace(description)) return;

            string hoursInput = Interaction.InputBox("Enter hours:", "Labor Hours", "1.0");
            if (!decimal.TryParse(hoursInput, out decimal hours)) return;

            string rateStr = Interaction.InputBox("Enter hourly rate:", "Hourly Rate", "80.00");
            if (!decimal.TryParse(rateStr, out decimal rate)) return;

            var laborItem = new LaborLineItem
            {
                LaborLineItemId = nextLaborLineItemId++,
                LaborDescription = description,
                LaborHours = hours,
                LaborHourlyRate = rate
            };
            LaborLineItems.Add(laborItem);
            RefreshLaborGrid();
            CalculateTotals();
        }

        private void btnAddParts_Click(object sender, EventArgs e)
        {
            string partName = Interaction.InputBox("Enter part name:", "Add Part");
            if (string.IsNullOrWhiteSpace(partName)) return;

            string qtyStr = Interaction.InputBox("Enter quantity:", "Quantity", "1");
            if (!int.TryParse(qtyStr, out int quantity)) return;

            string costStr = Interaction.InputBox("Enter unit cost:", "Unit Cost", "12.99");
            if (!decimal.TryParse(costStr, out decimal cost)) return;

            var partItem = new PartsLineItem
            {
                PartsLineItemId = nextPartsLineItemId++,
                PartName = partName,
                Quantity = quantity,
                UnitCost = cost
            };
            PartsLineItems.Add(partItem);
            RefreshPartsGrid();
            CalculateTotals();
        }

        // Helper methods to refresh grids and calculate totals
        public void RefreshLaborGrid()
        {
            dgvLaborItems.DataSource = null;
            dgvLaborItems.DataSource = LaborLineItems.Select(l => new
            {
                l.LaborLineItemId,
                l.LaborDescription,
                l.LaborHours,
                l.LaborHourlyRate,
                LaborCost = l.LaborCost.ToString("C")
            }).ToList();
        }

        public void RefreshPartsGrid()
        {
            dgvPartsItem.DataSource = null;
            dgvPartsItem.DataSource = PartsLineItems.Select(p => new
            {
                p.PartsLineItemId,
                p.PartName,
                p.Quantity,
                UnitCost = p.UnitCost.ToString("C"),
                TotalCost = p.TotalCost.ToString("C")
            }).ToList();
        }

        public void CalculateTotals()
        {
            decimal laborTotal = LaborLineItems.Sum(l => l.LaborCost);
            decimal partsTotal = PartsLineItems.Sum(p => p.TotalCost);

            lblLaborTotal.Text = $"${laborTotal:F2}";
            lblPartsTotal.Text = $"${partsTotal:F2}";
            lblGrandTotal.Text = $"${laborTotal + partsTotal:F2}";
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer.", "Validation Error");
                return;
            }

            if (cboVehicle.SelectedItem == null)
            {
                MessageBox.Show("Please select a vehicle.", "Validation Error");
                return;
            }

            RepairOrder.CustomerId = (int)cboCustomer.SelectedValue;
            RepairOrder.VehicleId = (int)cboVehicle.SelectedValue;
            RepairOrder.DateOpened = dtpDate.Value;
            RepairOrder.MileageAtService = (int)nudMileage.Value;
            RepairOrder.RepairStatus = cboStatus.Text;
            RepairOrder.CustomerComplaint = txtFeedback.Text;

            if (editingRepairOrderItemId == 0)
            {
                DBHelper.SaveRepairOrder(RepairOrder, LaborLineItems, PartsLineItems);
                MessageBox.Show("Repair order saved successfully!", "Success");
            }
            else
            {
                DBHelper.UpdateRepairOrder(RepairOrder, LaborLineItems, PartsLineItems);
                MessageBox.Show("Repair order updated successfully!", "Success");
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
