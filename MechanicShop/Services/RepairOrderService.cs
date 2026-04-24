using MechanicShop.Classes;
using MechanicShop.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicShop.Services
{
    public class RepairOrderService
    {
        private readonly RepairOrderRepository _repo;
        private readonly AuditService _audit;

        public RepairOrderService(RepairOrderRepository repo, AuditService audit)
        {
            _repo = repo;
            _audit = audit;
        }

        public string GenerateOrderNumber()
        {
            string year = DateTime.Now.Year.ToString();
            int next = _repo.GetNextOrderNumber(year);
            return $"RO-{year}-{next:D4}";
        }

        public List<RepairOrder> GetAll()
            => _repo.GetAll();

        public void Save(RepairOrder order, List<LaborLineItem> labor, List<PartsLineItem> parts)
        {
            _repo.Save(order, labor, parts);
            _audit.Log("Created", "RepairOrder", order.RepairOrderId,
                $"Order {order.OrderNumber} created for customer {order.CustomerId}");
        }

        public void Update(RepairOrder order, List<LaborLineItem> labor, List<PartsLineItem> parts)
        { 
            _repo.Update(order, labor, parts);
            _audit.Log("Updated", "RepairOrder", order.RepairOrderId,
                $"Order {order.OrderNumber} was updated");
        } 

        public List<RepairOrder> Filter(string searchTerm, string status, DateTime fromDate, DateTime toDate)
        {
            var filtered = _repo.GetAll().AsEnumerable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                filtered = filtered.Where(r =>
                    r.RepairOrderId.ToString().Contains(searchTerm) ||
                    r.CustomerName.ToLower().Contains(searchTerm) ||
                    r.VehicleDisplay.ToLower().Contains(searchTerm) ||
                    r.RepairStatus.ToLower().Contains(searchTerm));
            }

            if (!string.IsNullOrWhiteSpace(status) && status != "All")
                filtered = filtered.Where(r => r.RepairStatus == status);

            filtered = filtered.Where(r =>
                r.DateOpened.Date >= fromDate.Date &&
                r.DateOpened.Date <= toDate.Date);

            return filtered.OrderByDescending(r => r.DateOpened).ToList();
        }

        public void Delete(int repairOrderId) 
        {
            _repo.Delete(repairOrderId);
            _audit.Log("Deleted", "RepairOrder", repairOrderId,
                $"Order {repairOrderId} was deleted");
        } 
    }
}
