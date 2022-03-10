using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeCursos.Dtos
{
    public class UserCreateDTO
    {
        [Required(ErrorMessage = "Please, insert user username!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please, insert user password!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please, insert user role!")]
        public string Role { get; set; }

    }
}
