using GerenciadorDeCursos.Enums;
using System;

namespace GerenciadorDeCursos.Dtos
{
    public class CourseCreateDTO
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusCourseEnum Status { get; set; }
    }
}
