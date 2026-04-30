using System;
using System.Collections.Generic;
using MechanicShop.Helper;
using MechanicShop.Classes;

namespace MechanicShop.Services
{
    public class AuditService
    {
        private readonly AuditRepository _auditRepository;

        public AuditService(AuditRepository auditRepository)
        {
           _auditRepository = auditRepository;
        }

        public void Log(string actionType, string entityType, int entityID, string description)
        {
            _auditRepository.Log(new AuditLog
            {
                ActionType = actionType,
                EntityType = entityType,
                EntityID = entityID,
                Description = description,
                Timestamp = DateTime.Now,
                PerformedBy = GetCurrentUsername()
            });
        }
        public List<AuditLog> GetAll()
        {
            return _auditRepository.GetAll();
        }
        private string GetCurrentUsername()
        {
            if (UserSession.currentUser != null)
            {
                return UserSession.currentUser.Username;
            }

            return "Unknown";
        }
    }
}
