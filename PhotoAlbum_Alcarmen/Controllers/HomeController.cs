using Microsoft.AspNetCore.Mvc;
using PhotoAlbum_Alcarmen.Models;
using System.Diagnostics;

namespace PhotoAlbum_Alcarmen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult BallZ()
        {
            return View();
        }
        public IActionResult Bleach()
        {
            return View();
        }
        public IActionResult BokunoHero()
        {
            return View();
        }
        public IActionResult BorutoDad()
        {
            return View();
        }
        public IActionResult OnePiece()
        {
            return View();
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
