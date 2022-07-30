using Microsoft.AspNetCore.Mvc;

namespace ADHD.Controllers
{
    public class ConsultantController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
