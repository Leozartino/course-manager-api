using GerenciadorDeCursos.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeCursos.Models
{
    public class Course
    {
        [Key]
        public Guid Id  { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate {get; set; }
        [Required]
        public StatusCourseEnum Status { get; set; }
    }
}
