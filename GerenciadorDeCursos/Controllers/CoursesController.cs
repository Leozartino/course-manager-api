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

        //Quais usuarios podem consultar por ID?
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

        //Quais usuarios podem criar um curso?
        //Quais usuarios podem atualizar dados de um curso além do status?
    }
}
