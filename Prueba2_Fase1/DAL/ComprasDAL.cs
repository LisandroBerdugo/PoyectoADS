using MySqlConnector;
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

            try
            {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener compras: " + ex.Message);
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

            try
            {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener compra por ID: " + ex.Message);
            }

            return compra;
        }

        public List<ComprasEL> ObtenerComprasFiltradas(DateTime fechaInicio, DateTime fechaFin, string filtro)
        {
            List<ComprasEL> compras = new List<ComprasEL>();
            string query = @"
                SELECT c.ID, c.UsuarioID, c.FechaCompra, c.Activo, c.ProveedorID, p.Nombre AS ProveedorNombre, p.Telefono AS ProveedorTelefono
                FROM Compras c
                JOIN Proveedores p ON c.ProveedorID = p.ID
                WHERE c.FechaCompra BETWEEN @FechaInicio AND @FechaFin
                AND (
                    p.Nombre LIKE @Filtro OR
                    c.ID LIKE @Filtro OR
                    EXISTS (
                        SELECT 1
                        FROM DetalleCompras dc
                        JOIN MateriaPrima mp ON dc.ItemID = mp.ID
                        WHERE dc.CompraID = c.ID
                        AND dc.TipoItem = 'Materia Prima'
                        AND (mp.Nombre LIKE @Filtro OR mp.ID LIKE @Filtro)
                    )
                )";

            try
            {
                using (MySqlConnection conn = conexion.Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                    cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener compras filtradas: " + ex.Message);
            }

            return compras;
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
                MySqlCommand cmd = new MySqlCommand("INSERT INTO DetalleCompras (CompraID, ItemID, Cantidad, PrecioCompra, TipoItem) VALUES (@CompraID, @ItemID, @Cantidad, @PrecioCompra, @TipoItem)", conn);
                cmd.Parameters.AddWithValue("@CompraID", detalleCompra.CompraID);
                cmd.Parameters.AddWithValue("@ItemID", detalleCompra.ItemID);
                cmd.Parameters.AddWithValue("@Cantidad", detalleCompra.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioCompra", detalleCompra.PrecioCompra);
                cmd.Parameters.AddWithValue("@TipoItem", detalleCompra.TipoItem);
                cmd.ExecuteNonQuery();

                // Actualizar el inventario
                ActualizarInventario(detalleCompra.ItemID, detalleCompra.Cantidad, detalleCompra.TipoItem, "COMPRA");
            }
        }

        private void ActualizarInventario(int itemID, int cantidad, string tipoItem, string tipoMovimiento)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                string query = tipoItem == "Producto" ?
                    "INSERT INTO Almacenamiento (ProductoID, Cantidad, TipoMovimiento) VALUES (@ItemID, @Cantidad, @TipoMovimiento)" :
                    "INSERT INTO Almacenamiento (MateriaPrimaID, Cantidad, TipoMovimiento) VALUES (@ItemID, @Cantidad, @TipoMovimiento)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemID", itemID);
                cmd.Parameters.AddWithValue("@Cantidad", tipoMovimiento == "COMPRA" ? cantidad : -cantidad); // Asegúrate de que la cantidad es correcta
                cmd.Parameters.AddWithValue("@TipoMovimiento", tipoMovimiento);
                cmd.ExecuteNonQuery();
            }
        }

        private List<DetalleCompraEL> ObtenerDetallesCompra(int compraID)
        {
            List<DetalleCompraEL> detalles = new List<DetalleCompraEL>();
            string query = @"
                SELECT dc.ItemID, mp.Nombre AS ItemNombre, dc.Cantidad, dc.PrecioCompra, dc.TipoItem
                FROM DetalleCompras dc
                JOIN MateriaPrima mp ON dc.ItemID = mp.ID
                WHERE dc.CompraID = @CompraID
                AND dc.TipoItem = 'Materia Prima'";

            try
            {
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
                            ItemID = reader.GetInt32("ItemID"),
                            ItemNombre = reader.GetString("ItemNombre"),
                            Cantidad = reader.GetInt32("Cantidad"),
                            PrecioCompra = reader.GetDecimal("PrecioCompra"),
                            TipoItem = reader.GetString("TipoItem")
                        };
                        detalles.Add(detalle);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener detalles de compra: " + ex.Message);
            }

            return detalles;
        }
    }
}
