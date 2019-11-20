using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using ERPSolution.Module.BusinessObjects.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Productions
{
    [Persistent(@"ProductionOrder")]
    [XafDisplayName("Lệnh Sản Xuất")]
    [XafDefaultProperty(nameof(code))]
    [DefaultClassOptions]
    public class ProductionOrder : BaseObject
    {
        public ProductionOrder(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _code;
        [XafDisplayName("Mã Lệnh")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        private string _name;
        [XafDisplayName("Tên Lệnh")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        private string _description;
        [XafDisplayName("Mô Tả")]
        public string description
        {
            get => _description;
            set => SetPropertyValue(nameof(description), ref _description, value);
        }

        private DateTime? _inputDate;
        [XafDisplayName("Ngày Nhập")]
        public DateTime? inputDate
        {
            get => _inputDate;
            set => SetPropertyValue(nameof(inputDate), ref _inputDate, value);
        }

        private DateTime? _deadline;
        [XafDisplayName("Hạn Cuối")]
        public DateTime? deadline
        {
            get => _deadline;
            set => SetPropertyValue(nameof(deadline), ref _deadline, value);
        }

        private DateTime? _startDate;
        [XafDisplayName("Ngày Bắt Đầu")]
        public DateTime? startDate
        {
            get => _startDate;
            set => SetPropertyValue(nameof(startDate), ref _startDate, value);
        }

        private DateTime? _endDate;
        [XafDisplayName("Ngày Kết Thúc")]
        public DateTime? endDate
        {
            get => _endDate;
            set => SetPropertyValue(nameof(endDate), ref _endDate, value);
        }

        private Employees _supervisor;
        [XafDisplayName("Giám Sát")]
        public Employees supervisor
        {
            get => _supervisor;
            set => SetPropertyValue(nameof(supervisor), ref _supervisor, value);
        }

        //TODO: add for design Production Order

        private string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }

        [Association("ProductionOrder-Part")]
        [XafDisplayName("Danh Sách Chi Tiết")]
        public XPCollection<Parts> parts => GetCollection<Parts>(nameof(parts));
    }
}
