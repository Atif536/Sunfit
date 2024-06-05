using Microsoft.AspNetCore.Mvc;
using Sunfit2._0.Models;
using System.Diagnostics;

namespace Sunfit2._0.Controllers
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
            ViewBag.VB = "VB";
            ViewData["test"] = "VD";
            TempData["Data"] = "TD";
            TempData.Keep();
            return View();
                }

        public IActionResult about()

        {
            ViewBag.VB = "VB";
            ViewData["test"] = "VD";
            TempData["Data"] = "TD";
            TempData.Keep();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}