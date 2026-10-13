using Microsoft.AspNetCore.Mvc;
using wt_lab4_4mvc_liger.Models;

namespace wt_lab4_4mvc_liger.Controllers
{
    public class StudentController : Controller
    {
        private static readonly List<Student> Students = new()
    {
        new Student
        {
            Id = 1,
            FullName = "Лигер Валерия Валерьевна",
            Faculty = "УИР",
            Course = 4,
            AverageGrade = 9.7,
            IsEnrolled = true
        },
        new Student
        {
            Id = 2,
            FullName = "Ясковец Александра Дмитриевна",
            Faculty = "УИР",
            Course = 4,
            AverageGrade = 10,
            IsEnrolled = true
        },
        new Student
        {
            Id = 3,
            FullName = "Сидоров Пётр Алексеевич",
            Faculty = "ГУП",
            Course = 3,
            AverageGrade = 5.7,
            IsEnrolled = false
        },
        new Student
        {
            Id = 4,
            FullName = "Кузнецова Мария Дмитриевна",
            Faculty = "ГУП",
            Course = 4,
            AverageGrade = 4.9,
            IsEnrolled = true
        },
        new Student
        {
            Id = 5,
            FullName = "Смирнов Алексей Викторович",
            Faculty = "ГУЭ",
            Course = 1,
            AverageGrade = 8.9,
            IsEnrolled = true
        }
    };

        // GET: /Student/Index
        public IActionResult Index()
        {
            return View(Students);
        }

        // GET: /Student/Details/1
        public IActionResult Details(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: /Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Student/Create
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            student.Id = Students.Any() ? Students.Max(s => s.Id) + 1 : 1;
            Students.Add(student);

            return RedirectToAction("Index");
        }

        // POST: /Student/Delete/1
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            Students.Remove(student);

            return RedirectToAction("Index");
        }

    }
}
