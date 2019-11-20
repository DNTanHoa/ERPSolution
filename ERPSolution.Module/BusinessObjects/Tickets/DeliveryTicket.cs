using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Tickets
{
    [XafDisplayName("Phiếu Giao Hàng")]
    [Persistent(@"DeliveryTicket")]
    [DefaultClassOptions]
    [XafDefaultProperty(nameof(code))]
    public class DeliveryTicket : BaseObject
    {
        public DeliveryTicket(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _code;
        [XafDisplayName("Mã Phiếu Giao Hàng")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }
    }
}
