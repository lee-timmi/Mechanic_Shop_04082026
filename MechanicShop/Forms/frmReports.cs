using MechanicShop.Helper;
using System;
using System.Linq;
using System.Windows.Forms;
using MechanicShop.Services;

namespace MechanicShop.Forms
{
    public partial class frmReports : Form
    {
        private DBHelper dbHelper;
        private MechanicService mechanicService;

        public frmReports()
        {
            InitializeComponent();
            dbHelper = new DBHelper();
            mechanicService = new MechanicService();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            cboReportType.Items.Clear();
            cboReportType.Items.Add("All Customers");
            cboReportType.Items.Add("All Mechanics");
            cboReportType.Items.Add("All Repair Orders");
            cboReportType.Items.Add("Open Repair Orders");
            cboReportType.Items.Add("Closed Repair Orders");

            if (cboReportType.Items.Count > 0)
            {
                cboReportType.SelectedIndex = 0;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string selectedReport = cboReportType.SelectedItem?.ToString();
            string filter = txtFilter.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(selectedReport))
            {
                MessageBox.Show("Please select a report type.");
                return;
            }

            switch (selectedReport)
            {
                case "All Customers":
                    LoadCustomersReport(filter);
                    break;

                case "All Mechanics":
                    LoadMechanicsReport(filter);
                    break;

                case "All Repair Orders":
                    LoadRepairOrdersReport(filter, null);
                    break;

                case "Open Repair Orders":
                    LoadRepairOrdersReport(filter, "Open");
                    break;

                case "Closed Repair Orders":
                    LoadRepairOrdersReport(filter, "Closed");
                    break;
            }
        }

        private void LoadCustomersReport(string filter)
        {
            var customers = dbHelper.GetAllCustomers();

            if (!string.IsNullOrEmpty(filter))
            {
                customers = customers.Where(c =>
                    c.FirstName.ToLower().Contains(filter) ||
                    c.LastName.ToLower().Contains(filter) ||
                    (!string.IsNullOrEmpty(c.Email) && c.Email.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(c.PhoneNumber) && c.PhoneNumber.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(c.Address) && c.Address.ToLower().Contains(filter))
                ).ToList();
            }

            dgvReport.DataSource = customers.Select(c => new
            {
                c.CustomerID,
                c.FirstName,
                c.LastName,
                Phone = c.PhoneNumber,
                c.Email,
                c.Address
            }).ToList();
        }

        private void LoadMechanicsReport(string filter)
        {
            var mechanics = mechanicService.GetAllMechanics();

            if (!string.IsNullOrEmpty(filter))
            {
                mechanics = mechanics.Where(m =>
                    m.FirstName.ToLower().Contains(filter) ||
                    m.LastName.ToLower().Contains(filter)
                ).ToList();
            }

            dgvReport.DataSource = mechanics.Select(m => new
            {
                MechanicID = m.MechanicID,
                m.FirstName,
                m.LastName,
                m.HourlyRate
            }).ToList();
        }

        private void LoadRepairOrdersReport(string filter, string statusFilter)
        {
            var repairOrders = dbHelper.GetAllRepairOrders();

            if (!string.IsNullOrEmpty(statusFilter))
            {
                repairOrders = repairOrders.Where(r =>
                    !string.IsNullOrEmpty(r.RepairStatus) &&
                    r.RepairStatus.Equals(statusFilter, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }

            if (!string.IsNullOrEmpty(filter))
            {
                repairOrders = repairOrders.Where(r =>
                    (!string.IsNullOrEmpty(r.CustomerName) && r.CustomerName.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(r.VehicleDisplay) && r.VehicleDisplay.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(r.RepairStatus) && r.RepairStatus.ToLower().Contains(filter)) ||
                    (!string.IsNullOrEmpty(r.CustomerComplaint) && r.CustomerComplaint.ToLower().Contains(filter))
                ).ToList();
            }

            dgvReport.DataSource = repairOrders.Select(r => new
            {
                r.RepairOrderID,
                r.CustomerName,
                r.VehicleDisplay,
                r.DateOpened,
                r.DateClosed,
                r.MileageAtService,
                r.RepairStatus,
                r.CustomerComplaint
            }).ToList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFilter.Clear();
            dgvReport.DataSource = null;

            if (cboReportType.Items.Count > 0)
            {
                cboReportType.SelectedIndex = 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblReportType_Click(object sender, EventArgs e)
        {
        }

        private void lblFilter_Click(object sender, EventArgs e)
        {
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}