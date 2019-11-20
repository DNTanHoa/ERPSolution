using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class Employees
    {
        public Employees()
        {
            DepartmentsNavigation = new HashSet<Departments>();
            GroupsGroupManagerNavigation = new HashSet<Groups>();
            GroupsGroupViceManagerNavigation = new HashSet<Groups>();
            ProductionOrder = new HashSet<ProductionOrder>();
            WareHousesManagerNavigation = new HashSet<WareHouses>();
            WareHousesSupporterNavigation = new HashSet<WareHouses>();
        }

        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Guid? Departments { get; set; }
        public string Note { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public Departments Departments1 { get; set; }
        public ICollection<Departments> DepartmentsNavigation { get; set; }
        public ICollection<Groups> GroupsGroupManagerNavigation { get; set; }
        public ICollection<Groups> GroupsGroupViceManagerNavigation { get; set; }
        public ICollection<ProductionOrder> ProductionOrder { get; set; }
        public ICollection<WareHouses> WareHousesManagerNavigation { get; set; }
        public ICollection<WareHouses> WareHousesSupporterNavigation { get; set; }
    }
}
