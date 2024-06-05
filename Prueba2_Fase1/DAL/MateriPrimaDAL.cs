using MySqlConnector;
using Prueba2_Fase1.EL;
using System.Collections.Generic;

namespace Prueba2_Fase1.DAL
{
    public class MateriaPrimaDAL
    {
        private Conexion conexion;

        public MateriaPrimaDAL()
        {
            conexion = new Conexion();
        }

        public List<MateriaPrima> ObtenerTodas()
        {
            List<MateriaPrima> materiasPrimas = new List<MateriaPrima>();

            using (MySqlConnection con = conexion.Conectar())
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM MateriaPrima", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MateriaPrima materiaPrima = new MateriaPrima()
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Descripcion = reader.GetString("Descripcion"),
                        Precio = reader.GetDecimal("Precio")
                    };
                    materiasPrimas.Add(materiaPrima);
                }
                con.Close();
            }

            return materiasPrimas;
        }

        public MateriaPrima ObtenerMateriaPrimaPorID(int id)
        {
            MateriaPrima materiaPrima = null;

            using (MySqlConnection con = conexion.Conectar())
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM MateriaPrima WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    materiaPrima = new MateriaPrima()
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Descripcion = reader.GetString("Descripcion"),
                        Precio = reader.GetDecimal("Precio")
                    };
                }
                con.Close();
            }

            return materiaPrima;
        }

        public int ObtenerCantidadMateriaPrima(int materiaPrimaID)
        {
            int cantidadTotal = 0;

            using (MySqlConnection con = conexion.Conectar())
            {
                con.Open();

                // Obtener total de entradas (COMPRA)
                MySqlCommand cmdEntrada = new MySqlCommand(
                    "SELECT SUM(Cantidad) FROM Almacenamiento WHERE MateriaPrimaID = @MateriaPrimaID AND TipoMovimiento = 'COMPRA'",
                    con);
                cmdEntrada.Parameters.AddWithValue("@MateriaPrimaID", materiaPrimaID);
                int totalEntradas = cmdEntrada.ExecuteScalar() != DBNull.Value ? Convert.ToInt32(cmdEntrada.ExecuteScalar()) : 0;

                // Obtener total de salidas (USO)
                MySqlCommand cmdSalida = new MySqlCommand(
                    "SELECT SUM(Cantidad) FROM Almacenamiento WHERE MateriaPrimaID = @MateriaPrimaID AND TipoMovimiento = 'USO'",
                    con);
                cmdSalida.Parameters.AddWithValue("@MateriaPrimaID", materiaPrimaID);
                int totalSalidas = cmdSalida.ExecuteScalar() != DBNull.Value ? Convert.ToInt32(cmdSalida.ExecuteScalar()) : 0;

                cantidadTotal = totalEntradas - totalSalidas;

                con.Close();
            }

            return cantidadTotal;
        }
    }
}
