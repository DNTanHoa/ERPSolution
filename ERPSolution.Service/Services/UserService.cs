using ERPSolution.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Service.Services
{
    public class UserService : BaseService
    {
        public UserService(ERPSolutionContext context) : base(context) { }
        
        public async Task<List<User>> GetAllUser()
        {
            return await this._context.User.ToListAsync();
        }

        public async Task<bool> IsValidUser(string username, string password)
        {
            User user = await _context.User.FirstOrDefaultAsync<User>(item =>
                                             item.Username.Equals(username) &&
                                             item.Password.Equals(password) &&
                                             (bool)item.IsActive);
            return user != null? true : false; 
        }
    }
}
