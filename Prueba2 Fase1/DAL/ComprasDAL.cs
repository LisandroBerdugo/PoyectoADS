using MySqlConnector;
using PEDUDB;
using Prueba2_Fase1.EL;
using System;
using System.Collections.Generic;
using System.Data;

namespace Prueba2_Fase1.DAL
{
    public class ComprasDAL
    {
        private Conexion conexion;

        public ComprasDAL()
        {
            conexion = new Conexion();
        }

        public List<ComprasEL> ObtenerCompras()
        {
            List<ComprasEL> compras = new List<ComprasEL>();
            string query = @"
                SELECT c.ID, c.UsuarioID, c.FechaCompra, c.Activo, c.ProveedorID, p.Nombre AS ProveedorNombre, p.Telefono AS ProveedorTelefono
                FROM Compras c
                JOIN Proveedores p ON c.ProveedorID = p.ID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ComprasEL compra = new ComprasEL
                    {
                        ID = reader.GetInt32("ID"),
                        UsuarioID = reader.GetInt32("UsuarioID"),
                        FechaCompra = reader.GetDateTime("FechaCompra"),
                        Activo = reader.GetBoolean("Activo"),
                        ProveedorID = reader.GetInt32("ProveedorID"),
                        ProveedorNombre = reader.GetString("ProveedorNombre"),
                        ProveedorTelefono = reader.GetString("ProveedorTelefono"),
                        Detalles = ObtenerDetallesCompra(reader.GetInt32("ID"))
                    };
                    compras.Add(compra);
                }
            }
            return compras;
        }

        public List<ComprasEL> ObtenerComprasFiltradas(DateTime fechaInicio, DateTime fechaFin, string filtro)
        {
            List<ComprasEL> compras = new List<ComprasEL>();
            string query = @"
                SELECT c.ID, c.UsuarioID, c.FechaCompra, c.Activo, c.ProveedorID, p.Nombre AS ProveedorNombre, p.Telefono AS ProveedorTelefono
                FROM Compras c
                JOIN Proveedores p ON c.ProveedorID = p.ID
                WHERE c.FechaCompra BETWEEN @FechaInicio AND @FechaFin";

            if (!string.IsNullOrEmpty(filtro))
            {
                query += " AND (p.Nombre LIKE @Filtro OR c.ID LIKE @Filtro)";
            }

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin.ToString("yyyy-MM-dd 23:59:59"));

                if (!string.IsNullOrEmpty(filtro))
                {
                    cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                }

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ComprasEL compra = new ComprasEL
                    {
                        ID = reader.GetInt32("ID"),
                        UsuarioID = reader.GetInt32("UsuarioID"),
                        FechaCompra = reader.GetDateTime("FechaCompra"),
                        Activo = reader.GetBoolean("Activo"),
                        ProveedorID = reader.GetInt32("ProveedorID"),
                        ProveedorNombre = reader.GetString("ProveedorNombre"),
                        ProveedorTelefono = reader.GetString("ProveedorTelefono"),
                        Detalles = ObtenerDetallesCompra(reader.GetInt32("ID"))
                    };
                    compras.Add(compra);
                }
            }
            return compras;
        }

        public ComprasEL ObtenerCompraPorID(int id)
        {
            ComprasEL compra = null;
            string query = @"
                SELECT c.ID, c.UsuarioID, c.FechaCompra, c.Activo, c.ProveedorID, p.Nombre AS ProveedorNombre, p.Telefono AS ProveedorTelefono
                FROM Compras c
                JOIN Proveedores p ON c.ProveedorID = p.ID
                WHERE c.ID = @ID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    compra = new ComprasEL
                    {
                        ID = reader.GetInt32("ID"),
                        UsuarioID = reader.GetInt32("UsuarioID"),
                        FechaCompra = reader.GetDateTime("FechaCompra"),
                        Activo = reader.GetBoolean("Activo"),
                        ProveedorID = reader.GetInt32("ProveedorID"),
                        ProveedorNombre = reader.GetString("ProveedorNombre"),
                        ProveedorTelefono = reader.GetString("ProveedorTelefono"),
                        Detalles = ObtenerDetallesCompra(reader.GetInt32("ID"))
                    };
                }
            }
            return compra;
        }

        private List<DetalleCompraEL> ObtenerDetallesCompra(int compraID)
        {
            List<DetalleCompraEL> detalles = new List<DetalleCompraEL>();
            string query = @"
                SELECT dc.ProductoID, p.Nombre AS ProductoNombre, dc.Cantidad, dc.PrecioCompra
                FROM DetalleCompras dc
                JOIN Productos p ON dc.ProductoID = p.ID
                WHERE dc.CompraID = @CompraID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CompraID", compraID);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DetalleCompraEL detalle = new DetalleCompraEL
                    {
                        ProductoID = reader.GetInt32("ProductoID"),
                        ProductoNombre = reader.GetString("ProductoNombre"),
                        Cantidad = reader.GetInt32("Cantidad"),
                        PrecioCompra = reader.GetDecimal("PrecioCompra")
                    };
                    detalles.Add(detalle);
                }
            }
            return detalles;
        }

        public int InsertarCompra(ComprasEL compra)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Compras (ProveedorID, UsuarioID, Activo) VALUES (@ProveedorID, @UsuarioID, @Activo); SELECT LAST_INSERT_ID();", conn);
                cmd.Parameters.AddWithValue("@ProveedorID", compra.ProveedorID);
                cmd.Parameters.AddWithValue("@UsuarioID", compra.UsuarioID);
                cmd.Parameters.AddWithValue("@Activo", compra.Activo);
                int compraID = Convert.ToInt32(cmd.ExecuteScalar());

                foreach (var detalle in compra.Detalles)
                {
                    detalle.CompraID = compraID;
                    InsertarDetalleCompra(detalle);
                }

                return compraID;
            }
        }

        public void InsertarDetalleCompra(DetalleCompraEL detalleCompra)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO DetalleCompras (CompraID, ProductoID, Cantidad, PrecioCompra) VALUES (@CompraID, @ProductoID, @Cantidad, @PrecioCompra)", conn);
                cmd.Parameters.AddWithValue("@CompraID", detalleCompra.CompraID);
                cmd.Parameters.AddWithValue("@ProductoID", detalleCompra.ProductoID);
                cmd.Parameters.AddWithValue("@Cantidad", detalleCompra.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioCompra", detalleCompra.PrecioCompra);
                cmd.ExecuteNonQuery();

                // Actualizar el inventario
                ActualizarInventario(detalleCompra.ProductoID, detalleCompra.Cantidad, "COMPRA");
            }
        }

        private void ActualizarInventario(int productoID, int cantidad, string tipoMovimiento)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Almacenamiento (ProductoID, Cantidad, TipoMovimiento) VALUES (@ProductoID, @Cantidad, @TipoMovimiento)", conn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                cmd.Parameters.AddWithValue("@Cantidad", tipoMovimiento == "COMPRA" ? cantidad : -cantidad); // Asegúrate de que la cantidad es correcta
                cmd.Parameters.AddWithValue("@TipoMovimiento", tipoMovimiento);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
