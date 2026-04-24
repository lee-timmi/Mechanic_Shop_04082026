using MechanicShop.Classes;
using MechanicShop.Helper;
using System.Collections.Generic;

namespace MechanicShop.Services
{
    public class UserService
    {
        private readonly DBHelper dbHelper;

        public UserService()
        {
            dbHelper = new DBHelper();
        }

        public List<User> GetAllUsers()
        {
            return dbHelper.GetAllUsers();
        }

        public bool AddUser(User user)
        {
            if (user == null)
                return false;

            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
                return false;

            if (dbHelper.UsernameExists(user.Username))
                return false;

            return dbHelper.AddUser(user);
        }

        public bool UsernameExists(string username)
        {
            return dbHelper.UsernameExists(username);
        }
    }
}