using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class User
    {
        public User()
        {
            Designes = new HashSet<Designes>();
            EmployeeStatusMaster = new HashSet<EmployeeStatusMaster>();
            JobMaster = new HashSet<JobMaster>();
            Material = new HashSet<Material>();
            ProductMaster = new HashSet<ProductMaster>();
            ProductionStatusMaster = new HashSet<ProductionStatusMaster>();
            TaskContentMaster = new HashSet<TaskContentMaster>();
            UnitMaster = new HashSet<UnitMaster>();
            UserusersEmployeeRolesroles = new HashSet<UserusersEmployeeRolesroles>();
            WareHouses = new HashSet<WareHouses>();
        }

        public Guid Oid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public ICollection<Designes> Designes { get; set; }
        public ICollection<EmployeeStatusMaster> EmployeeStatusMaster { get; set; }
        public ICollection<JobMaster> JobMaster { get; set; }
        public ICollection<Material> Material { get; set; }
        public ICollection<ProductMaster> ProductMaster { get; set; }
        public ICollection<ProductionStatusMaster> ProductionStatusMaster { get; set; }
        public ICollection<TaskContentMaster> TaskContentMaster { get; set; }
        public ICollection<UnitMaster> UnitMaster { get; set; }
        public ICollection<UserusersEmployeeRolesroles> UserusersEmployeeRolesroles { get; set; }
        public ICollection<WareHouses> WareHouses { get; set; }
    }
}
