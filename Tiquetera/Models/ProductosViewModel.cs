namespace Tiquetera.Models
{
    public class ProductosViewModel
    {
        public int idProductos { get; set; }
        public string descripcion { get; set; }
        public string urlImagen { get; set; }
        public double valor { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaCreacion  { get; set; }
        public DateTime fechaModificacion  { get; set; }
        public DateTime fechaMaquinaModifica { get; set; }
        public string maquinaModifica { get; set; }
        public string maquinaCreacion { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }
    }
}
