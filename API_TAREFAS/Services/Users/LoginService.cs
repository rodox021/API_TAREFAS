using API_TAREFAS.Domain.Models.Entity;
using API_TAREFAS.Domain.Models.Interface.Service.Users;
using API_TAREFAS.Domain.Models.ViewModels.User;
using API_TAREFAS.Infra.Data.Context;
using API_TAREFAS.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TAREFAS.Services.Users
{
    public class LoginService : BaseRepository<User>, ILoginService
    {
        private readonly AppDbContext _context;

        public LoginService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetLogin(VMUserLogin userLogin)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email.Equals(userLogin.Email) && u.Password.Equals(userLogin.Password));
        }
    }
}
