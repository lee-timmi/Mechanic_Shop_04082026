using System;
using System.Windows.Forms;

namespace MechanicShop.Forms
{
    public partial class frmLogIn : Form
    {
        private const string ValidUsername = "admin";
        private const string ValidPassword = "shop123";

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            lblMessage.Text = "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Please enter both username and password.";
                return;
            }

            if (username.Equals(ValidUsername, StringComparison.OrdinalIgnoreCase) &&
                password == ValidPassword)
            {
                //frmMain mainForm = new frmMain();
                //mainForm.FormClosed += MainForm_FormClosed;
                //mainForm.Show();
                //this.Hide();

                frmVehicle vehicleForm = new frmVehicle();
                vehicleForm.FormClosed += MainForm_FormClosed;
                vehicleForm.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Invalid username or password.";
                txtPassword.Clear();
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            lblMessage.Text = "";
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}