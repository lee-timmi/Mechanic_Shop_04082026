using MechanicShop.Classes;
using MechanicShop.Helper;
using System;
using System.Collections.Generic;
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
            string selectedEntity = "";

            if (cboEntity.SelectedItem != null)
            {
                selectedEntity = cboEntity.SelectedItem.ToString();
            }

            string userFilter = txtUser.Text.Trim().ToLower();

            List<AuditLog> logs = dbHelper.GetAllAuditLogs();
            List<AuditLog> filteredLogs = new List<AuditLog>();

            foreach (AuditLog log in logs)
            {
                bool addLog = true;

                if (!string.IsNullOrEmpty(selectedEntity) && selectedEntity != "All")
                {
                    if (log.EntityType != selectedEntity)
                    {
                        addLog = false;
                    }
                }

                if (!string.IsNullOrEmpty(userFilter))
                {
                    if (string.IsNullOrEmpty(log.PerformedBy) ||
                        !log.PerformedBy.ToLower().Contains(userFilter))
                    {
                        addLog = false;
                    }
                }

                if (addLog)
                {
                    filteredLogs.Add(log);
                }
            }

            for (int i = 0; i < filteredLogs.Count - 1; i++)
            {
                for (int j = i + 1; j < filteredLogs.Count; j++)
                {
                    if (filteredLogs[j].Timestamp > filteredLogs[i].Timestamp)
                    {
                        AuditLog temp = filteredLogs[i];
                        filteredLogs[i] = filteredLogs[j];
                        filteredLogs[j] = temp;
                    }
                }
            }

            dgvAuditLog.DataSource = filteredLogs;
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