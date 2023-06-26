using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Data;
using StudentApp.Models;
using System.Diagnostics;

namespace StudentApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Authorize]
        public IActionResult ImportStudent()
        {
            return View();
        }

        public IActionResult Students()
        {
            return View();
        }

        [HttpPost]
        public JsonResult getData(string IdNo)
        {
            int.TryParse(IdNo, out var studentId);
            var data = _context.Students.Where(c=>c.IDNo == studentId).FirstOrDefault();
             
            return Json(data);
        }
    }
}