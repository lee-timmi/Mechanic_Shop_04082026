using MechanicShop.Classes;
using MechanicShop.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicShop.Forms
{
    public partial class frmCustomer : Form
    {
        // This form is used to add and edit customers in the database.
        // Private variables
        private DBHelper dbHelper;
        private List<Customer> customerList;
        private Customer selectedCustomer;
        private bool isEditMode;

        public frmCustomer()
        {
            InitializeComponent();
            dbHelper = new DBHelper();
            LoadCustomerData();
            ClearEntryForm();
            isEditMode = false;
        }

        private void SetupListView()
        {
            lvCustomerList.Columns.Clear();
            lvCustomerList.Columns.Add("First Name", 120);
            lvCustomerList.Columns.Add("Last Name", 120);
            lvCustomerList.Columns.Add("Phone", 100);
            lvCustomerList.Columns.Add("Email", 150);
            lvCustomerList.View = View.Details;
        }

        private void LoadCustomerData()
        {
            customerList = dbHelper.GetAllCustomers();
            RefreshCustomerList();
        }

        private void RefreshCustomerList()
        {
            lvCustomerList.BeginUpdate();
            lvCustomerList.Items.Clear();

            foreach (var customer in customerList.OrderBy(c => c.LastName))
            {
                string fullName = $"{customer.FirstName} {customer.LastName}";

                ListViewItem item = new ListViewItem(fullName);
                item.SubItems.Add(customer.PhoneNumber ?? "");
                item.SubItems.Add(customer.Email ?? "");
                item.SubItems.Add(customer.Address ?? "");

                item.Tag = customer;
                lvCustomerList.Items.Add(item);
            }

            lvCustomerList.EndUpdate();
            lblStatus.Text = $"Total Customers: {customerList.Count}";
        }

        private void RefreshCustomerListFiltered(List<Customer> filteredCustomers)
        {
            lvCustomerList.BeginUpdate();
            lvCustomerList.Items.Clear();

            foreach (var customer in customerList.OrderBy(c => c.LastName))
            {
                string fullName = $"{customer.FirstName} {customer.LastName}";

                ListViewItem item = new ListViewItem(fullName);
                item.SubItems.Add(customer.PhoneNumber ?? "");
                item.SubItems.Add(customer.Email ?? "");
                item.SubItems.Add(customer.Address ?? "");

                item.Tag = customer;
                lvCustomerList.Items.Add(item);
            }

            lvCustomerList.EndUpdate();
            lblStatus.Text = $"{filteredCustomers.Count} customers";
        }

        private void ClearEntryForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            selectedCustomer = null;
            isEditMode = false;
            btnSave.Text = "Add Customer";
            this.Text = "Customer Management - Add Mode";
        }

        private void LoadCustomerToForm(Customer customer)
        {
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtPhone.Text = customer.PhoneNumber;
            txtEmail.Text = customer.Email;
            txtAddress.Text = customer.Address;
            selectedCustomer = customer;
            isEditMode = true;
            btnSave.Text = "Update Customer";
            this.Text = "Customer Management - Edit Mode";
        }

        // Populate a Customer instance with values from the entry form
        private void PopulateCustomerFromForm(Customer c)
        {
            c.FirstName = txtFirstName.Text.Trim();
            c.LastName = txtLastName.Text.Trim();
            c.PhoneNumber = txtPhone.Text.Trim();
            c.Email = txtEmail.Text.Trim();
            c.Address = txtAddress.Text.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First Name and Last Name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (isEditMode && selectedCustomer != null)
                {
                    // Only update the existing customer when in edit mode and selectedCustomer is set
                    PopulateCustomerFromForm(selectedCustomer);
                    dbHelper.UpdateCustomer(selectedCustomer);
                    MessageBox.Show("Customer updated successfully.", "Success");
                }
                else
                {
                    // Create a new customer for add mode
                    Customer newCustomer = new Customer();
                    PopulateCustomerFromForm(newCustomer);

                    dbHelper.AddCustomer(newCustomer);
                    MessageBox.Show("Customer added successfully.", "Success");

                }

                LoadCustomerData();
                ClearEntryForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer: {ex.Message}", "Database Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearEntryForm();
        }

        private void lvCustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCustomerList.SelectedIndices.Count > 0)
            {
                selectedCustomer = (Customer)lvCustomerList.SelectedItems[0].Tag;
                LoadCustomerToForm(selectedCustomer);
                isEditMode = true;
                btnSave.Text = "Update Customer";
            }
            else
            {
                MessageBox.Show("No customer selected.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearEntryForm();
            isEditMode = false;
            selectedCustomer = null;
            btnSave.Text = "Add Customer";
            txtFirstName.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvCustomerList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lvCustomerList.SelectedItems[0];
            if (selectedItem.Tag == null)
            {
                MessageBox.Show("Error: Customer data not found.", "Error");
                return;
            }

            selectedCustomer = (Customer)selectedItem.Tag;
            LoadCustomerToForm(selectedCustomer);
            isEditMode = true;
            btnSave.Text = "Update Customer";
            txtFirstName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvCustomerList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lvCustomerList.SelectedItems[0];
            if (selectedItem.Tag == null)
            {
                MessageBox.Show("Error: Customer data not found.", "Error");
                return;
            }

            selectedCustomer = (Customer)selectedItem.Tag;

            DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedCustomer.FirstName} {selectedCustomer.LastName}?",
                                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    dbHelper.DeleteCustomer(selectedCustomer.CustomerID);
                    MessageBox.Show("Customer deleted successfully.", "Success");
                    LoadCustomerData();
                    ClearEntryForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting customer: {ex.Message}", "Database Error");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();

            if(string.IsNullOrWhiteSpace(searchTerm))
            {
                RefreshCustomerList();
            }
            else
            {
                var filtered = customerList.Where(c =>
                    c.FirstName.ToLower().Contains(searchTerm) ||
                    c.LastName.ToLower().Contains(searchTerm) ||
                    c.Email.ToLower().Contains(searchTerm) ||
                    c.PhoneNumber.ToLower().Contains(searchTerm)).ToList();

                RefreshCustomerListFiltered(filtered);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            RefreshCustomerList();
        }
    }
}
