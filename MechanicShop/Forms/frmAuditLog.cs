using MechanicShop.Helper;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MechanicShop.Forms
{
    public partial class frmAuditLog : Form
    {
        private DBHelper dbHelper;

        public frmAuditLog()
        {
            InitializeComponent();
            dbHelper = new DBHelper();
        }

        private void frmAuditLog_Load(object sender, EventArgs e)
        {
            cboEntity.Items.Clear();
            cboEntity.Items.Add("All");
            cboEntity.Items.Add("Customer");
            cboEntity.Items.Add("Vehicle");
            cboEntity.Items.Add("RepairOrder");
            cboEntity.Items.Add("Mechanic");

            cboEntity.SelectedIndex = 0;

            LoadAuditLogs();
        }

        private void LoadAuditLogs()
        {
            string selectedEntity = cboEntity.SelectedItem?.ToString();
            string userFilter = txtUser.Text.Trim().ToLower();

            var logs = dbHelper.GetAllAuditLogs();

            if (!string.IsNullOrEmpty(selectedEntity) && selectedEntity != "All")
            {
                logs = logs.Where(l => l.EntityType == selectedEntity).ToList();
            }

            if (!string.IsNullOrEmpty(userFilter))
            {
                logs = logs.Where(l =>
                    !string.IsNullOrEmpty(l.PerformedBy) &&
                    l.PerformedBy.ToLower().Contains(userFilter)).ToList();
            }

            dgvAuditLog.DataSource = logs
                .OrderByDescending(l => l.Timestamp)
                .Select(l => new
                {
                    l.ActionType,
                    l.EntityType,
                    l.EntityID,
                    l.Description,
                    l.Timestamp,
                    User = l.PerformedBy
                })
                .ToList();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAuditLogs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all audit log history?\nThis cannot be undone.",
                "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dbHelper.ClearAllAuditLogs();
                LoadAuditLogs();
                MessageBox.Show("Audit Log cleared", "Success");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}