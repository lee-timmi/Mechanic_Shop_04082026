using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechanicShopSystem.Helpers;

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
    }
}
