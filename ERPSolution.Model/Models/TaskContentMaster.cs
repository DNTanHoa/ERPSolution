using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class TaskContentMaster
    {
        public TaskContentMaster()
        {
            Tasks = new HashSet<Tasks>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool? IsOutSite { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? CreateUser { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public User CreateUserNavigation { get; set; }
        public ICollection<Tasks> Tasks { get; set; }
    }
}
