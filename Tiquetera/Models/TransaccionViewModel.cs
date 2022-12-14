namespace Tiquetera.Models
{
    public class TransaccionViewModel
    {
        public int idTransaccion { get; set; }
        public int idTipoTransaccion { get; set; }
        public int idUsuarioEstablecimiento_U { get; set; }
        public bool estado { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public DateTime fechaMaquinaModifica { get; set; }
        public string maquinaModifica { get; set; }
        public string maquinaCreacion { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }
    }
}
