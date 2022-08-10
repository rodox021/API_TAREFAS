using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TAREFAS.Domain.Models.ViewModels.User
{
    public class VMUser
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; } = true;

        private DateTime? _createAt;
        public DateTime? CreatAt
        {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }

        public DateTime? UpdateAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long ProfileId { get; set; }

    }
}
