using MechanicShop.Classes;
using MechanicShop.Helper;
using System;
using System.Collections.Generic;

namespace MechanicShop.Services
{
    public class RepairOrderService
    {
        private readonly RepairOrderRepository _repo;
        private readonly AuditService _audit;

        public RepairOrderService(RepairOrderRepository repo, AuditService audit)
        {
            _repo  = repo;
            _audit = audit;
        }

        public string GenerateOrderNumber()
        {
            string year = DateTime.Now.Year.ToString();
            int next = _repo.GetNextOrderNumber(year);
            return "RO-" + year + "-" + next.ToString("D4");
        }

        public List<RepairOrder> GetAll()
        {
            return _repo.GetAll();
        }

        public void Save(RepairOrder order, List<LaborLineItem> labor, List<PartsLineItem> parts)
        {
            _repo.Save(order, labor, parts);
            if (_audit != null)
            {
                _audit.Log("Created", "RepairOrder", order.RepairOrderId,
                    "Order " + order.OrderNumber + " created for customer " + order.CustomerId);
            }
        }

        public void Update(RepairOrder order, List<LaborLineItem> labor, List<PartsLineItem> parts)
        {
            _repo.Update(order, labor, parts);
            if (_audit != null)
            {
                _audit.Log("Created", "RepairOrder", order.RepairOrderId,
                    "Order " + order.OrderNumber + " created for customer " + order.CustomerId);
            }
        }

        public List<RepairOrder> Filter(string searchTerm, string status, DateTime fromDate, DateTime toDate)
        {
            List<RepairOrder> allOrders = _repo.GetAll();
            List<RepairOrder> filtered  = new List<RepairOrder>();

            for (int i = 0; i < allOrders.Count; i++)
            {
                RepairOrder r = allOrders[i];
                bool matchesSearch = true;
                bool matchesStatus = true;
                bool matchesDate   = true;

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    string term = searchTerm.ToLower();
                    matchesSearch =
                        r.RepairOrderId.ToString().Contains(term) ||
                        r.CustomerName.ToLower().Contains(term) ||
                        r.VehicleDisplay.ToLower().Contains(term) ||
                        r.RepairStatus.ToLower().Contains(term);
                }

                if (!string.IsNullOrWhiteSpace(status) && status != "All")
                {
                    matchesStatus = r.RepairStatus == status;
                }

                matchesDate = r.DateOpened.Date >= fromDate.Date &&
                              r.DateOpened.Date <= toDate.Date;

                if (matchesSearch && matchesStatus && matchesDate)
                    filtered.Add(r);
            }

            // Sort by date descending (newest first) using simple bubble sort
            for (int i = 0; i < filtered.Count - 1; i++)
            {
                for (int j = 0; j < filtered.Count - i - 1; j++)
                {
                    if (filtered[j].DateOpened < filtered[j + 1].DateOpened)
                    {
                        RepairOrder temp = filtered[j];
                        filtered[j]     = filtered[j + 1];
                        filtered[j + 1] = temp;
                    }
                }
            }

            return filtered;
        }

        public void Delete(int repairOrderId)
        {
            _repo.Delete(repairOrderId);
            if (_audit != null)
            {
                _audit.Log("Deleted", "RepairOrder", repairOrderId,
                    "Order " + repairOrderId + " was deleted");
            }
        }
    }
}
