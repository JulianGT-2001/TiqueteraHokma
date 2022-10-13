namespace Tiquetera.Models
{
    public class SucursalesViewModel
    {
        public int idSucursales { get; set; }
        public int idEstablecimiento { get; set; }
        public string direccion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public DateTime fechaMaquinaModifica { get; set; }
        public string maquinaModifica { get; set; }
        public string maquinaCreacion { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }
    }
}
