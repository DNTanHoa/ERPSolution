using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Productions
{
    [XafDisplayName("Lần Gia Công")]
    [Persistent(@"TaskImplement")]
    [XafDefaultProperty(nameof(code))]
    public class TaskImplements : BaseObject
    {
        public TaskImplements(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _code;
        [XafDisplayName("Mã Thực Hiện")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        private Tasks _task;
        [XafDisplayName("Nguyên Công")]
        public Tasks task
        {
            get => task;
            set => SetPropertyValue(nameof(task), ref _task, value);
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

        private string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
    }
}
