using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebDevChallenge.Models;

namespace WebDevChallenge.Controllers
{
    public class HomeController : Controller
    {
        
        private DanceApplicationContext _context;

        public  HomeController(DanceApplicationContext temp)
        {
            _context = temp;
        }
        
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Application response)
        {
            _context.Applications.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
