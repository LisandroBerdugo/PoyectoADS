using MySqlConnector;
using PEDUDB;
using Prueba2_Fase1.EL;
using System.Collections.Generic;

namespace Prueba2_Fase1.DAL
{
    public class InventarioDAL
    {
        private Conexion conexion;

        public InventarioDAL()
        {
            conexion = new Conexion();
        }

        public List<InventarioEL> ObtenerInventario()
        {
            List<InventarioEL> inventario = new List<InventarioEL>();
            string query = @"
                SELECT p.ID, p.Nombre, COALESCE(SUM(a.Cantidad), 0) AS Cantidad
                FROM Productos p
                LEFT JOIN Almacenamiento a ON p.ID = a.ProductoID
                GROUP BY p.ID, p.Nombre";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    InventarioEL item = new InventarioEL
                    {
                        ProductoID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Cantidad = reader.GetInt32("Cantidad")
                    };
                    inventario.Add(item);
                }
            }
            return inventario;
        }
    }
}
