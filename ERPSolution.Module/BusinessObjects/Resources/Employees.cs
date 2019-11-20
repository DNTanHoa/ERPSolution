using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;

namespace ERPSolution.Module.BusinessObjects.Resources
{
    [Persistent(@"Employees")]
    [XafDisplayName("Nhân Viên")]
    [XafDefaultProperty(nameof(name))]
    [DefaultClassOptions]
    public class Employees : BaseObject
    {
        public Employees(Session session): base(session) { }

        private string _code;
        [XafDisplayName("Mã Nhân Viên")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        private string _name;
        [XafDisplayName("Họ Và Tên")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        private DateTime? _dateOfBirth;
        [XafDisplayName("Ngày Sinh")]
        public DateTime? dateOfBirth
        {
            get => _dateOfBirth;
            set => SetPropertyValue(nameof(dateOfBirth), ref _dateOfBirth, value);
        }

        private Departments _departments;
        [Association(@"Employee-Department")]
        [XafDisplayName("Tên Bộ Phận")]
        public Departments departments
        {
            get => _departments;
            set => SetPropertyValue(nameof(departments), ref _departments, value);
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
