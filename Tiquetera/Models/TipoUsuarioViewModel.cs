namespace Tiquetera.Models
{
    public class TipoUsuarioViewModel
    {
        public int idTipoUsuario { get; set; }
        public int padreId { get; set; }
        public string descripcion { get; set; }
        public bool vigente { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public DateTime fechaMaquinaModifica { get; set; }
        public string maquinaModifica { get; set; }
        public string maquinaCreacion { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }
    }
}
