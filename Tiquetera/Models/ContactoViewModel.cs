namespace Tiquetera.Models
{
    public class ContactoViewModel
    {
        public int idContacto { get; set; }
        public int idTipoContacto { get; set; }
        public string dato { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public DateTime fechaMaquinaModificacion { get; set; }
        public string maquinaModifica { get; set; }
        public string maquinaCreacion { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }
    }
}
