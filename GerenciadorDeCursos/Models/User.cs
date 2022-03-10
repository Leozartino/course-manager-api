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
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }
    }
}
