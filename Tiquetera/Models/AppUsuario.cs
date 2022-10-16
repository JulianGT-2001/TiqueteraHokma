using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Tiquetera.Models
{
    public class AppUsuario : IdentityUser
    {
        public int? idTipoDocumento { get; set; }
        public int? idTipoUsuario { get; set; }
        public string? primerNombre { get; set; }
        public string? segundoNombre { get; set; }
        public string?   primerApellido { get; set; }
        public string? segundoApellido { get; set; }
        public string? numeroDocumento { get; set; }
        public string? direccion { get; set; }

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
        public string? numeroCelular { get; set; }
    }
}
