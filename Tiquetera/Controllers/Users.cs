using Microsoft.AspNetCore.Mvc;

namespace Tiquetera.Controllers
{
    public class Users : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
