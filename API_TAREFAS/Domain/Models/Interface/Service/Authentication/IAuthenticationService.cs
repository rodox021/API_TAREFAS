using API_TAREFAS.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TAREFAS.Domain.Models.Interface.Service.Authentication
{
   public interface IAuthenticationService
    {
        string GetToken(User user);
    }
}
