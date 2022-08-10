using API_TAREFAS.Domain.Models.Interface.Service.Authentication;
using API_TAREFAS.Domain.Models.Interface.Service.Users;
using API_TAREFAS.Domain.Models.ViewModels.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TAREFAS.Controllers
{
    //[Route("api/v1/[controller]")]
    [Route("api/v1/usuario")]

    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _service;
        private readonly IAuthenticationService _authentication;

        public LoginController(ILoginService service, IAuthenticationService authentication)
        {
            _service = service;
            _authentication = authentication;
        }

        /// <summary>
        /// Este serviço autentica o usuário ativo e cadastrado.
        /// </summary>
        /// <param name="login"></param>
        /// <returns>Retorna Status OK, dados do usuário e o token.</returns> 
        [SwaggerResponse(statusCode: 200, description:"Sucesso so autenticar", typeof(VMUserLogin) )]
        [SwaggerResponse(statusCode: 400, description:"Campos Obrigatório" )]
        [SwaggerResponse(statusCode: 500, description:"Erro Interno"  )]
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> GetLogin(VMUserLogin login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _service.GetLogin(login);
            if (user == null)
            {
                return BadRequest("Login ou senha inválidos");
            }

            var token = _authentication.GetToken(user);

            VMUser userOut = new VMUser()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                IsActive = user.IsActive,
                CreatAt = user.CreatAt,
                UpdateAt = user.UpdateAt,
                DeletedAt = user.DeletedAt,
                ProfileId = user.ProfileId

            };

            return Ok(new { 
                Token = token,
                User = userOut
                
            });
        }
    }
}
