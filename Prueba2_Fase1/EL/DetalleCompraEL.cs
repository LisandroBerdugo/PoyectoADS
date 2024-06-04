namespace Prueba2_Fase1.EL
{
    public class DetalleCompraEL
    {
        public int ID { get; set; }
        public int CompraID { get; set; }
        public int ItemID { get; set; }
        public string ItemNombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public string TipoItem { get; set; }
    }
}
