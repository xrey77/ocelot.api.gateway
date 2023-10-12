using Microsoft.AspNetCore.Mvc;

namespace StudentAdmissionManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentAdmission: ControllerBase {

        [HttpGet(Name="StudentAdmission")]
        public IActionResult index() {
            return Ok(new {message = "Student Admission"});
        }

    }
    
}