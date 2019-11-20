using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERPSolution.MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View("AdminHomeView");
        }
    }
}