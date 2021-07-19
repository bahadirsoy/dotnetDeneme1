using DotnetDeneme1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetDeneme1.Controllers
{
    public class CourseController: Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if(ModelState.IsValid){
                Repository.addStudent(student);
                return View("Thanks", student);
            } else{
                return View(student);
            }
            
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details()
        {
            var course = new Course();

            course.name = "Kurs";
            course.description = "zaman kaybı kursu";
            course.isPublished = true;

            return View(course);
        }
    }
}