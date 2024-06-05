using System.Collections.Generic;

namespace Prueba2_Fase1.EL
{
    public class ProductosEL
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public List<MateriaPrimaNecesariaEL> MateriaPrimaNecesaria { get; set; }
    }

    public class MateriaPrimaNecesariaEL
    {
        public int MateriaPrimaID { get; set; }
        public string MateriaPrimaNombre { get; set; }
        public int Cantidad { get; set; }
    }
}
