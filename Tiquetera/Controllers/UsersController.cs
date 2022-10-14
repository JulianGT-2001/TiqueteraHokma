using Microsoft.AspNetCore.Mvc;
using Tiquetera.Models;

namespace Tiquetera.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UsuariosViewModel modelo)
        {

            return View();
        }

        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser(UsuariosViewModel register)
        {
            if (register.tipoId != "1"|| register.tipoId  != "2")
            {
                return RedirectToAction("Error");
            }
            else
            {
                return View();
            }
            
            
        }
        public IActionResult ForgotPassword()
        {
            return View();

        }

       
    }
}
