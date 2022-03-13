using GerenciadorDeCursos.Dtos;
using GerenciadorDeCursos.Dtos.Incoming;
using GerenciadorDeCursos.Interfaces;
using GerenciadorDeCursos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorDeCursos.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<User>> CreateUser([FromBody] UserCreateDTO userDto)
        {

            Guid id = Guid.NewGuid();


            User user = new()
            {
                Id = id,
                Username = userDto.Username,
                Name = userDto.Name,
                Role = userDto.Role,
                Password = userDto.Password
            };

            var user_created = await _userRepository.CreateUserAsync(user);

            return Created("~api/users/create-user", user_created);
        }

        [HttpGet]
        [Route("show/{id}")]
        public async Task<ActionResult<User>> IndexOneUser(Guid id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            if (user == null)
            {
                return NotFound(new { message = "Usuário não encontrado!" });
            }

            return Ok(user);
        }

        [HttpGet]
        [Route("index")]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            return Ok(await _userRepository.GetAllUsersAsync());
        }


        [HttpPut]
        [Route("update/{id}")]
        public async Task<ActionResult<User>> UpdateUser([FromBody] UserUpdateDTO request, Guid id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            if (user == null)
            {
                return NotFound(new { message = "Usuário não encontrado!" });
            }

            var user_updated = await _userRepository.UpdateUserAsync(user, request);

            return Ok(user_updated);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult> DeleteUser(Guid id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            if (user == null)
            {
                return NotFound(new { message = "Usuário não encontrado!" });
            }

            bool result = await _userRepository.DeleteUserAsync(user);

            return Ok(new { message = "Usuário removido com sucesso!", result });


        }



    }
}
