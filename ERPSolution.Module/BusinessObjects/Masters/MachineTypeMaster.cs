using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Masters
{
    [XafDisplayName("Phân Loại Máy")]
    [XafDefaultProperty(nameof(name))]
    [Persistent(@"MachineTypeMaster")]
    [DefaultClassOptions]
    public class MachineTypeMaster : BaseObject
    {
        public MachineTypeMaster(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _name;
        [XafDisplayName("Tên Phân Loại")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

    }
}
