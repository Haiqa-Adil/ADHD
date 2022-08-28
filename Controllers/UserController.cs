using Microsoft.AspNetCore.Mvc;

namespace ADHD.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
