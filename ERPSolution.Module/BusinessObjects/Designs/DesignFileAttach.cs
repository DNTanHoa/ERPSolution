using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using ERPSolution.Module.BusinessObjects.Productions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Designs
{
    [XafDisplayName("Tài Liệu Thiết Kế")]
    [XafDefaultProperty(nameof(name))]
    [Persistent(@"DesignFileAttach")]
    [DefaultClassOptions]
    public class DesignFileAttach : BaseObject
    {
        public DesignFileAttach(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _name;
        [XafDisplayName("Tên Tài Liệu")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        private Parts _part;
        [XafDisplayName("Chi Tiết")]
        public Parts part
        {
            get => _part;
            set => SetPropertyValue(nameof(name), ref _part, value);
        }

        //TODO: Save file to sever

        private string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }

        private Designes _design;
        [XafDisplayName("Thiết Kế")]
        [Association(@"Designs-FileAttach")]
        public Designes design
        {
            get => _design;
            set => SetPropertyValue(nameof(design), ref _design, value);
        }
    }
}
