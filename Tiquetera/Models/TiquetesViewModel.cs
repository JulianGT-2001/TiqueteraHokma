namespace Tiquetera.Models
{
    public class TiquetesViewModel
    {
        public int idTiquetes { get; set; }
        public int idTransaccion { get; set; }
        public int cantidad { get; set; }
        public int estado { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public DateTime fechaMaquinaModificacion { get; set; }
        public string maquinaModifica { get; set; }
        public string maquinaCreacion { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }
    }
}
