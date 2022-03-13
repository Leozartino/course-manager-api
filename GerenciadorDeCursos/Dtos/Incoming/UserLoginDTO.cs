using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeCursos.Dtos.Incoming
{
    public class UserLoginDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
