namespace Prueba2_Fase1.EL
{
    public class ComprasEL
    {
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaCompra { get; set; }
        public bool Activo { get; set; }
        public int ProveedorID { get; set; }
        public string ProveedorNombre { get; set; }
        public string ProveedorTelefono { get; set; } // Nueva propiedad
        public List<DetalleCompraEL> Detalles { get; set; }
    }
}
