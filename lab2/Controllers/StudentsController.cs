using Microsoft.AspNetCore.Mvc;
using Models;
namespace Lab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> Students = new List<Student>
        {
            new Student(1, "Andrei", "IOn"),

        };

        [HttpGet]
        public List<Student> GetStudents()
        {
            return Students;
        }

        [HttpPost]
        public List<Student> AddStudent(Student inputStudent)
        {
            Students.Add(inputStudent);
            return Students;
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var studentToDelete = Students.Find(student => student.Id == id);
            if (studentToDelete == null)
                return NotFound();

            Students.Remove(studentToDelete);
            return Ok(Students);
        }

        [HttpGet]
        public List<Student> getAllOredered()
        {
            return Students.OrderBy(s => s.Id).ToList();
        }


    }
}
