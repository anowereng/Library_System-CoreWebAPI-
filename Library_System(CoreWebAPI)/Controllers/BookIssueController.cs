using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_System_CoreWebAPI.Interfaces;
using Library_System_CoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library_System_CoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookIssueController : ControllerBase
    {
        private IBookIssueService _bookIssueService;

        public BookIssueController(IBookIssueService service) { _bookIssueService = service; }

        [HttpPost]
        public ActionResult Post([FromBody] IssueBook model)
        {
            try
            {
                _bookIssueService.BookIssue(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            };
            
        }
    }
}
