using Microsoft.AspNetCore.Mvc;

namespace Tiquetera.Controllers
{
    public class Sucursales : Controller
    {
        public IActionResult ListarSucursales()
        {
            return View();
        }
    }
}
