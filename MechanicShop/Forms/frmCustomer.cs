using MechanicShop.Classes;
using MechanicShop.Helper;
using MechanicShop.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MechanicShop.Forms
{
    public partial class frmCustomer : Form
    {
        // This form is used to add and edit customers in the database.
        // Private variables
        private List<Customer> customerList;
        private Customer selectedCustomer;
        private bool isEditMode;
        private CustomerService customerService;

        public frmCustomer()
        {
            InitializeComponent();
            var audit = new AuditService(new AuditRepository());
            customerService = new CustomerService(new CustomerRepository(), audit);
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
            customerList = customerService.GetAll();
            RefreshCustomerList();
        }

        private void RefreshCustomerList()
        {
            lvCustomerList.BeginUpdate();
            lvCustomerList.Items.Clear();

            List<Customer> sortedCustomers = new List<Customer>(customerList);

            for (int i = 0; i < sortedCustomers.Count - 1; i++)
            {
                for (int j = i + 1; j < sortedCustomers.Count; j++)
                {
                    if (string.Compare(sortedCustomers[j].LastName, sortedCustomers[i].LastName) < 0)
                    {
                        Customer temp = sortedCustomers[i];
                        sortedCustomers[i] = sortedCustomers[j];
                        sortedCustomers[j] = temp;
                    }
                }
            }

            foreach (Customer customer in sortedCustomers)
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
            btnManageVehicle.Enabled = false;
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
                    customerService.Update(selectedCustomer);
                    MessageBox.Show("Customer updated successfully.", "Success");
                }
                else
                {
                    // Create a new customer for add mode
                    Customer newCustomer = new Customer();
                    PopulateCustomerFromForm(newCustomer);

                    customerService.Add(newCustomer);
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

                ListViewItem selectedItem = lvCustomerList.SelectedItems[0];

                if (selectedItem != null)
                {
                    selectedCustomer = (Customer)lvCustomerList.SelectedItems[0].Tag;
                    LoadCustomerToForm(selectedCustomer);
                    isEditMode = true;
                    btnSave.Text = "Update Customer";

                    btnManageVehicle.Enabled = true;
                }
            }
            else
            {
                ClearEntryForm();
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
                    customerService.Delete(selectedCustomer.CustomerID);
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
            string searchTerm = txtSearch.Text.Trim();
            var filtered = customerService.Search(searchTerm);

            lvCustomerList.BeginUpdate();
            lvCustomerList.Items.Clear();

            List<Customer> sortedCustomers = new List<Customer>(customerList);

            for (int i = 0; i < sortedCustomers.Count - 1; i++)
            {
                for (int j = i + 1; j < sortedCustomers.Count; j++)
                {
                    if (string.Compare(sortedCustomers[j].LastName, sortedCustomers[i].LastName) < 0)
                    {
                        Customer temp = sortedCustomers[i];
                        sortedCustomers[i] = sortedCustomers[j];
                        sortedCustomers[j] = temp;
                    }
                }
            }

            foreach (Customer customer in sortedCustomers)
            {
                ListViewItem item = new ListViewItem($"{customer.FirstName} {customer.LastName}");
                item.SubItems.Add(customer.PhoneNumber ?? "");
                item.SubItems.Add(customer.Email ?? "");
                item.SubItems.Add(customer.Address ?? "");
                item.Tag = customer;
                lvCustomerList.Items.Add(item);
            }

            lvCustomerList.EndUpdate();
            lblStatus.Text = $"{filtered.Count} customers";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            RefreshCustomerList();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer first");
                return;
            }

            // Open Repair Order & pass customerID
            frmRepairOrder orderForm = new frmRepairOrder(customerId: selectedCustomer.CustomerID);
            orderForm.ShowDialog();

        }

        private void btnManageVehicle_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer first.", "No Customer Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmVehicle vehicleForm = new frmVehicle(selectedCustomer.CustomerID);
            vehicleForm.ShowDialog();
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text = FormatPhoneNumber(txtPhone.Text);
            }
        }

        // Helper for phone format
        private string FormatPhoneNumber(string phone)
        {
            string digits = "";

            foreach (char c in phone)
            {
                if (char.IsDigit(c))
                {
                    digits += c;
                }
            }
            if (digits.Length == 10)
            {
                return $"({digits.Substring(0,3)}) {digits.Substring(3,3)}-{digits.Substring(6,4)}";
            }
            else if (digits.Length == 11 && digits[0] == '1') 
            {
                return $"({digits.Substring(1, 3)}) {digits.Substring(4, 3)}-{digits.Substring(7, 4)}";
            }
            return phone;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
