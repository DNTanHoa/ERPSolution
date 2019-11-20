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
    [Persistent(@"User")]
    [XafDisplayName("Nguời Dùng")]
    [XafDefaultProperty(nameof(username))]
    [DefaultClassOptions]
    public class Users : BaseObject
    {
        public Users(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _username;
        [XafDisplayName("Tên Đăng Nhập")]
        public string username
        {
            get => _username;
            set => SetPropertyValue(nameof(username), ref _username, value);
        }

        private string _password;
        [XafDisplayName("Mật Khẩu")]
        public string password
        {
            get => _password;
            set => SetPropertyValue(nameof(password), ref _password, value);
        }

        private bool _isActive;
        [XafDisplayName("Kích Hoạt")]
        public bool isActive
        {
            get => _isActive;
            set => SetPropertyValue(nameof(isActive), ref _isActive, value);
        }

        [Association("User-Role")]
        [XafDisplayName("Quyền Người Dùng")]
        public XPCollection<EmployeeRoles> roles => GetCollection<EmployeeRoles>(nameof(roles));
    }
}
