using MechanicShop.Classes;
using MechanicShop.Helper;
using MechanicShop.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MechanicShop.Forms
{
    public partial class frmRepairOrderHistory : Form
    {
        private List<RepairOrder> allRepairOrders;
        private RepairOrderService repairOrderService;
        private List<RepairOrder> filteredRepairOrders;

        public frmRepairOrderHistory()
        {
            InitializeComponent();
            var audit = new AuditService(new AuditRepository());
            repairOrderService = new RepairOrderService(new RepairOrderRepository(), audit);
            SetupFilters();
            LoadRepairOrders();
        }
        private void SetupFilters()
        {
            cboStatusFilter.Items.Clear();
            cboStatusFilter.Items.Add("All");
            cboStatusFilter.Items.Add("Pending");
            cboStatusFilter.Items.Add("In Progress");
            cboStatusFilter.Items.Add("Completed");
            cboStatusFilter.Items.Add("Invoiced");
            cboStatusFilter.SelectedIndex = 0;

            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;
        }
        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Pending": return Color.Goldenrod;
                case "In Progress": return Color.SteelBlue;
                case "Completed": return Color.SeaGreen;
                case "Invoiced": return Color.SlateGray;
                default: return Color.Gray;
            }
        }
        private void LoadRepairOrders()
        {
            allRepairOrders = repairOrderService.GetAll();
            ApplyFilters();
        }
        private void ApplyFilters()
        {
            string searchTerm = txtFilter.Text.Trim();
            string status = "All";

            if (cboStatusFilter.SelectedItem != null)
            {
                status = cboStatusFilter.SelectedItem.ToString();
            }
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;

            var results = repairOrderService.Filter(searchTerm, status, fromDate, toDate);

            RefreshRepairOrderPanel(results);
            lblTotalRecords.Text = $"Total Records: {results.Count}";
        }

        private void RefreshRepairOrderPanel(List<RepairOrder> repairOrders)
        {
            flpRepairOrders.Controls.Clear();
            filteredRepairOrders = repairOrders;

            foreach (var repair in repairOrders)
            {
                // Outer card panel
                Panel card = new Panel
                {
                    Width = flpRepairOrders.Width - 10,
                    Height = 90,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(3)
                };

                // Order number label
                Label lblOrderNum = new Label
                {
                    Text = repair.OrderNumber ?? $"#{repair.RepairOrderId}",
                    Location = new Point(10, 8),
                    Width = 150,
                    Height = 20,
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    AutoSize = false
                };

                // Status badge
                Label lblStatus = new Label
                {
                    Text = repair.RepairStatus,
                    Location = new Point(card.Width - 110, 8),
                    Width = 100,
                    Height = 20,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = GetStatusColor(repair.RepairStatus),
                    ForeColor = Color.White,
                    Font = new Font("Arial", 8, FontStyle.Bold),
                    AutoSize = false
                };

                // Customer icon
                PictureBox personIcon = new PictureBox
                {
                    Image = Properties.Resources.person,
                    Size = new Size(16, 16),
                    Location = new Point(10, 33),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Customer name
                Label lblCustomer = new Label
                {
                    Text = repair.CustomerName,
                    Location = new Point(30, 32),
                    Width = 200,
                    Height = 18,
                    AutoSize = false
                };

                // Car icon
                PictureBox carIcon = new PictureBox
                {
                    Image = Properties.Resources.car,
                    Size = new Size(16, 16),
                    Location = new Point(10, 53),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Vehicle display
                Label lblVehicle = new Label
                {
                    Text = repair.VehicleDisplay,
                    Location = new Point(30, 52),
                    Width = 200,
                    Height = 18,
                    AutoSize = false
                };

                // Date opened
                Label lblDate = new Label
                {
                    Text = $"Opened: {repair.DateOpened.ToShortDateString()}",
                    Location = new Point(10, 68),
                    Width = 150,
                    Height = 16,
                    ForeColor = Color.Gray,
                    Font = new Font("Arial", 7, FontStyle.Regular),
                    AutoSize = false
                };

                // Total cost
                Label lblTotal = new Label
                {
                    Text = repair.TotalCost.ToString("C"),
                    Location = new Point(card.Width - 200, 68),
                    Width = 90,
                    Height = 16,
                    ForeColor = Color.DarkGreen,
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleRight,
                    AutoSize = false
                };

                // View button
                Button btnView = new Button
                {
                    Text = "View",
                    Location = new Point(card.Width - 210, 35),
                    Width = 60,
                    Height = 24,
                    Tag = repair,
                    FlatStyle = FlatStyle.Flat,
                    AutoSize = false
                };
                btnView.Click += btnView_Click;

                // Edit button
                Button btnEdit = new Button
                {
                    Text = "Edit",
                    Location = new Point(card.Width - 145, 35),
                    Width = 60,
                    Height = 24,
                    Tag = repair,
                    FlatStyle = FlatStyle.Flat,
                    AutoSize = false
                };
                btnEdit.Click += btnEdit_Click;

                // Delete button
                Button btnDelete = new Button
                {
                    Text = "Delete",
                    Location = new Point(card.Width - 80, 35),
                    Width = 60,
                    Height = 24,
                    Tag = repair,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.Red,
                    AutoSize = false
                };
                btnDelete.Click += btnDelete_Click;

                // Add all controls to card
                card.Controls.Add(lblOrderNum);
                card.Controls.Add(lblStatus);
                card.Controls.Add(personIcon);
                card.Controls.Add(lblCustomer);
                card.Controls.Add(carIcon);
                card.Controls.Add(lblVehicle);
                card.Controls.Add(lblDate);
                card.Controls.Add(lblTotal);
                card.Controls.Add(btnView);
                card.Controls.Add(btnEdit);
                card.Controls.Add(btnDelete);

                flpRepairOrders.Controls.Add(card);
            }

            lblTotalRecords.Text = $"Total Records: {repairOrders.Count}";
        }

        // Button event handlers for View, Edit, Delete
        private void btnView_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RepairOrder repair = (RepairOrder)button.Tag;

            frmRepairOrder viewForm = new frmRepairOrder(
                repairOrderId: repair.RepairOrderId,
                mode: RepairOrderFormMode.View);

            viewForm.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RepairOrder repair = (RepairOrder)button.Tag;

            frmRepairOrder editForm = new frmRepairOrder(
                repairOrderId: repair.RepairOrderId,
                mode: RepairOrderFormMode.Edit);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadRepairOrders();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RepairOrder selected = (RepairOrder)button.Tag;

            DialogResult result = MessageBox.Show(
                "Delete repair order #" + selected.RepairOrderId + " for " +
                selected.CustomerName + "?\n\nThis will also delete all labor and parts.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    repairOrderService.Delete(selected.RepairOrderId);
                    MessageBox.Show("Repair order deleted.", "Success");
                    LoadRepairOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        // Event Handlers
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtFilter.Clear();
            cboStatusFilter.SelectedIndex = 0;
            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;
            ApplyFilters();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}