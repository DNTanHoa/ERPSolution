using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using ERPSolution.Module.BusinessObjects.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Productions
{
    [XafDisplayName("Nguyên Công")]
    [Persistent(@"Tasks")]
    [XafDefaultProperty(nameof(name))]
    [DefaultClassOptions]
    public class Tasks : BaseObject
    {
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

        private TaskContentMaster _taskContent;
        [XafDisplayName("Loại Nguyên Công")]
        public TaskContentMaster taskContent
        {
            get => _taskContent;
            set => SetPropertyValue(nameof(taskContent), ref _taskContent, value);
        }

        private DateTime? _deadline;
        [XafDisplayName("Hạn Cuối")]
        public DateTime? deadline
        {
            get => _deadline;
            set => SetPropertyValue(nameof(deadline), ref _deadline, value);
        }

        private DateTime? _finishedDate;
        [XafDisplayName("Ngày Hoàn Thành")]
        public DateTime? finishedDate
        {
            get => _finishedDate;
            set => SetPropertyValue(nameof(finishedDate), ref _finishedDate, value);
        }

        private DateTime? _expectedStartDate;
        [XafDisplayName("Ngày Dự Định Bắt Đầu")]
        public DateTime? expectedStartDate
        {
            get => _expectedStartDate;
            set => SetPropertyValue(nameof(expectedStartDate), ref _expectedStartDate, value);
        }

        private DateTime? _startDate;
        [XafDisplayName("Ngày Bắt Đầu")]
        public DateTime? startDate
        {
            get => _startDate;
            set => SetPropertyValue(nameof(startDate), ref _startDate, value);
        }

        private int _step;
        [XafDisplayName("Bước")]
        [RuleRange(1,10)]
        public int step
        {
            get => _step;
            set => SetPropertyValue(nameof(step), ref _step, value);
        }

        private int _requiredAmount;
        [XafDisplayName("Số Lượng Yêu Cầu")]
        public int requiredAmount
        {
            get => _requiredAmount;
            set => SetPropertyValue(nameof(requiredAmount), ref _requiredAmount, value);
        }

        private int _finishedAmount;
        [XafDisplayName("Số Lượng Hoàn Thành")]
        public int finishedAmount
        {
            get => _finishedAmount;
            set => SetPropertyValue(nameof(finishedAmount), ref _finishedAmount, value);
        }

        private Parts _part;
        [XafDisplayName("Chi Tiết")]
        [Association("Part-Task")]
        public Parts part
        {
            get => _part;
            set => SetPropertyValue(nameof(part), ref _part, value);
        }
    }
}
