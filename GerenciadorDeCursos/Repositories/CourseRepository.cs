using GerenciadorDeCursos.Data;
using GerenciadorDeCursos.Dtos.Outgoing;
using GerenciadorDeCursos.Enums;
using GerenciadorDeCursos.Interfaces;
using GerenciadorDeCursos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeCursos.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _appDbContext;

        public CourseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public async Task<Course> CreateCourseAsync(Course course)
        {
            _appDbContext.Courses.Add(course);
            await _appDbContext.SaveChangesAsync();
            return course;
        }

        public async Task<Course> UpdateCourseStatusAsync(Course course, StatusCourseEnum statusCourse)
        {
            course.Status = statusCourse;

            await _appDbContext.SaveChangesAsync();

            return course;
        }


        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            var courses = await _appDbContext.Courses.ToListAsync();

            return courses;

        }

        public async Task<Course> GetCourseByIdAsync(Guid id)
        {
            var course = await _appDbContext.Courses.FindAsync(id);
            return course;
        }

        public IEnumerable<Course> GetCourseByStatus(StatusCourseEnum status)
        {
            var courses = _appDbContext.Courses.Where((Course course) => course.Status == status);
            return courses;
        }

        public async Task<bool> DeleteCourseAsync(Course course)
        {
            _appDbContext.Courses.Remove(course);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
    }
}
