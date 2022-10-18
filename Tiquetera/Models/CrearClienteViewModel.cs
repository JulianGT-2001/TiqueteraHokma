using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Tiquetera.Models
{
    public class CrearClienteViewModel
    {
        [Required(ErrorMessage = "Los nombres y apellidos son requeridos")]
        
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        [Required(ErrorMessage = "El correo electronico es requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El numero de documento es requerido")]
        public string numeroDocumento { get; set; }

        [Display(Name = "Direccion")]
        public string? direccion { get; set; }

        [Display(Name = "Fecha de Nacimento")]
        public DateTime? fechaNacimiento { get; set; }

        [Required]
        [Display(Name = "Numero de telefono")]
        public string numeroCelular { get; set; }
    }
}
