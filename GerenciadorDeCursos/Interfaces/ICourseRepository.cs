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
        Task<Course> CreateCourseAsync(Course course);
        Task<bool> DeleteCourseAsync(Course course);
    }
}
