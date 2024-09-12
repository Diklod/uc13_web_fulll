using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using uc13_web_full.Models;

namespace uc13_web_full.Controllers
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

        public IActionResult Products()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetPageName()
        {
            return new JsonResult(new { success = true, result = "Produtos" });
        }
    }
}