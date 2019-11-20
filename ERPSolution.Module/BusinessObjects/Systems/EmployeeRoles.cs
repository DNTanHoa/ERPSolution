using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Systems
{
    [Persistent(@"EmployeeRoles")]
    [XafDisplayName("Phân Quyền")]
    [DefaultClassOptions]
    [XafDefaultProperty(nameof(name))]
    public class EmployeeRoles : BaseObject
    {
        public EmployeeRoles(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _name;
        [XafDisplayName("Tên")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        [Association("User-Role")]
        [XafDisplayName("Danh Sách Người Dùng")]
        public XPCollection<Users> users => GetCollection<Users>(nameof(users));
    }
}
