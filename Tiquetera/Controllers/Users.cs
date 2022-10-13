using Microsoft.AspNetCore.Mvc;

namespace Tiquetera.Controllers
{
    public class Users : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult RegisterUser()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
