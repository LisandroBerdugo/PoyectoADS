using MySqlConnector;
using Prueba2_Fase1.EL;
using System;
using System.Collections.Generic;
using PEDUDB;

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
            string query = "SELECT ID, Nombre, Apellido, Email, Telefono, Direccion, FechaRegistro FROM Clientes";

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
                        Direccion = reader.GetString("Direccion"),
                        FechaRegistro = reader.GetDateTime("FechaRegistro")
                    };
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }

        public ClientesEL ObtenerClientePorID(int id)
        {
            ClientesEL cliente = null;
            string query = "SELECT ID, Nombre, Apellido, Email, Telefono, Direccion, FechaRegistro FROM Clientes WHERE ID = @ID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cliente = new ClientesEL
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Email = reader.GetString("Email"),
                        Telefono = reader.GetString("Telefono"),
                        Direccion = reader.GetString("Direccion"),
                        FechaRegistro = reader.GetDateTime("FechaRegistro")
                    };
                }
            }
            return cliente;
        }

        public void AgregarCliente(ClientesEL cliente)
        {
            string query = "INSERT INTO Clientes (Nombre, Apellido, Email, Telefono, Direccion, FechaRegistro) VALUES (@Nombre, @Apellido, @Email, @Telefono, @Direccion, @FechaRegistro)";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarCliente(ClientesEL cliente)
        {
            string query = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Telefono = @Telefono, Direccion = @Direccion WHERE ID = @ID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", cliente.ID);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCliente(int id)
        {
            string query = "DELETE FROM Clientes WHERE ID = @ID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
