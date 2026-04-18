using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechanicShop.Helper;
using MechanicShop.Classes;
using MechanicShop.Forms;
using MehcnicShop.Helper;

namespace MechanicShop
{
    public partial class frmMain : Form
    {
        private VehicleApiService VehicleApiService;
        public frmMain()
        {
            VehicleApiService = new VehicleApiService();
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Displaying the logged-in user
            if (UserSession.currentUser != null)
            {
                lblLogInState.Text = $"Logged in as: {UserSession.currentUser.Username} " +
                                     $"({UserSession.currentUser.Role})";
            }

            // Role-based access control
            if (UserSession.HasRole(UserRole.Mechanic))
            {
                btnCustomers.Visible = false;
                btnVehicles.Visible = false;
                btnReports.Visible = false;
                btnAdmin.Visible = false;
                btnMechanics.Visible = false;
            } 
            else if (UserSession.HasRole(UserRole.Staff))
            {
                btnAdmin.Visible = false;
                btnMechanics.Visible = false;
                btnReports.Visible = false;
            }
        } // end of frmMain_Load

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomer customerForm = new frmCustomer();
            customerForm.ShowDialog();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            frmVehicle vehicleForm = new frmVehicle();
            vehicleForm.ShowDialog();
        }

        private void btnRepairOrders_Click(object sender, EventArgs e)
        {
            frmRepairOrder repairOrderForm = new frmRepairOrder();
            repairOrderForm.ShowDialog();
        }

        private void btnMechanics_Click(object sender, EventArgs e)
        {
            frmMechanic mechanicForm = new frmMechanic();
            mechanicForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Clear session
            UserSession.Logout();
            this.Close();
        }
    }
}
