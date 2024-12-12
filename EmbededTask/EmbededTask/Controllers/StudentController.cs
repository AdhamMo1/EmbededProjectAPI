using EmbededTask.Data;
using EmbededTask.Entities;
using EmbededTask.MQTT_Subscriber;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmbededTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetStudent")]
        public async Task<IActionResult> GetStudent()
        {
            var student = new Student();
            try
            {   
                student = await _context.Students.FirstOrDefaultAsync(prop => prop.RFIDTag_Id == Subscriber.TagId);
                if(student == null)
                {
                    return NotFound("Student Not found..");
                }
                Subscriber.TagId = string.Empty;
            } 
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(student);
        }
    }
}
