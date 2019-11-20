using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class EmployeeRoles
    {
        public EmployeeRoles()
        {
            UserusersEmployeeRolesroles = new HashSet<UserusersEmployeeRolesroles>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public ICollection<UserusersEmployeeRolesroles> UserusersEmployeeRolesroles { get; set; }
    }
}
