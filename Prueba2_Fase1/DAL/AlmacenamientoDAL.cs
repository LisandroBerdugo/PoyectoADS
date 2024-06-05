using System;
using System.Collections.Generic;
using MySqlConnector;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1.DAL
{
    public class AlmacenamientoDAL
    {
        private Conexion conexion;

        public AlmacenamientoDAL()
        {
            conexion = new Conexion();
        }

        public List<AlmacenamientoEL> ObtenerMovimientosDeTipo(string tipoMovimiento)
        {
            List<AlmacenamientoEL> movimientos = new List<AlmacenamientoEL>();

            using (MySqlConnection con = conexion.Conectar())
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT a.ID, p.Nombre AS ProductoNombre, a.FechaMovimiento, a.Cantidad " +
                                                    "FROM Almacenamiento a " +
                                                    "LEFT JOIN Productos p ON a.ProductoID = p.ID " +
                                                    "WHERE a.TipoMovimiento = @TipoMovimiento AND a.ProductoID IS NOT NULL", con);
                cmd.Parameters.AddWithValue("@TipoMovimiento", tipoMovimiento);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AlmacenamientoEL movimiento = new AlmacenamientoEL
                    {
                        ID = reader.GetInt32("ID"),
                        ProductoNombre = reader.IsDBNull(reader.GetOrdinal("ProductoNombre")) ? null : reader.GetString("ProductoNombre"),
                        FechaMovimiento = reader.GetDateTime("FechaMovimiento"),
                        Cantidad = reader.GetInt32("Cantidad")
                    };
                    movimientos.Add(movimiento);
                }
                con.Close();
            }

            return movimientos;
        }

        public void RegistrarMovimientoAlmacenamiento(int? productoID, int? materiaPrimaID, int cantidad, string tipoMovimiento)
        {
            using (MySqlConnection con = conexion.Conectar())
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Almacenamiento (ProductoID, MateriaPrimaID, Cantidad, TipoMovimiento, FechaMovimiento) " +
                                                    "VALUES (@ProductoID, @MateriaPrimaID, @Cantidad, @TipoMovimiento, @FechaMovimiento)", con);
                cmd.Parameters.AddWithValue("@ProductoID", (object)productoID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MateriaPrimaID", (object)materiaPrimaID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@TipoMovimiento", tipoMovimiento);
                cmd.Parameters.AddWithValue("@FechaMovimiento", DateTime.Now);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
