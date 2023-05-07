using Layout.Models;
using Layout.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace Layout.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Student> _students;
        private readonly List<Group> _groups;

        public HomeController(){
            Student student1 = new Student();
            student1.Name = "Shams";
            student1.Surname = "Shirali";
            student1.Age= 19;
            student1.Id= 1;

            Student student2 = new Student();
            student2.Name = "Safa";
            student2.Surname = "Hacizade";
            student2.Age = 19;
            student2.Id= 2;

            Student student3 = new Student();
            student3.Name = "Zehra";
            student3.Surname = "Shirali";
            student3.Age = 17;
            student3.Id= 3;

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            _students=students;

            List<Group> groups = new List<Group>()
            {
                new Group {No="P138",Count=16},
                new Group {No="P133",Count=15},
                new Group {No="P238",Count=18}
            };

            _groups=groups;
        }

        public IActionResult Index()
        {
            //Student student1 = new Student();
            //student1.Name = "Shams";
            //student1.Surname = "Shirali";
            //student1.Age= 19;
            //student1.Id= 1;

            //Student student2 = new Student();
            //student2.Name = "Safa";
            //student2.Surname = "Hacizade";
            //student2.Age = 19;
            //student2.Id= 2;

            //Student student3 = new Student();
            //student3.Name = "Zehra";
            //student3.Surname = "Shirali";
            //student3.Age = 17;
            //student3.Id= 3;

            //List<Student> students = new List<Student>();
            //students.Add(student1);
            //students.Add(student2);
            //students.Add(student3);

            //List<Group> groups = new List<Group>()
            //{
            //    new Group {No="P138",Count=16},
            //    new Group {No="P133",Count=15},
            //    new Group {No="P238",Count=18}
            //};

            HomeVM homeVM = new HomeVM()
            {
                Students = _students,
                Groups = _groups
            };

            return View(homeVM);

            //ViewData["Name"] = "Shams";

            //ViewBag.Age = 19;

            //TempData["Experience"] = 20;

            //return RedirectToAction(nameof(Detail));
        }

        public IActionResult Detail(int? id,string name)
        {
        if (id == null) return BadRequest();

        Student student = _students.Find(x => x.Id == id);

        if (student == null) return NotFound();

            return View(student);
        }
    }
}
