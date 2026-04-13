using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechanicShop.Forms;

namespace MechanicShop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (frmLogIn LogInForm =  new frmLogIn())
                {
                    if (LogInForm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new frmMain());
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
