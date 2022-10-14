using Microsoft.AspNetCore.Mvc;
using Tiquetera.Models;

namespace Tiquetera.Controllers
{
    public class CuentasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Registro()
        {
            RegistroViewModel registroViewModel = new RegistroViewModel();
            return View(registroViewModel);
        }
    }
}
