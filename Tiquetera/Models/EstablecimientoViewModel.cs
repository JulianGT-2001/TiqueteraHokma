namespace Tiquetera.Models
{
    public class EstablecimientoViewModel
    {
        public int idEstablecimiento { get; set; }
        public string nombre { get; set; }
        public string nit { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public DateTime fechaMaquinaModifica { get; set; }
        public string maquinaModifica { get; set; }
        public string maquinaCreacion { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }
    }
}
