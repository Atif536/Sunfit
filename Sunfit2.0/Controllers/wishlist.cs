using Microsoft.AspNetCore.Mvc;

namespace Sunfit2._0.Controllers
{
    public class wishlist : Controller
    {
        public IActionResult Index()
        {
            ViewBag.VB = "VB";
            ViewData["test"] = "VD";
            TempData["Data"] = "TD";
            return View();
        }
    }
}
