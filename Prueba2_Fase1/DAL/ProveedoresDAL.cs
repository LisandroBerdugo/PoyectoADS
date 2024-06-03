using MySqlConnector;
using Prueba2_Fase1.EL;
using System;
using System.Collections.Generic;

namespace Prueba2_Fase1.DAL
{
    public class ProveedoresDAL
    {
        private Conexion conexion;

        public ProveedoresDAL()
        {
            conexion = new Conexion();
        }

        public List<ProveedoresEL> ObtenerProveedores()
        {
            List<ProveedoresEL> proveedores = new List<ProveedoresEL>();
            string query = "SELECT ID, Nombre, Telefono FROM Proveedores";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProveedoresEL proveedor = new ProveedoresEL
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Telefono = reader.GetString("Telefono")
                    };
                    proveedores.Add(proveedor);
                }
            }
            return proveedores;
        }

        public void AgregarProveedor(ProveedoresEL proveedor)
        {
            string query = "INSERT INTO Proveedores (Nombre, Telefono) VALUES (@Nombre, @Telefono)";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public ProveedoresEL ObtenerProveedorPorID(int id)
        {
            ProveedoresEL proveedor = null;
            string query = "SELECT ID, Nombre, Telefono FROM Proveedores WHERE ID = @ID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    proveedor = new ProveedoresEL
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Telefono = reader.GetString("Telefono")
                    };
                }
            }
            return proveedor;
        }
    }
}
