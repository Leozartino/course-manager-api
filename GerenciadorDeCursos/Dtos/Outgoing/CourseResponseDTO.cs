using GerenciadorDeCursos.Enums;
using GerenciadorDeCursos.Models;
using System;
using System.Collections.Generic;

namespace GerenciadorDeCursos.Dtos.Outgoing
{
    public class CourseResponseDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DurationDays { get; set; }
        public StatusCourseEnum Status { get; set; }
    }
}
