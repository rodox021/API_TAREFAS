using API_TAREFAS.Domain.Models.Interface;
using API_TAREFAS.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TAREFAS.Infra.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity, new()
    {
        private readonly AppDbContext _context;
        private DbSet<T> _dataset;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        //******************************************************//


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dataset.ToListAsync();
        }
    }
}
