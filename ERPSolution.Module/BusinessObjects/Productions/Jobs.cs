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
    [Persistent(@"Job")]
    [XafDisplayName(@"Công Việc")]
    [XafDefaultProperty(nameof(code))]
    public class Jobs : BaseObject
    {
        public Jobs(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _code;
        [XafDisplayName("Mã Công Việc")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        private DateTime _startDate;
        [XafDisplayName("Ngày Bắt Đầu")]
        public DateTime startDate
        {
            get => _startDate;
            set => SetPropertyValue(nameof(startDate), ref _startDate, value);
        }

        private DateTime _endDate;
        [XafDisplayName("Ngày Bắt Đầu")]
        public DateTime endDate
        {
            get => _endDate;
            set => SetPropertyValue(nameof(endDate), ref _endDate, value);
        }

        private TimeSpan _startTime;
        [XafDisplayName("Bắt Đầu")]
        public TimeSpan startTime
        {
            get => _startTime;
            set => SetPropertyValue(nameof(startTime), ref _startTime, value);
        }

        private TimeSpan _endTime;
        [XafDisplayName("Kết Thúc")]
        public TimeSpan endTime
        {
            get => _endTime;
            set => SetPropertyValue(nameof(endTime), ref _endTime, value);
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
