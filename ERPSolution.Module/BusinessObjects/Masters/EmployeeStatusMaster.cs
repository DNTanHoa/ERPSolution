using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using ERPSolution.Module.BusinessObjects.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Masters
{
    [XafDisplayName(@"Trạng Thái Công Nhân")]
    [XafDefaultProperty(nameof(name))]
    [Persistent(@"EmployeeStatusMaster")]
    [DefaultClassOptions]
    public class EmployeeStatusMaster : BaseObject
    {
        public EmployeeStatusMaster(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _name;
        [XafDisplayName("Tên Hiển Thị")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        private string _code;
        [XafDisplayName("Mã Trạng Thái")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        private bool _isActive;
        [XafDisplayName("Sẵn Sàng")]
        public bool isActive
        {
            get => _isActive;
            set => SetPropertyValue(nameof(isActive), ref _isActive, value);
        }

        private DateTime? _createDate;
        [XafDisplayName("Ngày Tạo")]
        public DateTime? createDate
        {
            get => _createDate;
            set => SetPropertyValue(nameof(createDate), ref _createDate, value);
        }

        private string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }

        private DateTime? _updateDate;
        [XafDisplayName("Ngày Cập Nhật")]
        public DateTime? updateDate
        {
            get => _updateDate;
            set => SetPropertyValue(nameof(updateDate), ref _updateDate, value);
        }

        private Users _createUser;
        [XafDisplayName("Người Tạo")]
        public Users createUser
        {
            get => _createUser;
            set => SetPropertyValue(nameof(createUser), ref _createUser, value);
        }
    }
}
