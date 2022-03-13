using GerenciadorDeCursos.Dtos.Incoming;
using GerenciadorDeCursos.Enums;
using GerenciadorDeCursos.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorDeCursos.Interfaces
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<Course> GetCourseByIdAsync(Guid id);
        IEnumerable<Course> GetCourseByStatus(StatusCourseEnum status);
        Task<Course> CreateCourseAsync(Course course);
        Task<Course> UpdateCourseAsync(Course course, CourseUpdateDTO courseUpdate);
        Task<Course> UpdateCourseStatusAsync(Course course, StatusCourseEnum statusCourse);
        Task<Course> UpdateCourseTitleAsync(Course course, string title);
        Task<bool> DeleteCourseAsync(Course course);
    }
}
