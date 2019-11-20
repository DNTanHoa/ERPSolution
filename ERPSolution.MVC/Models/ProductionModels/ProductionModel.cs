using ERPSolution.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPSolution.MVC.Models.ProductionModels
{
    public class ProductionModel
    {
        public IList<ProductionOrder> productionOrders { get; set; }
    }
}
