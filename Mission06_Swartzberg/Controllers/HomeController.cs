using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Swartzberg.Models;

namespace Mission06_Swartzberg.Controllers
{
    public class HomeController : Controller
    {
        private FilmCollectionContext _context;
        public HomeController(FilmCollectionContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(Movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirm", response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
