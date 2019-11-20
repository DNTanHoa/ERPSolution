using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Employees = new HashSet<Employees>();
        }

        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? DepartmentHead { get; set; }
        public string Note { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public Employees DepartmentHeadNavigation { get; set; }
        public ICollection<Employees> Employees { get; set; }
    }
}
