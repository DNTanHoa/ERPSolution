using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERPSolution.Model.Models;
using ERPSolution.MVC.Models.ProductionModels;
using ERPSolution.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace ERPSolution.MVC.Controllers
{
    public class ProductionOrderController : Controller
    {
        private readonly ERPSolutionContext _context;
        private ProductionOrderService productionOrderService;

        public ProductionOrderController(ERPSolutionContext context)
        {
            this._context = context;
            productionOrderService = new ProductionOrderService(_context); 
        }

        public async Task<IActionResult> Index()
        {
            var model = new ProductionModel();
            model.productionOrders = await productionOrderService.GetAll();
            return View("ProductionOrderView",model);
        }

        public ActionResult ShowDetailView()
        {
            var model = new ProductionModel();
            return View("ProductionOrderDetailView", model);
        }
    }
}