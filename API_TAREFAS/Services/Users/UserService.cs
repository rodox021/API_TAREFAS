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
    public class UserService : BaseRepository<User>, IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context) : base(context)
        {
        }

        
    }
}
