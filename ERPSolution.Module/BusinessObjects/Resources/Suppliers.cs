using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Resources
{
    [XafDisplayName("Nhà Cung Cấp")]
    [XafDefaultProperty(nameof(name))]
    [Persistent(@"Suppliers")]
    [DefaultClassOptions]
    public class Suppliers : BaseObject
    {
        public Suppliers(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _code;
        [XafDisplayName("Mã Nhà Cung Cấp")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        private string _name;
        [XafDisplayName("Tên Nhà Cung Cấp")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

    }
}
