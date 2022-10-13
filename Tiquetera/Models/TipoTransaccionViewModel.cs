namespace Tiquetera.Models
{
    public class TipoTransaccionViewModel
    {
        public int idTipoTransaccion { get; set; }
        public int idPagos { get; set; }
        public int padreId { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public DateTime fechaMaquinaModifica { get; set; }
        public string maquinaModifica { get; set; }
        public string maquinaCreacion { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }
    }
}
