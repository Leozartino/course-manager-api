using GerenciadorDeCursos.Dtos;
using GerenciadorDeCursos.Interfaces;
using GerenciadorDeCursos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorDeCursos.Controllers
{   
    [Authorize]
    [Route("api/courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseReposiotry)
        {
            _courseRepository = courseReposiotry;

        }

        [AllowAnonymous]
        [HttpGet]
        [Route("index")]
        public async Task<ActionResult<IEnumerable<Course>>> IndexCourses()
        {
            var courses = await _courseRepository.GetAllCoursesAsync();
            return Ok(courses);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("show/search/{status}")]
        public ActionResult<Course> ShowCourseByStatus(string status)
        {
            var courses = _courseRepository.GetCourseByStatus(status);

            if (courses == null)
            {
                return NotFound(new { message = "curso não pode ser encontrado!" });
            }

            return Ok(courses);

        }

        [AllowAnonymous]
        [HttpGet]
        [Route("show/{id}")]
        public async Task<ActionResult<Course>> ShowCourse(Guid id)
        {
            var course = await _courseRepository.GetCourseByIdAsync(id);

            if(course == null)
            {
                return NotFound(new { message = "curso não pode ser encontrado!" });
            }

            return Ok(course);

        }

        //Quais usuarios podem criar um curso? Gerente e Secretario
        [HttpPost]
        [Route("post")]
        public async Task<ActionResult<Course>> CreateCourse(CourseCreateDTO courseDTO)
        {

            Guid id = Guid.NewGuid();

            Course course = new()
            {
                Id = id,
                Title = courseDTO.Title,
                StartDate = courseDTO.StartDate,
                EndDate = courseDTO.EndDate,
                Status = courseDTO.Status,
                
            };

            var course_created = await _courseRepository.CreateCourseAsync(course);
            // var days = (courseDTO.EndDate - courseDTO.StartDate).Days;

            return Created("~api/courses/post", course_created);
        }

        //Quais usuarios podem atualizar dados de um curso além do status?
    }
}
