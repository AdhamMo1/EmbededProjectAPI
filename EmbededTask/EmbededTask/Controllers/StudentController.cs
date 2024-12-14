using EmbededTask.Data;
using EmbededTask.DTO;
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

        public static List<Student>? listOfStudent = new List<Student>();

        [HttpGet("GetStudent")]
        public async Task<IActionResult> GetStudent()
        {
            var student = new Student();
            try
            {
                student = await _context.Students.FirstOrDefaultAsync(prop => prop.RFIDTag_Id == Subscriber.TagId);
                if(student == null)
                {
                    return NotFound(new ApiResponse() { Message = "Student Not found..", Students = listOfStudent });
                }
                if (listOfStudent is not null)
                {
                    foreach (var item in listOfStudent)
                    {
                        if (item.RFIDTag_Id == Subscriber.TagId)
                        {
                            Subscriber.TagId = string.Empty;
                            return Ok(new ApiResponse() { Message = "Done Successfully!", Students = listOfStudent });
                        }
                    }
                }
                Subscriber.TagId = string.Empty;
                listOfStudent.Add(student);
            } 
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse() { Message = "Internal server error..", Students = listOfStudent });
            }
            return Ok(new ApiResponse() { Message = "Done Successfully!", Students = listOfStudent });
        }
        [HttpDelete("DeleteStudents")]
        public IActionResult deleteStudents()
        {
            listOfStudent = new List<Student>();
            return Ok(new ApiResponse() { Message = "Delete Done.", Students = listOfStudent });
        }
    }
}
