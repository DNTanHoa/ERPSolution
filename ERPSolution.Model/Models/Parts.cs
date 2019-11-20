using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class Parts
    {
        public Parts()
        {
            DesignFileAttach = new HashSet<DesignFileAttach>();
            Tasks = new HashSet<Tasks>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid? ProductionOrder { get; set; }
        public int? Amount { get; set; }
        public string Shape { get; set; }
        public string RoughSize { get; set; }
        public string StandardSize { get; set; }
        public Guid? Material { get; set; }
        public string Note { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public Material MaterialNavigation { get; set; }
        public ProductionOrder ProductionOrderNavigation { get; set; }
        public ICollection<DesignFileAttach> DesignFileAttach { get; set; }
        public ICollection<Tasks> Tasks { get; set; }
    }
}
