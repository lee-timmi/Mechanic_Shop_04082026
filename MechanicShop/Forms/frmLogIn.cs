using System;
using System.Windows.Forms;
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

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            lblMessage.Text = "";

            var result = authService.Authenticate(username, password);

            if (result.Success)
            {
                UserSession.currentUser = result.User;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblMessage.Text = result.Message;
                txtPassword.Clear();
                txtPassword.Focus();

                if (result.Message.Contains("Too many failed attempts"))
                {
                    btnLogin.Enabled = false;
                }
            }
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

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog();
        }
    }
}