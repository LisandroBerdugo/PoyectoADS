using MySqlConnector;
using PEDUDB;
using Prueba2_Fase1.EL;
using System;
using System.Collections.Generic;

namespace Prueba2_Fase1.DAL
{/*
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
    }*/
}
