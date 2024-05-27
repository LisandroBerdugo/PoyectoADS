using MySqlConnector;
using PEDUDB;
using Prueba2_Fase1.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Prueba2_Fase1.DAL
{
    public class UsuariosDAL
    {
        private Conexion conexion;

        public UsuariosDAL()
        {
            conexion = new Conexion();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string query = @"
        SELECT u.ID, u.Nombre, u.Email, u.Contraseña, u.Activo, u.FechaRegistro, u.ID_Rol, r.Nombre AS RolNombre 
        FROM Usuarios u
        JOIN Roles r ON u.ID_Rol = r.ID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Email = reader.GetString("Email"),
                        Contraseña = reader.GetString("Contraseña"),
                        Activo = reader.GetBoolean("Activo"),
                        FechaRegistro = reader.GetDateTime("FechaRegistro"),
                        RolID = reader.GetInt32("ID_Rol"),
                        RolNombre = reader.GetString("RolNombre") // Nuevo campo para el nombre del rol
                    };
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }


        public List<Rol> ObtenerRoles()
        {
            List<Rol> roles = new List<Rol>();
            string query = "SELECT ID, Nombre, Descripcion FROM Roles";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Rol rol = new Rol
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Descripcion = reader.GetString("Descripcion")
                    };
                    roles.Add(rol);
                }
            }
            return roles;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            string query = "INSERT INTO Usuarios (Nombre, Email, Contraseña, Activo, FechaRegistro, ID_Rol) VALUES (@Nombre, @Email, @Contraseña, @Activo, @FechaRegistro, @ID_Rol)";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                cmd.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);
                cmd.Parameters.AddWithValue("@ID_Rol", usuario.RolID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            string query = "UPDATE Usuarios SET Nombre = @Nombre, Email = @Email, Contraseña = @Contraseña, Activo = @Activo, ID_Rol = @ID_Rol WHERE ID = @ID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", usuario.ID);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                cmd.Parameters.AddWithValue("@ID_Rol", usuario.RolID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
