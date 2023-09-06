using Microsoft.AspNetCore.Mvc;

namespace webApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult MachineProblem()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
