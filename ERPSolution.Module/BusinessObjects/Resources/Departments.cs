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
    [XafDisplayName("Bộ Phận")]
    [XafDefaultProperty(nameof(name))]
    [Persistent(@"Departments")]
    [DefaultClassOptions]
    public class Departments : BaseObject
    {
        public Departments(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _code;
        [XafDisplayName("Mã Bộ Phận")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        private string _name;
        [XafDisplayName("Tên Bộ Phận")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        private Employees _departmentHead;
        [XafDisplayName("Trưởng Bộ Phận")]
        public Employees departmentHead
        {
            get => _departmentHead;
            set => SetPropertyValue(nameof(departmentHead), ref _departmentHead, value);
        }

        private string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }

        [Association(@"Employee-Department")]
        public XPCollection<Employees> employees => GetCollection<Employees>(nameof(employees));
    }
}
