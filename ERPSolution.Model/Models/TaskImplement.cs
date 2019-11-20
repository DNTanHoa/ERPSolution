using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class TaskImplement
    {
        public Guid Oid { get; set; }
        public string Code { get; set; }
        public Guid? Task { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Note { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public Tasks TaskNavigation { get; set; }
    }
}
