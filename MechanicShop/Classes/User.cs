namespace MechanicShop.Classes
{
    public enum UserRole
    {
        Admin,
        Mechanic,
        Staff
    }
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
