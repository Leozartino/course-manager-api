using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeCursos.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
