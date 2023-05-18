using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HSPA_TEST.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] Studentnames = new string[] { "Ashish", "Aditya", "Manas" };

            return Ok(Studentnames);

        }
    }
}
