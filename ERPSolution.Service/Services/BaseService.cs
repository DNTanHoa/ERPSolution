using ERPSolution.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ERPSolution.Service.Services
{
    public class BaseService
    {
        public ERPSolutionContext _context;

        public BaseService(ERPSolutionContext context)
        {
            this._context = context;
        }
    }
}
