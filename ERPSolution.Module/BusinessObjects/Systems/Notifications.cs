using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Systems
{
    [Persistent(@"Notifications")]
    [XafDisplayName("Thông Báo")]
    [XafDefaultProperty(nameof(title))]
    [DefaultClassOptions]
    public class Notifications : BaseObject
    {
        public Notifications(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _title;
        [XafDisplayName("Tiêu Đề")]
        public string title
        {
            get => _title;
            set => SetPropertyValue(nameof(title), ref _title, value);
        }

        private string _content;
        [XafDisplayName("Content")]
        public string content
        {
            get => _content;
            set => SetPropertyValue(nameof(content), ref _content, value);
        }


    }
}
