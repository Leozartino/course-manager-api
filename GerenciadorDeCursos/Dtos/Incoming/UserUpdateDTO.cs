using GerenciadorDeCursos.Enums;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeCursos.Dtos.Incoming
{
    public class UserUpdateDTO
    {   
        [Required(ErrorMessage = "Por favor, insira o campo: name!")]        
        public string Name { get; set; }
        [Required(ErrorMessage = "Por favor, insira o campo: role!")]
        public UserRoleEnum Role { get; set; }
    }
}
