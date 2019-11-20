using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class UserusersEmployeeRolesroles
    {
        public Guid? Roles { get; set; }
        public Guid? Users { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public EmployeeRoles RolesNavigation { get; set; }
        public User UsersNavigation { get; set; }
    }
}
