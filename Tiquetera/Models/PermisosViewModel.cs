namespace Tiquetera.Models
{
    public class PermisosViewModel
    {
        public int idPermisos { get; set; }
        public string descripcion { get; set; }
        public string url { get; set; }
        public string urlImagen { get; set; }
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
