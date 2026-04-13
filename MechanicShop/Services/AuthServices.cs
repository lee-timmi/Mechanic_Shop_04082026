using MechanicShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Services
{
    public class AuthService
    {
        private List<User> _users;
        private int _failedAttempts;
        private const int MAX_ATTEMPTS = 3;

        public AuthService()
        {
            _failedAttempts = 0;
            LoadTestUsers();
        }

        private void LoadTestUsers()
        {
            _users = new List<User>
            {
                new User { Username = "admin", Password = "shop123", Role = UserRole.Admin },
                new User { Username = "staff", Password = "staff123", Role = UserRole.Staff },
                new User { Username = "mechanic", Password = "mech123", Role = UserRole.Mechanic }
            };
        }

        public (bool Success, User User, string Message) Authenticate(string username, string password)
        {
            // Check failed attempts
            if (_failedAttempts >= MAX_ATTEMPTS)
            {
                return (false, null, $"Too many failed attempts. Please restart the application.");
            }

            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return (false, null, "Please enter both username and password.");
            }

            // Find user
            var user = _users.FirstOrDefault(u =>
                u.Username.Equals(username, System.StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);

            if (user != null)
            {
                _failedAttempts = 0;
                return (true, user, "Login successful!");
            }
            else
            {
                _failedAttempts++;
                return (false, null, $"Invalid username or password. Attempts: {_failedAttempts}/{MAX_ATTEMPTS}");
            }
        }

        public void ResetFailedAttempts()
        {
            _failedAttempts = 0;
        }
    }
}
