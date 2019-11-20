using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class DeliveryTicket
    {
        public Guid Oid { get; set; }
        public string Code { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
