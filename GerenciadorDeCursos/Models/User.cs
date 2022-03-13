using GerenciadorDeCursos.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeCursos.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public UserRoleEnum Role { get; set; }
    }
}
