using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeCursos.Dtos.Incoming
{
    public class CourseUpdateDTO
    {
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
    }
}
