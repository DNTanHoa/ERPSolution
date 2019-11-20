using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class EmployeeStatusMaster
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Note { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? CreateUser { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public User CreateUserNavigation { get; set; }
    }
}
