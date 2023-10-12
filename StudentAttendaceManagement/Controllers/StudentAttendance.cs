using Microsoft.AspNetCore.Mvc;

namespace StudentAttendaceManagement.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentAttendance: ControllerBase {

    [HttpGet(Name="StudentAttendance")]
    public IActionResult index() {
        return Ok(new {message = "Student Attendance"});
    }
}