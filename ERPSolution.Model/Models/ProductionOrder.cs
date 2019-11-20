using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class ProductionOrder
    {
        public ProductionOrder()
        {
            Parts = new HashSet<Parts>();
        }

        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? InputDate { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? Supervisor { get; set; }
        public string Note { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public Employees SupervisorNavigation { get; set; }
        public ICollection<Parts> Parts { get; set; }
    }
}
