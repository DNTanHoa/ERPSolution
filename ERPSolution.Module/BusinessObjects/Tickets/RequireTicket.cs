using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Tickets
{
    [XafDisplayName("Phiếu Yêu Cầu")]
    public class RequireTicket : BaseObject
    {
        public RequireTicket(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _code;
        [XafDisplayName("Mã Phiếu Yêu Cầu")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        //TODO: Add more properties for require ticket
    }
}
