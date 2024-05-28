using MySqlConnector;
using PEDUDB;
using Prueba2_Fase1.EL;
using System.Collections.Generic;

namespace Prueba2_Fase1.DAL
{
    public class ClientesDAL
    {
        private Conexion conexion;

        public ClientesDAL()
        {
            conexion = new Conexion();
        }

        public List<ClientesEL> ObtenerClientes()
        {
            List<ClientesEL> clientes = new List<ClientesEL>();
            string query = "SELECT ID, Nombre, Apellido, Email, Telefono, Direccion FROM Clientes";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ClientesEL cliente = new ClientesEL
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Email = reader.GetString("Email"),
                        Telefono = reader.GetString("Telefono"),
                        Direccion = reader.GetString("Direccion")
                    };
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }
    }
}
