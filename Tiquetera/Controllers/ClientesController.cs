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

        //Crear Clientes
        [HttpGet]
        public async Task<IActionResult> CrearClientes()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearClientes(CrearClienteViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var user = new UsuariosViewModel 
                { 
                  UserName = usuario.Email,
                  primerNombre = usuario.primerNombre, 
                  segundoNombre = usuario.segundoNombre, 
                  primerApellido = usuario.primerApellido, 
                  segundoApellido = usuario.segundoApellido,
                  numeroDocumento = usuario.numeroDocumento, 
                  direccion = usuario.direccion, 
                  fechaNacimiento = usuario.fechaNacimiento, 
                  numeroCelular = usuario.numeroCelular 
                };
                var resultado = await _userManager.CreateAsync(user, "Seguridad2022..");

                ValidarErrores(resultado);
            }
            return View(usuario);
        }

        private void ValidarErrores(IdentityResult resultado)
        {
            foreach (var error in resultado.Errors)
            {
                ModelState.AddModelError(String.Empty, error.Description);
            }
        }

        //Listar Clientes
        [HttpGet]
        public async Task<IActionResult> ListarClientes()
        {
            var usuarios = await _user.usuariosViewModels.ToListAsync();
            return View(usuarios);
        }

        //Editar Clientes
        [HttpGet]
        public IActionResult EditarClientes(string id)
        {
            var usuariosBD = _user.usuariosViewModels.FirstOrDefault(u => u.Id == id);
            if (usuariosBD == null)
            {
                return NotFound();
            }
            return View(usuariosBD);
        }

        [HttpPost]
        public async Task<IActionResult> EditarClientes(UsuariosViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuariosBD = _user.usuariosViewModels.FirstOrDefault(u => u.Id == usuario.Id);
                if (usuariosBD == null)
                {
                    return NotFound();
                }
                usuariosBD.numeroDocumento = usuario.numeroDocumento;
                usuariosBD.primerNombre = usuario.primerNombre;
                usuariosBD.segundoNombre = usuario.segundoNombre;
                usuariosBD.primerApellido = usuario.primerApellido;
                usuariosBD.segundoApellido = usuario.segundoApellido;
                usuariosBD.numeroDocumento = usuario.numeroDocumento;
                usuariosBD.direccion = usuario.direccion;
                usuariosBD.fechaNacimiento = usuario.fechaNacimiento;
                usuariosBD.numeroCelular = usuario.numeroCelular;
                _user.SaveChanges();
                return RedirectToAction(nameof(ListarClientes));
            }
            return View(usuario);
        }

        //Eliminar Clientes
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EliminarClientes(string idUsuario)
        {
            var usuarioBD = _user.usuariosViewModels.FirstOrDefault(u => u.Id == idUsuario);
            
            if (usuarioBD == null)
            {
                return NotFound();
            }

            _user.usuariosViewModels.Remove(usuarioBD);
            _user.SaveChanges();
            return RedirectToAction(nameof(ListarClientes));
        }
    }
}
