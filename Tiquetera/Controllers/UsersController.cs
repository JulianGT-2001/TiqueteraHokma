using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tiquetera.Models;

namespace Tiquetera.Controllers
{
    public class UsersController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UsersController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccesoViewModel modelo)
        {
           
                var resultado = await _signInManager.PasswordSignInAsync(
                modelo.Correo,
                modelo.contrasena,
                modelo.RememberMe,
                lockoutOnFailure: false
                );
                if (resultado.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Acceso Invalido");
                    return View(modelo);
                }
        }

        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegistroViewModel register)
        {
          
                var usuario = new UsuariosViewModel
                {
                    UserName = register.correo,
                    correo = register.correo,
                    primerNombre = register.primerNombre,
                    segundoNombre = register.segundoNombre,
                    primerApellido = register.primerApellido,
                    segundoApellido = register.segundoApellido,
                    tipoId =register.tipoUsuario,
                    numeroDocumento = register.numeroDocumento,
                    PhoneNumber= register.numeroTelefono,
                    direccion = register.direccion,
                    vigente = register.acepta
                };
                var resultado = await _userManager.CreateAsync(usuario, register.contrasena);
                if (resultado.Succeeded)
                {
                    await _signInManager.SignInAsync(usuario, isPersistent: false);
                    return RedirectToAction("Login", "Home");
                }
                ValidarErrores(resultado);
            
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();

        }
        private void ValidarErrores(IdentityResult Resultado)
        {
            foreach(var error in Resultado.Errors)
            {
                ModelState.AddModelError(String.Empty, error.Description);
            }
        }
      
    }
}
