using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class Tasks
    {
        public Tasks()
        {
            TaskImplement = new HashSet<TaskImplement>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid? TaskContent { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime? FinishedDate { get; set; }
        public DateTime? ExpectedStartDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Step { get; set; }
        public int? RequiredAmount { get; set; }
        public int? FinishedAmount { get; set; }
        public Guid? Part { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public Parts PartNavigation { get; set; }
        public TaskContentMaster TaskContentNavigation { get; set; }
        public ICollection<TaskImplement> TaskImplement { get; set; }
    }
}
