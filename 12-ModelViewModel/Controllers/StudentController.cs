using _12_ModelViewModel.Models.VMs;
using _12_ModelViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _12_ModelViewModel.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details(int studentId)
        {
            // Öğrenci ve ders bilgilerini veritabanından alın
            var student = GetStudentById(studentId);
            var courses = GetCoursesForStudent(studentId);

            // View Model'i oluşturun
            var viewModel = new StudentDetailsVM
            {
                Student = student,
                Courses = courses
            };

            // View Model'i View'a iletilir
            return View(viewModel);
        }

        private Student GetStudentById(int studentId)
        {
            // Veritabanından öğrenci bilgisi çekme işlemi (örnek olarak, sabit veri kullanıyoruz)
            return new Student
            {
                StudentId = studentId,
                FirstName = "John",
                LastName = "Doe"
            };
        }

        private List<Course> GetCoursesForStudent(int studentId)
        {
            // Veritabanından öğrencinin aldığı dersleri çekme işlemi (örnek olarak, sabit veri kullanıyoruz)
            return new List<Course>
            {
                new Course { CourseId = 1, CourseName = "Mathematics" },
                new Course { CourseId = 2, CourseName = "History" },
                new Course { CourseId = 3, CourseName = "Science" }
            };
        }
    }

}
