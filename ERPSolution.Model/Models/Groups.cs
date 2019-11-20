using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class Groups
    {
        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? GroupManager { get; set; }
        public Guid? GroupViceManager { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public Employees GroupManagerNavigation { get; set; }
        public Employees GroupViceManagerNavigation { get; set; }
    }
}
