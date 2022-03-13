using GerenciadorDeCursos.Dtos.Incoming;
using GerenciadorDeCursos.Interfaces;
using GerenciadorDeCursos.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GerenciadorDeCursos.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private readonly IAccountService _accountService;

        public AuthController(IUserRepository userRepository, ITokenService tokenService, IAccountService accountService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
            _accountService = accountService;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<string> LoginUser(UserLoginDTO userLogin)
        {
            User user = _userRepository.GetUserByUsername(userLogin.Username);

            if (user == null)
            {
                return NotFound(new { message = "Usário não encontrado!" });
            }

            if (!(_accountService.VerifyPassword(userLogin.Password, user.Password)))
            {
                return BadRequest(new { message = "Username e/ou password estão incorretas!" });
            }

            var token = _tokenService.GenerateToken(user);

            return Ok(token);

        }
    }
}
