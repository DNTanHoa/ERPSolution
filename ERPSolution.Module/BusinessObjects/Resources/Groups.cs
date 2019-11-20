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
    [XafDisplayName("Tổ")]
    [XafDefaultProperty(nameof(name))]
    [Persistent(@"Groups")]
    [DefaultClassOptions]
    public class Groups : BaseObject
    {
        public Groups(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _code;
        [XafDisplayName("Mã Tổ")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        private string _name;
        [XafDisplayName("Tên Tổ")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        private Employees _groupManager;
        [XafDisplayName("Tổ Trưởng")]
        public Employees groupManager
        {
            get => _groupManager;
            set => SetPropertyValue(nameof(groupManager), ref _groupManager, value);
        }

        private Employees _groupViceManager;
        [XafDisplayName("Tổ Phó")]
        public Employees groupViceManager
        {
            get => _groupViceManager;
            set => SetPropertyValue(nameof(groupViceManager), ref _groupViceManager, value);
        }
    }
}
