using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_TAREFAS.Domain.Models.ViewModels.User
{
    public class VMUserLogin
    {
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public string Email { get; set; }


        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public string Password { get; set; }
    }
}
