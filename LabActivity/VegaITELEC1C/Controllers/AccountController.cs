using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VegaITELEC1C.ViewModels;

namespace VegaITELEC1C.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        public AccountController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(loginInfo.Username , loginInfo.Password , loginInfo.RememberMe, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Instructor");

            }
            else
            {
                ModelState.AddModelError("", "Failed to Login");
            }
            return View(loginInfo); 
        }
        public async Task<IActionResult> Logout()
        {

        }
    }
}
