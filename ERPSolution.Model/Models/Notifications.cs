using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class Notifications
    {
        public Guid Oid { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
