using ERPSolution.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Service.Services
{
    public class ProductionOrderService : BaseService
    {
        public ProductionOrderService(ERPSolutionContext context) : base(context) { }

        public async Task<IList<ProductionOrder>> GetAll()
        {
            return await this._context.ProductionOrder.ToListAsync();
        }

        public async Task<bool> InsertOne(ProductionOrder item)
        {
            this._context.ProductionOrder.Add(item);
            return await this._context.SaveChangesAsync() != 0? true : false;
        }
    }
}
