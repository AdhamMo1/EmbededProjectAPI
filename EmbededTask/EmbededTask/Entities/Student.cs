using System.ComponentModel.DataAnnotations;

namespace EmbededTask.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Grade { get; set; }
        public string RFIDTag_Id { get; set; }
    }
}
