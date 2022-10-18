using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace Tiquetera.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "Correo requerido")]
        [EmailAddress]
        public string correo { get; set; }

        [Required(ErrorMessage ="Contraseña requerida")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string contrasena { get; set; }

        [Required(ErrorMessage = "Confirmacion de contraseña requerida")]
        [Compare("contrasena", ErrorMessage ="la contraseña no coincide") ]
        [Display(Name = "Confirmar  Contraseña")]
        [DataType(DataType.Password)]
        public string confirmarContrasena { get; set; }

        [Required (ErrorMessage = "Los nombres y apellidos son requeridos")]
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }


        public string tipoUsuario { get; set; }

        public string numeroDocumento { get; set; }

        [Display(Name ="telefono requerido")]
        public string numeroTelefono { get; set; }

        public string direccion { get; set; }
        public DateTime fechaNachimiento { get; set; }

        public bool acepta { get; set; }
    }
}
