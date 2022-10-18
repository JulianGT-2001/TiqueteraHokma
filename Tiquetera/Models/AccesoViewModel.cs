using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace Tiquetera.Models
{
    public class AccesoViewModel
    {
        [Required(ErrorMessage = "Correo requerido")]
        [EmailAddress]
        public string Correo { get; set; }

        [Required(ErrorMessage ="Contraseña requerida")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string contrasena { get; set; }
        [Display(Name = "Recordar datos")]
        public bool RememberMe{ get; set; }


    }
}
