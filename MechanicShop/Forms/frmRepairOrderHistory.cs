using MechanicShop.Classes;
using MechanicShop.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MechanicShop.Forms
{
    public partial class frmRepairOrderHistory : Form
    {
        private DBHelper DBHelper;
        private List<RepairOrder> allRepairOrders;
        private RepairOrder selectedRepairOrder;

        public frmRepairOrderHistory()
        {
            InitializeComponent();
            DBHelper = new DBHelper();
            SetupDataView();
            SetupFilters();
            LoadRepairOrders();
        }

        private void SetupDataView()
        {
            dgvRepairReceipt.Columns.Clear();
            dgvRepairReceipt.Columns.Add("RepairOrderID", "ID");
            dgvRepairReceipt.Columns.Add("DateOpened", "ID");
            dgvRepairReceipt.Columns.Add("CustomerName", "Customer");
            dgvRepairReceipt.Columns.Add("VehicleDisplay", "Vehicle");
            dgvRepairReceipt.Columns.Add("RepairStatus", "Status");
            dgvRepairReceipt.Columns.Add("GrandTotal", "Total");

            dgvRepairReceipt.Columns["RepairOrderID"].Width = 50;
            dgvRepairReceipt.Columns["DateOpened"].Width = 100;
            dgvRepairReceipt.Columns["CustomerName"].Width = 150;
            dgvRepairReceipt.Columns["VehicleDisplay"].Width = 200;
            dgvRepairReceipt.Columns["RepairStatus"].Width = 100;
            dgvRepairReceipt.Columns["GrandTotal"].Width = 80;

            dgvRepairReceipt.Columns["GrandTotal"].DefaultCellStyle.Format = "C2";

            dgvRepairReceipt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRepairReceipt.MultiSelect = false;
            dgvRepairReceipt.ReadOnly = true;
            dgvRepairReceipt.AllowUserToAddRows = false;
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
        private void LoadRepairOrders()
        {
            allRepairOrders = DBHelper.GetAllRepairOrders();
            ApplyFilters();
        }
        private void ApplyFilters()
        {
            var filtered = allRepairOrders.AsEnumerable();

            // Search filter
            string searchTerm = txtFilter.Text.Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                filtered = filtered.Where(r =>
                    r.RepairOrderId.ToString().Contains(searchTerm) ||
                    r.CustomerName.ToLower().Contains(searchTerm) ||
                    r.VehicleDisplay.ToLower().Contains(searchTerm) ||
                    r.RepairStatus.ToLower().Contains(searchTerm)
                );
            }

            // Status filter
            if (cboStatusFilter.SelectedItem != null && cboStatusFilter.SelectedItem.ToString() != "All")
            {
                string status = cboStatusFilter.SelectedItem.ToString();
                filtered = filtered.Where(r => r.RepairStatus == status);
            }

            // Date range filter
            filtered = filtered.Where(r => r.DateOpened.Date >= dtpFromDate.Value.Date &&
                                            r.DateOpened.Date <= dtpToDate.Value.Date);

            // Sort by date (newest first)
            var results = filtered.OrderByDescending(r => r.DateOpened).ToList();

            RefreshDataGridView(results);
            lblTotalRecords.Text = $"Total Records: {results.Count}";
        }

        private void RefreshDataGridView(List<RepairOrder> repairOrders)
        {
            dgvRepairReceipt.Rows.Clear();

            foreach (var repair in repairOrders)
            {
                dgvRepairReceipt.Rows.Add(
                    repair.RepairOrderId,
                    repair.DateOpened.ToShortDateString(),
                    repair.CustomerName,
                    repair.VehicleDisplay,
                    repair.RepairStatus,
                    repair.TotalCost
                );
            }
        }

        // Event Handlers
        private void dgvRepairReceipt_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRepairReceipt.SelectedRows.Count > 0)
            {
                int rowIndex = dgvRepairReceipt.SelectedRows[0].Index;
                int repairOrderId = Convert.ToInt32(dgvRepairReceipt.Rows[rowIndex].Cells["RepairOrderID"].Value);
                selectedRepairOrder = allRepairOrders.FirstOrDefault(r => r.RepairOrderId == repairOrderId);

                btnViewDetails.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                selectedRepairOrder = null;
                btnViewDetails.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void dgvRepairReceipt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = dgvRepairReceipt.Rows[e.RowIndex].Cells["RepairStatus"].Value?.ToString();

            switch (status)
            {
                case "Pending":
                    dgvRepairReceipt.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    dgvRepairReceipt.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                    break;
                case "In Progress":
                    dgvRepairReceipt.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                    dgvRepairReceipt.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkBlue;
                    break;
                case "Completed":
                    dgvRepairReceipt.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dgvRepairReceipt.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                    break;
            }
        }

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

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (selectedRepairOrder != null)
            {
                var viewForm = new frmRepairOrder(
                    repairOrderId: selectedRepairOrder.RepairOrderId,
                    mode: RepairOrderFormMode.View);
                viewForm.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedRepairOrder != null)
            {
                var editForm = new frmRepairOrder(
                    repairOrderId: selectedRepairOrder.RepairOrderId,
                    mode: RepairOrderFormMode.Edit);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadRepairOrders();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRepairOrder == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Delete repair order #{selectedRepairOrder.RepairOrderId} for " +
                $"{selectedRepairOrder.CustomerName}?\n\nThis will also delete all labor and " +
                $"parts items associated with this repair order.", "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DBHelper.DeleteRepairOrders(selectedRepairOrder.RepairOrderId);
                    MessageBox.Show("Repair Order deleted successfully.", "Success");
                    LoadRepairOrders();
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show($"Error deleting repair order: {ex.Message}", "Error");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}