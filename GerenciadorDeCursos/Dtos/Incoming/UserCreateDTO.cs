using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeCursos.Dtos
{
    public class UserCreateDTO
    {
        [Required(ErrorMessage = "Por favor, insira o campo: username!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Por favor, insira o campo: password!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Por favor, insira o campo: name!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Por favor, insira o campo: role!")]
        public string Role { get; set; }

    }
}
