namespace Prueba2_Fase1.EL
{
    public class VentasEL
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaVenta { get; set; }
        public string ClienteNombre { get; set; } // Nueva propiedad
        public string ClienteApellido { get; set; } // Nueva propiedad
        public List<DetalleVentaEL> Detalles { get; set; }
    }
}
