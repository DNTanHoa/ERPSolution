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
    [XafDisplayName(@"Máy")]
    [XafDefaultProperty(nameof(name))]
    [Persistent(@"Machines")]
    [DefaultClassOptions]
    public class Machines : BaseObject
    {
        public Machines(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _name;
        [XafDisplayName("Tên Máy")]
        public string name
        {
            set => SetPropertyValue(nameof(name), ref _name, value);
            get => _name;
        }

        private string _code;
        [XafDisplayName("Mã Máy")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
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
