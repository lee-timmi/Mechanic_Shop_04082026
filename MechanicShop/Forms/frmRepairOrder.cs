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
using MechanicShop.Services;
using Microsoft.VisualBasic;

namespace MechanicShop.Forms
{
    public enum RepairOrderFormMode { View, Edit, New }
    public partial class frmRepairOrder : Form
    {
        // Private fields
        private RepairOrder RepairOrder;
        private List<LaborLineItem> LaborLineItems;
        private List<PartsLineItem> PartsLineItems;
        private int nextLaborLineItemId = 1;
        private int nextPartsLineItemId = 1;
        private int editingRepairOrderItemId = 0;
        private RepairOrderFormMode formMode = RepairOrderFormMode.New;
        private LaborServices laborServices;
        private PartsServices partsServices;
        private RepairOrderService repairOrderService;
        private bool _isReadOnly = false;

        // Repository Calls
        private readonly CustomerRepository customerRepository;
        private readonly VehicleRepository vehicleRepository;
        private readonly RepairOrderRepository repairOrderRepository;
        private readonly LaborPartRepository laborPartRepository;


        // Constructor
        public frmRepairOrder(int? repairOrderId = null, int? vehicleId = null,
                                int? customerId = null, RepairOrderFormMode mode = RepairOrderFormMode.New)
        {
            InitializeComponent();

            // Repos and services
            var audit = new AuditService(new AuditRepository());
            customerRepository = new CustomerRepository();
            vehicleRepository = new VehicleRepository();
            repairOrderRepository = new RepairOrderRepository();
            laborPartRepository = new LaborPartRepository();
            repairOrderService = new RepairOrderService(new RepairOrderRepository(), audit);
            laborServices = new LaborServices(new MechanicService(audit));
            partsServices = new PartsServices();

            // Date
            RepairOrder = new RepairOrder();
            LaborLineItems = new List<LaborLineItem>();
            PartsLineItems = new List<PartsLineItem>();
            formMode = mode;
            
            if (repairOrderId.HasValue)
            {
                LoadRepairOrderForEditing(repairOrderId.Value);
                LoadCustomers(); 
                SetupForm();

                switch (mode)
                {
                    case RepairOrderFormMode.View:
                        SetReadOnly();
                        this.Text = "View Repair Order";
                        break;
                    case RepairOrderFormMode.Edit:
                        editingRepairOrderItemId = repairOrderId.Value;
                        this.Text = "Edit Repair Order";
                        break;
                }
            }
            else if (vehicleId.HasValue)
            {
                LoadVehicleAndCustomer(vehicleId.Value);
                SetupForm();
            }
            else if (customerId.HasValue)
            {
                LoadCustomerForRepair(customerId.Value);
                SetupForm();
            }
            else
            {
                LoadCustomers();
                SetupForm();
               
            }
            
        }

        // Methods
        private void SetReadOnly()
        {
            cboCustomer.Enabled = false;
            cboVehicle.Enabled = false;
            dtpDate.Enabled = false;
            nudMileage.Enabled = false;
            cboStatus.Enabled = false;
            txtFeedback.ReadOnly = true;

            // Hidden Buttons
            btnSubmitOrder.Visible = false;
            btnAddLabor.Visible = false;
            btnAddParts.Visible = false;

            // Hidden Quick Buttons
            btnOilChange.Visible = false;
            btnBrakePad.Visible = false;
            btnTireRotation.Visible = false;
            btnDiagnostic.Visible = false;
            btnAirFilter.Visible = false;
            btnOilFilter.Visible = false;
        }
        private void SetupForm()
        {
            // Set up form controls (e.g., combo boxes, data grids)
            // This is where you would populate dropdowns, set default values, etc.
            dtpDate.Value = DateTime.Now;
            cboStatus.Items.AddRange(new string[] { "Pending", "In Progress", "Completed", "Invoiced" });
            cboStatus.SelectedIndex = 0; // Default to "Pending"

            if (formMode == RepairOrderFormMode.New) // only generate new # when a new order is created
            {
                txtOrderNum.Text = repairOrderService.GenerateOrderNumber();
            }
            else
            {
                txtOrderNum.Text = RepairOrder.OrderNumber;
            }

            txtOrderNum.ReadOnly = true;
            txtOrderNum.BackColor = System.Drawing.SystemColors.Control;
        }
        private void LoadCustomers()
        {
            // Load customers from the database and populate a combo box
            var customers = customerRepository.GetAll();
            cboCustomer.DataSource = customers;
            cboCustomer.DisplayMember = "FullName";
            cboCustomer.ValueMember = "CustomerId";
        }
        private void LoadRepairOrderForEditing(int repairOrderId)
        {
            // Load the RepairOrder, LaborLineItems, and PartsLineItems from the database
            // and populate the form controls with the existing data
            var repairs = repairOrderRepository.GetAll();
            RepairOrder = repairs.FirstOrDefault(r => r.RepairOrderId == repairOrderId);
            
            if (RepairOrder != null)
            {
                editingRepairOrderItemId = repairOrderId;
                dtpDate.Value = RepairOrder.DateOpened;
                nudMileage.Value = RepairOrder.MileageAtService;
                cboStatus.Text = RepairOrder.RepairStatus;
                txtFeedback.Text = RepairOrder.CustomerComplaint;


                // Load LaborLineItems and PartsLineItems for this RepairOrder
                LaborLineItems = laborPartRepository.GetLaborByRepairOrder(repairOrderId);
                PartsLineItems = laborPartRepository.GetPartsByRepairOrder(repairOrderId);

                RefreshLaborGrid();
                RefreshPartsGrid();
                CalculateTotals();

            }
        }

        private void LoadVehicleAndCustomer(int vehicleId)
        {
            // Get Vehicle
            Vehicle vehicle = vehicleRepository.GetById(vehicleId);

            if (vehicle != null)
            {
                Customer customer = customerRepository.GetByID(vehicle.CustomerID);

                if (customer != null)
                {
                    // Store ID
                    RepairOrder.CustomerId = customer.CustomerID;
                    RepairOrder.VehicleId = vehicleId;

                    // Find and select within dropdown
                    var customers = customerRepository.GetAll();
                    cboCustomer.DataSource = customers;
                    cboCustomer.DisplayMember = "FullName";
                    cboCustomer.ValueMember = "CustomerID";
                    cboCustomer.SelectedValue = customer.CustomerID;

                    // Load vehicle for this customer
                    var vehicles = vehicleRepository.GetByCustomer(customer.CustomerID);
                    cboVehicle.DataSource = vehicles;
                    cboVehicle.DisplayMember = "DisplayName";
                    cboVehicle.ValueMember = "vehicleId";
                    cboVehicle.SelectedValue = vehicleId;
                    cboVehicle.Enabled = true;

                    nudMileage.Value = (decimal)vehicle.CurrentMileage;
                    nudMileage.ReadOnly = true;
                    nudMileage.Enabled = false;

                    cboCustomer.Enabled = false;
                    cboVehicle.Enabled = false;

                }
            }
            else
            {
                MessageBox.Show("No Vehicle Found.");
            }
        }

        private void LoadCustomerForRepair(int customerId)
        {
            Customer customer = customerRepository.GetByID(customerId);

            if (customer != null)
            {
                RepairOrder.CustomerId = customer.CustomerID;

                var customers = customerRepository.GetAll();
                cboCustomer.DataSource = customers;
                cboCustomer.DisplayMember = "FullName";
                cboCustomer.ValueMember = "CustomerID";

                cboCustomer.SelectedValue = customer.CustomerID;

                cboCustomer.Enabled = false;

                LoadVehiclesForCustomer(customer.CustomerID);
            }
        }

        private void LoadVehiclesForCustomer(int customerId)
        {
            var vehicles = vehicleRepository.GetByCustomer(customerId);
            cboVehicle.DataSource = vehicles;
            cboVehicle.DisplayMember = "DisplayName";
            cboVehicle.ValueMember = "VehicleID";
            cboVehicle.Enabled = vehicles.Any();

            // If there are vehicles, select first one and load its mileage
            if (vehicles.Count > 0)
            {
                cboVehicle.SelectedIndex = 0;
            }
        }

        // Event Handlers
        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedValue != null)
            {
                Customer selected = (Customer)cboCustomer.SelectedItem;
                var vehicles = vehicleRepository.GetByCustomer(selected.CustomerID);
                cboVehicle.DataSource = vehicles;
                cboVehicle.DisplayMember = "DisplayName";
                cboVehicle.ValueMember = "VehicleID";
                cboVehicle.Enabled = vehicles.Any();

                // In case user forgets to add vehicle
                if (!vehicles.Any())
                {
                    DialogResult result = MessageBox.Show(
                        $"{selected.FullName} has no vehicle(s) registered. \n\nWould you like to add one now?", 
                        "No Vehicle Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                
                    if ( result == DialogResult.Yes )
                    {
                        frmVehicle vehicleForm = new frmVehicle(selected.CustomerID);
                        vehicleForm.ShowDialog();

                        var updatedVehicles = vehicleRepository.GetByCustomer(selected.CustomerID);
                        cboVehicle.DataSource = updatedVehicles;
                        cboVehicle.Enabled = updatedVehicles.Any();
                    }
                }
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

            AddLaborItem(description, hours, rate);
        }

        private void btnAddParts_Click(object sender, EventArgs e)
        {
            string partName = Interaction.InputBox("Enter part name:", "Add Part");
            if (string.IsNullOrWhiteSpace(partName)) return;

            string qtyStr = Interaction.InputBox("Enter quantity:", "Quantity", "1");
            if (!int.TryParse(qtyStr, out int quantity)) return;

            string costStr = Interaction.InputBox("Enter unit cost:", "Unit Cost", "12.99");
            if (!decimal.TryParse(costStr, out decimal cost)) return;

            AddPartItem(partName, quantity, cost);
        }

        // Helper methods to refresh grids and calculate totals
        private Image GetLaborIcon(string description)
        {
            string desc = description?.ToLower() ?? "";

            if (desc.Contains("oil change")) return Properties.Resources.carOil;
            if (desc.Contains("brake pad")) return Properties.Resources.brakePad;
            if (desc.Contains("tire rotation")) return Properties.Resources.tireRotation;
            if (desc.Contains("diagnostic")) return Properties.Resources.diagnostic;

            return Properties.Resources.generalLabor;
        }
        private Image GetPartsIcon(string description)
        {
            string desc = description?.ToLower() ?? "";

            if (desc.Contains("oil filter")) return Properties.Resources.oilFilter;
            if (desc.Contains("air filter")) return Properties.Resources.airFilter;

            return Properties.Resources.generalParts;
        }

        private Panel CreateHeaderRow(bool isLabor)
        {
            Panel header = new Panel
            {
                Width = isLabor ? flpLabor.Width - 5 : flpParts.Width - 5,
                Height = 30,
                BackColor = Color.SteelBlue
            };

            if (isLabor)
            {
                header.Controls.Add(new Label { Text = "Service", Location = new Point(38, 6), Width = 120, ForeColor = Color.White, Font = new Font("Arial", 8, FontStyle.Bold) });
                header.Controls.Add(new Label { Text = "Hours", Location = new Point(163, 6), Width = 40, ForeColor = Color.White, Font = new Font("Arial", 8, FontStyle.Bold) });
                header.Controls.Add(new Label { Text = "Rate", Location = new Point(208, 6), Width = 765, ForeColor = Color.White, Font = new Font("Arial", 8, FontStyle.Bold) });
                header.Controls.Add(new Label { Text = "Mechanic", Location = new Point(278, 6), Width = 90, ForeColor = Color.White, Font = new Font("Arial", 8, FontStyle.Bold) });
                header.Controls.Add(new Label { Text = "Cost", Location = new Point(373, 6), Width = 65, ForeColor = Color.White, Font = new Font("Arial", 8, FontStyle.Bold) });
            }
            else
            {
                header.Controls.Add(new Label { Text = "Part Name", Location = new Point(40, 6), Width = 170, ForeColor = Color.White, Font = new Font("Arial", 8, FontStyle.Bold) });
                header.Controls.Add(new Label { Text = "Qty", Location = new Point(215, 6), Width = 40, ForeColor = Color.White, Font = new Font("Arial", 8, FontStyle.Bold) });
                header.Controls.Add(new Label { Text = "Unit Cost", Location = new Point(260, 6), Width = 80, ForeColor = Color.White, Font = new Font("Arial", 8, FontStyle.Bold) });
                header.Controls.Add(new Label { Text = "Total", Location = new Point(345, 6), Width = 80, ForeColor = Color.White, Font = new Font("Arial", 8, FontStyle.Bold) });
            }

            return header;
        }

        public void RefreshLaborGrid()
        {
            flpLabor.Controls.Clear();
            flpLabor.Controls.Add(CreateHeaderRow(true));

            foreach (var labor in LaborLineItems)
            {
                Panel row = new Panel
                {
                    Width = flpLabor.Width - 5,
                    Height = 40,
                    BackColor = LaborLineItems.IndexOf(labor) % 2 == 0
                                ? Color.White : Color.AliceBlue
                };

                PictureBox icon = new PictureBox
                {
                    Image = GetLaborIcon(labor.LaborDescription),
                    Size = new Size(28, 28),
                    Location = new Point(5, 6),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                Label lblDesc = new Label
                {
                    Text = labor.LaborDescription,
                    Location = new Point(38, 12),
                    Width = 120,
                    AutoSize = false
                };

                Label lblHours = new Label
                {
                    Text = $"{labor.LaborHours}h",
                    Location = new Point(163, 12),
                    Width = 40,
                    AutoSize = false
                };

                Label lblRate = new Label
                {
                    Text = labor.LaborHourlyRate.ToString("C"),
                    Location = new Point(208, 12),
                    Width = 65,
                    AutoSize = false
                };

                Label lblMechanic = new Label
                {
                    Text = laborServices.GetMechanicName(labor.MechanicID),
                    Location = new Point(278, 12),
                    Width = 90,
                    AutoSize = false
                };

                Label lblCost = new Label
                {
                    Text = labor.LaborCost.ToString("C"),
                    Location = new Point(373, 12),
                    Width = 65,
                    AutoSize = false,
                    ForeColor = Color.DarkGreen
                };

                row.Controls.Add(icon);
                row.Controls.Add(lblDesc);
                row.Controls.Add(lblHours);
                row.Controls.Add(lblRate);
                row.Controls.Add(lblMechanic);
                row.Controls.Add(lblCost);

                if (!_isReadOnly)
                {
                    Button btnRemove = new Button
                    {
                        Text = "X",
                        Location = new Point(443, 8),
                        Width = 25,
                        Height = 24,
                        Tag = labor,
                        ForeColor = Color.Red,
                        FlatStyle = FlatStyle.Flat,
                        AutoSize = false
                    };
                    btnRemove.Click += (s, e) =>
                    {
                        LaborLineItems.Remove((LaborLineItem)((Button)s).Tag);
                        RefreshLaborGrid();
                        CalculateTotals();
                    };
                    row.Controls.Add(btnRemove);
                }

                flpLabor.Controls.Add(row);
            }
        }

        public void RefreshPartsGrid()
        {
            flpParts.Controls.Clear();
            flpParts.Controls.Add(CreateHeaderRow(false));

            foreach (var part in PartsLineItems)
            {
                Panel row = new Panel
                {
                    Width = flpParts.Width - 5,
                    Height = 40,
                    BackColor = PartsLineItems.IndexOf(part) % 2 == 0
                                ? Color.White : Color.AliceBlue
                };

                PictureBox icon = new PictureBox
                {
                    Image = GetPartsIcon(part.PartName),
                    Size = new Size(28, 28),
                    Location = new Point(5, 6),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                Label lblName = new Label
                {
                    Text = part.PartName,
                    Location = new Point(40, 12),
                    Width = 178,
                    AutoSize = false
                };

                Label lblQty = new Label
                {
                    Text = part.Quantity.ToString(),
                    Location = new Point(223, 12),
                    Width = 38,
                    AutoSize = false
                };

                Label lblUnitCost = new Label
                {
                    Text = part.UnitCost.ToString("C"),
                    Location = new Point(266, 12),
                    Width = 78,
                    AutoSize = false
                };

                Label lblTotal = new Label
                {
                    Text = part.TotalCost.ToString("C"),
                    Location = new Point(349, 12),
                    Width = 78,
                    AutoSize = false,
                    ForeColor = Color.DarkGreen
                };

                row.Controls.Add(icon);
                row.Controls.Add(lblName);
                row.Controls.Add(lblQty);
                row.Controls.Add(lblUnitCost);
                row.Controls.Add(lblTotal);

                if (!_isReadOnly)
                {
                    Button btnRemove = new Button
                    {
                        Text = "X",
                        Location = new Point(432, 8),
                        Width = 25,
                        Height = 24,
                        Tag = part,
                        ForeColor = Color.Red,
                        FlatStyle = FlatStyle.Flat,
                        AutoSize = false
                    };
                    btnRemove.Click += (s, e) =>
                    {
                        PartsLineItems.Remove((PartsLineItem)((Button)s).Tag);
                        RefreshPartsGrid();
                        CalculateTotals();
                    };
                    row.Controls.Add(btnRemove);
                }

                flpParts.Controls.Add(row);
            }
        }

        public void CalculateTotals()
        {
            decimal laborTotal = LaborLineItems.Sum(l => l.LaborCost);
            decimal partsTotal = PartsLineItems.Sum(p => p.TotalCost);

            txtLaborTotal.Text = $"${CostCalculator.LaborTotal(LaborLineItems):F2}";
            txtPartsTotal.Text = $"${CostCalculator.PartsTotal(PartsLineItems):F2}";
            txtGrandTotal.Text = $"${laborTotal + partsTotal:F2}";
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
            RepairOrder.OrderNumber = txtOrderNum.Text;

            if (editingRepairOrderItemId == 0)
            {
                repairOrderService.Save(RepairOrder, LaborLineItems, PartsLineItems);
                MessageBox.Show("Repair order saved successfully!", "Success");
            }
            else
            {
                RepairOrder.RepairOrderId = editingRepairOrderItemId;
                repairOrderService.Update(RepairOrder, LaborLineItems, PartsLineItems);
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

        private void cboVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVehicle.SelectedItem != null)
            {
                Vehicle selected = (Vehicle)cboVehicle.SelectedItem;
                nudMileage.Value = selected.CurrentMileage;
            }
        }

        // === Labor Item Event Handlers ====
        private void btnOilChange_Click(object sender, EventArgs e) => AddLaborItem("Oil Change", 1.0m, 80.00m);
        private void btnBrakePad_Click(object sender, EventArgs e) => AddLaborItem("Brake Pad Replacement", 2.0m, 95.00m);
        private void btnTireRotation_Click(object sender, EventArgs e) => AddLaborItem("Tire Rotation", 0.5m, 80.00m);
        private void btnDiagnostic_Click(object sender, EventArgs e) => AddLaborItem("Diagnostics", 1.5m, 120.00m);

        // ==== Parts Item Event Handler ====
        private void btnAirFilter_Click(object sender, EventArgs e) => AddPartItem("Air Filter", 1, 18.50m);
        private void btnOilFilter_Click(object sender, EventArgs e) => AddPartItem("Oil Filter", 1, 12.99m);
        private void AddLaborItem(string description, decimal hours, decimal rate)
        {
            var item = new LaborLineItem
            {
                LaborLineItemId = nextLaborLineItemId++,
                LaborDescription = description,
                LaborHours = hours,
                LaborHourlyRate = rate,
                MechanicID = laborServices.PromptForMechanic()
            };
            LaborLineItems.Add(item);
            RefreshLaborGrid();
            CalculateTotals();
        }

        private void AddPartItem(string name, int qty, decimal cost)
        {
            var item = new PartsLineItem
            {
                PartsLineItemId = nextPartsLineItemId++,
                PartName = name,
                Quantity = qty,
                UnitCost = cost
            };
            PartsLineItems.Add(item);
            RefreshPartsGrid();
            CalculateTotals();
        }

        private void btnCloseOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
