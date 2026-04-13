using System;
using System.Windows.Forms;
using MechanicShop.Classes;
using MechanicShop.Helper;
using MechanicShop.Services;


namespace MechanicShop.Forms
{
    public partial class frmLogIn : Form
    {
        private AuthService authService;

        public frmLogIn()
        {
            InitializeComponent();
            authService = new AuthService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            lblMessage.Text = "";

            var result = authService.Authenticate(username, password);

            if (result.Success)
            {
                // Set current user in session
                UserSession.currentUser = result.User;

                // Close login form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblMessage.Text = result.Message;
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            lblMessage.Text = "";
            authService.ResetFailedAttempts();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}