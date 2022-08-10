using API_TAREFAS.Domain.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_TAREFAS.Domain.Models.Entity
{
    public class User : IBaseEntity
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;


        private DateTime? _createAt;
        public DateTime? CreatAt
        {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }

        public DateTime? UpdateAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        //RelationShip --------------------------------------------------------

        //Profile
        public long ProfileId { get; set; }
        public Profile Profile { get; set; }



    }
}
