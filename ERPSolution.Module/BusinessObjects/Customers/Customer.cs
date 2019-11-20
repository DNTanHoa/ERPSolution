using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Customers
{
    [Persistent(@"Customer")]
    [XafDisplayName("Khách Hàng")]
    [DefaultClassOptions]
    [XafDefaultProperty(nameof(name))]
    public class Customer : BaseObject
    {
        private string _name;
        [XafDisplayName("Tên Khách Hàng")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        private string _code;
        [XafDisplayName("Mã Khách Hàng")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }
    }
}
