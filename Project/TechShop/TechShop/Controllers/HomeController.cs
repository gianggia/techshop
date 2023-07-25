using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechShop.Models;

namespace TechShop.Controllers
{
    public class HomeController : Controller
    {
        List<Student> students;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            students = new List<Student>()
            {
                new Student(1,"anne",17),
                new Student(2,"mbappe",13),
                new Student(3,"cr7",20),
                new Student(4, "cong phuong",19),
                new Student(5,"haaland",13),
                new Student(6,"dafoe",20),
                new Student(7, "DA",19),
                new Student(8,"killin",13),
                new Student(9,"gohan",20),
                new Student(10, "Poc",19),
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View(students);
        }
        public IActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);           
            return View(student);
        }
        public IActionResult GetNumberStudent(int take,int skip)
        {
            var ls = students.Skip(skip).Take(take).ToList();
            return View(ls);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}