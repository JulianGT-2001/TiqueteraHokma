using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace Tiquetera.Models
{
    public class UsuariosViewModel
    {
        public int idTipoDocumento { get; set; }
        public int idTipoUsuario { get; set; }
        public int idContacto { get; set; }
        [Required]
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string numeroDocumento { get; set; }
        [Required(ErrorMessage ="Seleccione un tipo de Usuario")]
        public string tipoId { get; set; }

        [Required]
        public string correo { get; set; }


        [Required]
        public  string direccion { get; set; }

        public DateTime fechaNacimiento { get; set; }
        public bool vigente { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaMaquinaModifica { get; set; }
        public string maquinaModifica { get; set; }
        public string maquinaCreacion { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }

        [Required(ErrorMessage = "La conseña es obligatoria")]
        [DataType(DataType.Password)]
        public string contrasena { get; set; }

        [Required(ErrorMessage = "Confirme la contraseña")]
        [Compare("contrasena", ErrorMessage = "La contraseña no coincide")]
        [DataType(DataType.Password)]
        [Display(Name ="confirmar contraseña")]
        public string confirmarContraseña { get; set; }

        [Required(ErrorMessage ="Ingrese el numero")]
        [StringLength(10,ErrorMessage ="El {0} debe estar entre al menos {10} caracteres",MinimumLength =10)]
        public string numeroCelular { get; set; }


    }
}