using API_TAREFAS.Domain.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_TAREFAS.Domain.Models.Entity
{
    public class Profile : IBaseEntity
    {
        [Key ]
        public long Id { get ; set ; }
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
