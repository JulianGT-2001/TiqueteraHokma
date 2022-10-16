using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Tiquetera.Datos;
using Tiquetera.Models;
using Microsoft.EntityFrameworkCore;

namespace Tiquetera.Controllers
{
    public class ClientesController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly AplicationBaseDatos _user;
        public ClientesController(UserManager<IdentityUser> userManager, AplicationBaseDatos user)
        {
            _userManager = userManager;
            _user = user;
        }

        //Listar Clientes
        [HttpGet]
        public async Task<IActionResult> ListarClientes()
        {
            var usuarios = await _user.listuser.ToListAsync();

            return View(usuarios);
        }

        //Editar Clientes
        [HttpGet]
        public IActionResult EditarClientes(string id)
        {
            var usuariosBD = _user.listuser.ToList();
            if (usuariosBD == null)
            {
                return NotFound();
            }
            return View(usuariosBD);
        }

        //Eliminar Clientes
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EliminarClientes(string idUsuario)
        {
            var usuarioBD = _user.listuser.FirstOrDefault(u => u.Id == idUsuario);
            
            if (usuarioBD == null)
            {
                return NotFound();
            }

            _user.listuser.Remove(usuarioBD);
            _user.SaveChanges();
            return RedirectToAction(nameof(ListarClientes));
        }
    }
}
