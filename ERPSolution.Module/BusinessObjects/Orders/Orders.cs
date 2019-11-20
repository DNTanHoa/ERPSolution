using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using ERPSolution.Module.BusinessObjects.Customers;
using System;
using System.Linq;

namespace ERPSolution.Module.BusinessObjects.Orders
{
    [XafDisplayName("Đơn Hàng")]
    [XafDefaultProperty(nameof(code))]
    [DefaultClassOptions]
    [Persistent(@"Orders")]
    public class Orders : BaseObject
    {
        public Orders(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _code;
        [XafDisplayName("Mã Đơn Hàng")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        private string _content;
        [XafDisplayName("Nội Dung")]
        public string content
        {
            get => _content;
            set => SetPropertyValue(nameof(content), ref _content, value);
        }

        public Customer _customer;
        [XafDisplayName("Tên Khách Hàng")]
        public Customer customer
        {
            get => _customer;
            set => SetPropertyValue(nameof(customer), ref _customer, value);
        }
    }
}
