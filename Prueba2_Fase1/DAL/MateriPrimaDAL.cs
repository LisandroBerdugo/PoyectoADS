using MySqlConnector;
using Prueba2_Fase1.EL;
using System;
using System.Collections.Generic;
using System.Data;

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

        public void Insertar(MateriaPrima materiaPrima)
        {
            using (MySqlConnection con = conexion.Conectar())
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO MateriaPrima (Nombre, Descripcion, Precio) VALUES (@Nombre, @Descripcion, @Precio)", con);
                cmd.Parameters.AddWithValue("@Nombre", materiaPrima.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", materiaPrima.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", materiaPrima.Precio);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
