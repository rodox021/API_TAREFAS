using API_TAREFAS.Domain.Models.Entity;
using API_TAREFAS.Domain.Models.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TAREFAS.Domain.Models.Interface.Service.Users
{
    public interface ILoginService : IBaseRepository<User>
    {
        Task<User> GetLogin(VMUserLogin userLogin);
    }
}
