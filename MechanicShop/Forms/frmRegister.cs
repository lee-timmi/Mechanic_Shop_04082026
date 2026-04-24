using MechanicShop.Classes;
using MechanicShop.Services;
using System;
using System.Windows.Forms;

namespace MechanicShop.Forms
{
    public partial class frmRegister : Form
    {
        private readonly UserService userService;

        public frmRegister()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            cboRole.Items.Clear();
            cboRole.Items.Add(UserRole.Admin);
            cboRole.Items.Add(UserRole.Staff);
            cboRole.Items.Add(UserRole.Mechanic);
            cboRole.SelectedIndex = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            lblMessage.Text = "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || cboRole.SelectedItem == null)
            {
                lblMessage.Text = "Please complete all fields.";
                return;
            }

            if (userService.UsernameExists(username))
            {
                lblMessage.Text = "Username already exists.";
                txtUsername.Focus();
                return;
            }

            User newUser = new User
            {
                Username = username,
                Password = password,
                Role = (UserRole)cboRole.SelectedItem
            };

            bool success = userService.AddUser(newUser);

            if (success)
            {
                MessageBox.Show("User created successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUsername.Clear();
                txtPassword.Clear();
                cboRole.SelectedIndex = 1;
                lblMessage.Text = "";
                txtUsername.Focus();
            }
            else
            {
                lblMessage.Text = "Unable to save user.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cboRole.SelectedIndex = 1;
            lblMessage.Text = "";
            txtUsername.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Added missing event handlers wired in the Designer to resolve CS1061
        private void lblTitle_Click(object sender, EventArgs e)
        {
            // Intentionally left blank - no action required when title label is clicked.
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            // Intentionally left blank
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Clear any message when user edits username
            if (lblMessage != null) lblMessage.Text = string.Empty;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Clear any message when user edits password
            if (lblMessage != null) lblMessage.Text = string.Empty;
        }

        private void lblRole_Click(object sender, EventArgs e)
        {
            // Intentionally left blank
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear any message when role changes
            if (lblMessage != null) lblMessage.Text = string.Empty;
        }
    }
}