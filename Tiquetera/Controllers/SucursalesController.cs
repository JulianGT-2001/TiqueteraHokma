using Microsoft.AspNetCore.Mvc;

namespace Tiquetera.Controllers
{
    public class SucursalesController : Controller
    {
        public IActionResult ListarSucursales()
        {
            return View();
        }
    }
}
