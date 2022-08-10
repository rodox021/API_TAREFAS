using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TAREFAS.Domain.Models.Interface
{
    public interface IBaseRepository<T> where T: IBaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
