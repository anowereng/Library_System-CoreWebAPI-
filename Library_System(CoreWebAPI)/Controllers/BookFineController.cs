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
    public class BookFineController : ControllerBase
    {
        private IBookFineService _bookFineService;

        public BookFineController(IBookFineService bookFineService) { _bookFineService = bookFineService; }

        [HttpPost]
        public ActionResult Post([FromBody] Student model)
        {
            try
            {
                _bookFineService.ReceiveFineAmount(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<double> Get(int id)
        {
            try
            {
               var finamount= _bookFineService.GetFineAmount(id);
                return Ok(finamount);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            };
        }
    }
}
