using Microsoft.AspNetCore.Mvc;

namespace Tiquetera.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult ListarClientes()
        {

            return View();
        }
    }
}
