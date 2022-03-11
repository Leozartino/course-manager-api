using GerenciadorDeCursos.Data;
using GerenciadorDeCursos.Dtos;
using GerenciadorDeCursos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GerenciadorDeCursos.Controllers
{
    [Authorize]
    [Route("api/users")]
    [ApiController]
    public class UsersController : Controller
    {

        private readonly AppDbContext _appDbContext;

        public UsersController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<User>> CreateUser([FromBody] UserCreateDTO userCreateDTO)
        {
            return View();
        }
    }
}
