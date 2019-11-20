using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class WareHouses
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid? Manager { get; set; }
        public Guid? Supporter { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? CreateUser { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public User CreateUserNavigation { get; set; }
        public Employees ManagerNavigation { get; set; }
        public Employees SupporterNavigation { get; set; }
    }
}
