using GerenciadorDeCursos.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeCursos.Dtos
{
    public class CourseCreateDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public StatusCourseEnum Status { get; set; }
    }
}
