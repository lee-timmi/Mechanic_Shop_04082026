using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicShop.Helper
{
    public abstract class BaseRepository
    {
        protected readonly string connectionString;

        protected BaseRepository()
        {
            string dbPath = Path.Combine(Application.StartupPath, "MechanicShopDB.accdb");
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";
        }
    }
}
