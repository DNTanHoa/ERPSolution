using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class Orders
    {
        public Guid Oid { get; set; }
        public Guid? Customer { get; set; }
        public string Code { get; set; }
        public string Content { get; set; }
        public Guid? Customer1 { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public Customer Customer1Navigation { get; set; }
        public Customer CustomerNavigation { get; set; }
    }
}
