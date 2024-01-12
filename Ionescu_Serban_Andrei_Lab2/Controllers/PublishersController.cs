using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ionescu_Serban_Andrei_Lab2.Controllers
{
    [Authorize(Policy = "OnlySales")]
    public class PublishersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
