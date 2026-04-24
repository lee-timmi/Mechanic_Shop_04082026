using System;

namespace MechanicShop.Classes
{
    public class AuditLog
    {
        public int AuditID { get; set; }
        public string ActionType { get; set; }
        public string EntityType { get; set; }
        public int EntityID { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public string PerformedBy { get; set; }
    }
}