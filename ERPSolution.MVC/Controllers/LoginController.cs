using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERPSolution.Model.Models;
using ERPSolution.MVC.Models.AccountModels;
using ERPSolution.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace ERPSolution.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly ERPSolutionContext _context;
        private UserService userService;

        public LoginController(ERPSolutionContext context)
        {
            this._context = context;
            userService = new UserService(_context);
        }

        public IActionResult Index()
        {
            return View("LoginView");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                bool isValidUser = await userService.IsValidUser(model.username, model.password);
                if (isValidUser)
                    return RedirectToAction("Index","Admin");
                else
                    ModelState.AddModelError("", "Tên Đăng Nhập Hoặc Mật Khẩu Không Tồn Tại");
            }
            else
            {
                ModelState.AddModelError("", "Tên Đăng Nhập Hoặc Mật Khẩu Không Hợp Lệ");
            }
            return View("LoginView");
        }
    }
}