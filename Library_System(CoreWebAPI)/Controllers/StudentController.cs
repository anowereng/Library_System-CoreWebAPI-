using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_System_CoreWebAPI.Models;
using Library_System_CoreWebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library_System_CoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository) { _studentRepository = studentRepository; }
        
        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Student model)
        {
            try
            {
                _studentRepository.StudentAdd(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            };

        }

    }
}
