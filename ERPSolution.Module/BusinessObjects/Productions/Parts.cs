using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using ERPSolution.Module.BusinessObjects.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Module.BusinessObjects.Productions
{
    [Persistent(@"Parts")]
    [XafDisplayName("Chi Tiết")]
    [XafDefaultProperty(nameof(code))]
    [DefaultClassOptions]
    public class Parts : BaseObject
    {
        public Parts(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _name;
        [XafDisplayName("Tên Chi Tiết")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        private string _code;
        [XafDisplayName("Mã Chi Tiết")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }

        private ProductionOrder _productionOrder;
        [XafDisplayName("Lệnh Sản Xuất")]
        [Association("ProductionOrder-Part")]
        public ProductionOrder productionOrder
        {
            get => _productionOrder;
            set => SetPropertyValue(nameof(productionOrder), ref _productionOrder, value);
        }

        private int? _amount;
        [XafDisplayName("Số Lượng")]
        public int? amount
        {
            get => _amount;
            set => SetPropertyValue(nameof(amount), ref _amount, value);
        }

        private string _shape;
        [XafDisplayName("Hình Dạng")]
        public string shape
        {
            get => _shape;
            set => SetPropertyValue(nameof(shape), ref _shape, value);
        }

        private string _roughSize;
        [XafDisplayName("Quy Cách Thô")]
        public string roughSize
        {
            get => _roughSize;
            set => SetPropertyValue(nameof(roughSize), ref _roughSize, value);
        }

        private string _standardSize;
        [XafDisplayName("Kích Thước Chuẩn")]
        public string standardSize
        {
            get => _standardSize;
            set => SetPropertyValue(nameof(standardSize), ref _standardSize, value);
        }

        private MaterialMaster _material;
        [XafDisplayName("Vật Liệu")]
        public MaterialMaster material
        {
            get => _material;
            set => SetPropertyValue(nameof(material), ref _material, value);
        }

        private string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }

        [Association("Part-Task")]
        [XafDisplayName("Danh Sách Nguyên Công")]
        public XPCollection<Tasks> tasks => GetCollection<Tasks>(nameof(tasks));
    }
}
