using MySqlConnector;
using Prueba2_Fase1.EL;
using System;
using System.Collections.Generic;

namespace Prueba2_Fase1.DAL
{
    public class VentasDAL
    {
        private Conexion conexion;

        public VentasDAL()
        {
            conexion = new Conexion();
        }

        public int InsertarVenta(VentasEL venta)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Ventas (ClienteID, UsuarioID) VALUES (@ClienteID, @UsuarioID); SELECT LAST_INSERT_ID();", conn);
                cmd.Parameters.AddWithValue("@ClienteID", venta.ClienteID);
                cmd.Parameters.AddWithValue("@UsuarioID", venta.UsuarioID);
                int ventaID = Convert.ToInt32(cmd.ExecuteScalar());

                foreach (var detalle in venta.Detalles)
                {
                    detalle.VentaID = ventaID;
                    InsertarDetalleVenta(detalle);
                }

                return ventaID;
            }
        }

        public void InsertarDetalleVenta(DetalleVentaEL detalleVenta)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO DetalleVentas (VentaID, ProductoID, Cantidad, PrecioVenta) VALUES (@VentaID, @ProductoID, @Cantidad, @PrecioVenta)", conn);
                cmd.Parameters.AddWithValue("@VentaID", detalleVenta.VentaID);
                cmd.Parameters.AddWithValue("@ProductoID", detalleVenta.ProductoID);
                cmd.Parameters.AddWithValue("@Cantidad", detalleVenta.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioVenta", detalleVenta.PrecioVenta);
                cmd.ExecuteNonQuery();

                // Actualizar el inventario
                ActualizarInventario(detalleVenta.ProductoID, detalleVenta.Cantidad, "VENTA");
            }
        }

        private void ActualizarInventario(int productoID, int cantidad, string tipoMovimiento)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Almacenamiento (ProductoID, Cantidad, TipoMovimiento) VALUES (@ProductoID, @Cantidad, @TipoMovimiento)", conn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad * -1); // Para ventas, la cantidad es negativa
                cmd.Parameters.AddWithValue("@TipoMovimiento", tipoMovimiento);
                cmd.ExecuteNonQuery();
            }
        }

        public List<VentasEL> ObtenerVentas()
        {
            List<VentasEL> ventas = new List<VentasEL>();
            string query = @"
                SELECT v.ID, v.ClienteID, v.UsuarioID, v.FechaVenta, c.Nombre AS ClienteNombre, c.Apellido AS ClienteApellido
                FROM Ventas v
                JOIN Clientes c ON v.ClienteID = c.ID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    VentasEL venta = new VentasEL
                    {
                        ID = reader.GetInt32("ID"),
                        ClienteID = reader.GetInt32("ClienteID"),
                        UsuarioID = reader.GetInt32("UsuarioID"),
                        FechaVenta = reader.GetDateTime("FechaVenta"),
                        ClienteNombre = reader.GetString("ClienteNombre"),
                        ClienteApellido = reader.GetString("ClienteApellido"),
                        Detalles = ObtenerDetallesVenta(reader.GetInt32("ID"))
                    };
                    ventas.Add(venta);
                }
            }
            return ventas;
        }

        public VentasEL ObtenerVentaPorID(int id)
        {
            VentasEL venta = null;
            string query = @"
                SELECT v.ID, v.ClienteID, v.UsuarioID, v.FechaVenta, c.Nombre AS ClienteNombre, c.Apellido AS ClienteApellido
                FROM Ventas v
                JOIN Clientes c ON v.ClienteID = c.ID
                WHERE v.ID = @ID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    venta = new VentasEL
                    {
                        ID = reader.GetInt32("ID"),
                        ClienteID = reader.GetInt32("ClienteID"),
                        UsuarioID = reader.GetInt32("UsuarioID"),
                        FechaVenta = reader.GetDateTime("FechaVenta"),
                        ClienteNombre = reader.GetString("ClienteNombre"),
                        ClienteApellido = reader.GetString("ClienteApellido"),
                        Detalles = ObtenerDetallesVenta(reader.GetInt32("ID"))
                    };
                }
            }
            return venta;
        }

        private List<DetalleVentaEL> ObtenerDetallesVenta(int ventaID)
        {
            List<DetalleVentaEL> detalles = new List<DetalleVentaEL>();
            string query = @"
                SELECT dv.ProductoID, p.Nombre AS ProductoNombre, dv.Cantidad, dv.PrecioVenta
                FROM DetalleVentas dv
                JOIN Productos p ON dv.ProductoID = p.ID
                WHERE dv.VentaID = @VentaID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VentaID", ventaID);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DetalleVentaEL detalle = new DetalleVentaEL
                    {
                        ProductoID = reader.GetInt32("ProductoID"),
                        ProductoNombre = reader.GetString("ProductoNombre"),
                        Cantidad = reader.GetInt32("Cantidad"),
                        PrecioVenta = reader.GetDecimal("PrecioVenta")
                    };
                    detalles.Add(detalle);
                }
            }
            return detalles;
        }

        // Método para actualizar una venta existente
        public bool ActualizarVenta(VentasEL venta)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Ventas SET ClienteID = @ClienteID, UsuarioID = @UsuarioID WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", venta.ID);
                cmd.Parameters.AddWithValue("@ClienteID", venta.ClienteID);
                cmd.Parameters.AddWithValue("@UsuarioID", venta.UsuarioID);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    // Primero, eliminar los detalles antiguos
                    EliminarDetallesVenta(venta.ID);

                    // Luego, insertar los nuevos detalles
                    foreach (var detalle in venta.Detalles)
                    {
                        detalle.VentaID = venta.ID;
                        InsertarDetalleVenta(detalle);
                    }
                    return true;
                }
                return false;
            }
        }

        // Método para eliminar detalles de una venta específica
        private void EliminarDetallesVenta(int ventaID)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM DetalleVentas WHERE VentaID = @VentaID", conn);
                cmd.Parameters.AddWithValue("@VentaID", ventaID);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar una venta
        public bool EliminarVenta(int id)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                // Primero, eliminar los detalles de la venta
                EliminarDetallesVenta(id);

                // Luego, eliminar la venta
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Ventas WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
