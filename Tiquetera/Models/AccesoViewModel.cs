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
        [StringLength(50,ErrorMessage ="el {0} debe estar entre {2} caracteres de longitud", MinimumLength = 5)]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string contraseña { get; set; }
        [Display(Name = "Recordar datos")]
        public bool RememberMe{ get; set; }


    }
}
