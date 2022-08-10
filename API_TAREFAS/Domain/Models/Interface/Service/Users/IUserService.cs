using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_TAREFAS.Domain.Models.Entity;
using API_TAREFAS.Domain.Models.ViewModels.User;

namespace API_TAREFAS.Domain.Models.Interface.Service.Users
{
    public interface IUserService : IBaseRepository<User>
    {
       
    }
}
