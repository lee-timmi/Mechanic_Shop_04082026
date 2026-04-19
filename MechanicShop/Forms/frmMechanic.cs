using MechanicShop.Classes;
using MechanicShop.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MechanicShop.Services;

namespace MechanicShop.Forms
{
    public partial class frmMechanic : Form
    {
        private List<Mechanic> mechanicList;
        private Mechanic selectedMechanic;
        private bool isEditMode;
        private MechanicService mechServicesHelper;

        public frmMechanic()
        {
            InitializeComponent();
            mechServicesHelper = new MechanicService();
        }

        private void frmMechanic_Load(object sender, EventArgs e)
        {
            LoadMechanicData();
            ClearEntryForm();
        }

        private void LoadMechanicData()
        {
            mechanicList = mechServicesHelper.GetAllMechanics();
            RefreshMechanicList();
        }

        private void RefreshMechanicList()
        {
            lvMechanicList.Items.Clear();

            foreach (var mechanic in mechanicList
                .OrderBy(m => m.LastName)
                .ThenBy(m => m.FirstName))
            {
                ListViewItem item = new ListViewItem(mechanic.FirstName);
                item.SubItems.Add(mechanic.LastName);
                item.SubItems.Add(mechanic.HourlyRate.ToString("F2"));
                item.SubItems.Add(mechanic.Specialty ?? "");
                item.SubItems.Add(mechanic.Phone ?? "");
                item.Tag = mechanic;

                lvMechanicList.Items.Add(item);
            }
        }

        private void ClearEntryForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtHourlyRate.Clear();
            txtSpecialty.Clear();
            txtPhone.Clear();
            txtSearch.Clear();

            selectedMechanic = null;
            isEditMode = false;

            btnSave.Text = "Add Mechanic";
        }

        private void LoadMechanicToForm(Mechanic mechanic)
        {
            txtFirstName.Text = mechanic.FirstName;
            txtLastName.Text = mechanic.LastName;
            txtHourlyRate.Text = mechanic.HourlyRate.ToString("F2");
            txtSpecialty.Text = mechanic.Specialty ?? "";
            txtPhone.Text = mechanic.Phone ?? "";

            selectedMechanic = mechanic;
            isEditMode = true;

            btnSave.Text = "Update Mechanic";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtHourlyRate.Text))
            {
                MessageBox.Show("Please fill in First Name, Last Name, and Hourly Rate.");
                return;
            }

            if (!decimal.TryParse(txtHourlyRate.Text.Trim(), out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Please enter a valid hourly rate greater than 0.");
                return;
            }

            try
            {
                if (isEditMode && selectedMechanic != null)
                {
                    selectedMechanic.FirstName = txtFirstName.Text.Trim();
                    selectedMechanic.LastName = txtLastName.Text.Trim();
                    selectedMechanic.HourlyRate = rate;
                    selectedMechanic.Specialty = txtSpecialty.Text.Trim();
                    selectedMechanic.Phone = txtPhone.Text.Trim();

                    mechServicesHelper.UpdateMechanic(selectedMechanic);
                    MessageBox.Show("Mechanic updated successfully.");
                }
                else
                {
                    Mechanic newMechanic = new Mechanic
                    {
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        HourlyRate = rate,
                        Specialty = txtSpecialty.Text.Trim(),
                        Phone = txtPhone.Text.Trim()
                    };

                    mechServicesHelper.AddMechanic(newMechanic);
                    MessageBox.Show("Mechanic added successfully.");
                }

                LoadMechanicData();
                ClearEntryForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving mechanic: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearEntryForm();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearEntryForm();
            txtFirstName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvMechanicList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a mechanic to edit.");
                return;
            }

            selectedMechanic = (Mechanic)lvMechanicList.SelectedItems[0].Tag;
            LoadMechanicToForm(selectedMechanic);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvMechanicList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a mechanic to delete.");
                return;
            }

            selectedMechanic = (Mechanic)lvMechanicList.SelectedItems[0].Tag;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {selectedMechanic.FirstName} {selectedMechanic.LastName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    mechServicesHelper.DeleteMechanic(selectedMechanic.MechanicID);
                    LoadMechanicData();
                    ClearEntryForm();
                    MessageBox.Show("Mechanic deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting mechanic: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string term = txtSearch.Text.Trim();
            var filtered = mechServicesHelper.Search(term);

            lvMechanicList.Items.Clear();

            foreach (var mechanic in filtered)
            {
                ListViewItem item = new ListViewItem(mechanic.FirstName);
                item.SubItems.Add(mechanic.LastName);
                item.SubItems.Add(mechanic.HourlyRate.ToString("F2"));
                item.SubItems.Add(mechanic.Specialty ?? "");
                item.SubItems.Add(mechanic.Phone ?? "");
                item.Tag = mechanic;
                lvMechanicList.Items.Add(item);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshMechanicList();
        }

        private void lvMechanicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMechanicList.SelectedItems.Count > 0)
            {
                selectedMechanic = (Mechanic)lvMechanicList.SelectedItems[0].Tag;
            }
        }
    }
}