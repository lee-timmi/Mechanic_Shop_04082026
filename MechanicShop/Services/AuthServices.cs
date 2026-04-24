using MechanicShop.Classes;
using MechanicShop.Helper;
using System.Collections.Generic;

namespace MechanicShop.Services
{
    public class AuthService
    {
        private int _failedAttempts;
        private const int MAX_ATTEMPTS = 3;
        private DBHelper dbHelper;

        public AuthService()
        {
            _failedAttempts = 0;
            dbHelper = new DBHelper();
            
        }

        

        public (bool Success, User User, string Message) Authenticate(string username, string password)
        {
            if (_failedAttempts >= MAX_ATTEMPTS)
            {
                return (false, null, "Too many failed attempts. Please restart the application.");
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return (false, null, "Please enter both username and password.");
            }

            User user = dbHelper.ValidateUser(username, password);

            if (user != null)
            {
                _failedAttempts = 0;
                return (true, user, "Login successful!");
            }

            _failedAttempts++;
            return (false, null, $"Invalid username or password. Attempts: {_failedAttempts}/{MAX_ATTEMPTS}");
        }

        public void ResetFailedAttempts()
        {
            _failedAttempts = 0;
        }
    }
}