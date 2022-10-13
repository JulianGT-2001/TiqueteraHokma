namespace Tiquetera.Models
{
    public class UsuariosViewModel
    {
        public int idUsuarios { get; set; }
        public int idTipoDocumento { get; set; }
        public int idTipoUsuario { get; set; }
        public int idContacto { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string numeroDocumento { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaMaquinaModifica { get; set; }
        public string maquinaModifica { get; set; }
        public string maquinaCreacion { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }
    }
}