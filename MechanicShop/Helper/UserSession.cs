using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MechanicShop.Classes;

namespace MechanicShop.Helper
{
    public static class UserSession
    {
        private static User _currentUser;

        public static User currentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        public static bool IsLoggedIn
        {
            get { return currentUser != null; }
        }

        public static bool HasRole(UserRole role)
        {
            if (_currentUser == null)
                return false;

            return _currentUser.Role == role;
        }

        public static void Logout()
        {
            _currentUser = null;
        }
    }
}
