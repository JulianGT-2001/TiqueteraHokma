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
        public string Correo { get; set; }

        [Required(ErrorMessage ="Contraseña requerida")]
        [StringLength(50,ErrorMessage ="el {0} debe estar entre {2} caracteres de longitud", MinimumLength = 5)]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string contrasena { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        [Compare("contrasena", ErrorMessage ="la contraseña no coincide") ]
        [Display(Name = "Confirmar  Contraseña")]
        [DataType(DataType.Password)]
        public string ConfirmarContrasena { get; set; }

        [Required]
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        
        [Required]
        public string numeroDocumento { get; set; }

        [Required]
        [Display(Name ="telefono requerido")]
        public string numeroTelefono { get; set; }
    }
}
