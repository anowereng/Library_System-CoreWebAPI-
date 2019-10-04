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
    public class BookController : ControllerBase
    {
        private IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository) { _bookRepository = bookRepository; }

        [HttpPost]
        public ActionResult Post([FromBody] Book model)
        {
            try
            {
                _bookRepository.BookAdd(model);
                _bookRepository.SaveChange();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            };
        }
    }
}
