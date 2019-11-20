using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class DesignFileAttach
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public Guid? Part { get; set; }
        public string Note { get; set; }
        public Guid? Design { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public Designes DesignNavigation { get; set; }
        public Parts PartNavigation { get; set; }
    }
}
