using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                PerformedBy = UserSession.currentUser?.Username ?? "Unknown"
            });
        }
        public List<AuditLog> GetAll() => _auditRepository.GetAll();
    }
}
