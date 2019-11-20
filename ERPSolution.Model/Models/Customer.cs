using System;
using System.Collections.Generic;

namespace ERPSolution.Model.Models
{
    public partial class Customer
    {
        public Customer()
        {
            OrdersCustomer1Navigation = new HashSet<Orders>();
            OrdersCustomerNavigation = new HashSet<Orders>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public ICollection<Orders> OrdersCustomer1Navigation { get; set; }
        public ICollection<Orders> OrdersCustomerNavigation { get; set; }
    }
}
