using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Tiquetera.Models
{
    public class AppUsuario : IdentityUser
    {
        public int? idTipoDocumento { get; set; }
        public int? idTipoUsuario { get; set; }
        [Display (Name = "Primer Nombre")]
        public string? primerNombre { get; set; }
        [Display(Name = "Segundo Nombre")]
        public string? segundoNombre { get; set; }
        [Display(Name = "Primer Apellido")]
        public string? primerApellido { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string? segundoApellido { get; set; }
        [Display(Name = "Numero de documento")]
        public string? numeroDocumento { get; set; }
        [Display(Name = "Direccion")]
        public string? direccion { get; set; }
        [Display(Name = "Fecha de Nacimento")]
        public DateTime? fechaNacimiento { get; set; }
        public bool? vigente { get; set; }
        public DateTime? fechaCreacion { get; set; }
        public DateTime? fechaMaquinaModifica { get; set; }
        public string? maquinaModifica { get; set; }
        public string? maquinaCreacion { get; set; }
        public string? usuarioCrea { get; set; }
        public string? usuarioModifica { get; set; }
        public string? contrasena { get; set; }
        public string? confirmarContraseña { get; set; }
        [Display(Name = "Numero de celular")]
        public string? numeroCelular { get; set; }
    }
}
