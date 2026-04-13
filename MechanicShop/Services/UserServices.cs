using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Services
{
    public class UserService
    {
        // For future: Add, Edit, Delete users
        // For now, just a placeholder

        public List<User> GetAllUsers()
        {
            // Will eventually load from database
            return new List<User>();
        }

        public bool AddUser(User user)
        {
            // Will eventually save to database
            return true;
        }
    }
}
