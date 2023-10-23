using Microsoft.EntityFrameworkCore;
using Ionescu_Serban_Andrei_Lab2.Models;
using Ionescu_Serban_Andrei_Lab2.Data;
using Ionescu_Serban_Andrei_Lab2.Models.LibraryViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ionescu_Serban_Andrei_Lab2.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}