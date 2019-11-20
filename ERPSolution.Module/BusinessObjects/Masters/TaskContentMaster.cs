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
    [Persistent(@"TaskContentMaster")]
    [DefaultClassOptions]
    [XafDisplayName("Danh Sách Nguyên Công")]
    [XafDefaultProperty(nameof(name))]
    public class TaskContentMaster : BaseObject
    {
        public TaskContentMaster(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _name;
        [XafDisplayName("Tên Nguyên Công")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        private string _code;
        [XafDisplayName("Mã Nguyên Công")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        private bool _isOutSite;
        [XafDisplayName("Gia Công Ngoài")]
        public bool isOutSite
        {
            get => _isOutSite;
            set => SetPropertyValue(nameof(isOutSite), ref _isOutSite, value);
        }

        private DateTime? _createDate;
        [XafDisplayName("Ngày Tạo")]
        public DateTime? createDate
        {
            get => _createDate;
            set => SetPropertyValue(nameof(createDate), ref _createDate, value);
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
