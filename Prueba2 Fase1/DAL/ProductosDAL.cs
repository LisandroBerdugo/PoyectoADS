using MySqlConnector;
using PEDUDB;
using Prueba2_Fase1.EL;
using System;
using System.Collections.Generic;
using System.Data;

namespace Prueba2_Fase1.DAL
{
    public class ProductosDAL
    {
        private Conexion conexion;

        public ProductosDAL()
        {
            conexion = new Conexion();
        }

        public List<ProductosEL> ObtenerTodosLosProductos()
        {
            List<ProductosEL> productos = new List<ProductosEL>();
            string query = "SELECT ID, Nombre, Descripcion, Precio FROM Productos";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProductosEL producto = new ProductosEL
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Descripcion = reader.GetString("Descripcion"),
                        Precio = reader.GetDecimal("Precio")
                    };
                    productos.Add(producto);
                }
            }
            return productos;
        }

        public ProductosEL ObtenerProductoPorID(int id)
        {
            ProductosEL producto = null;
            string query = "SELECT ID, Nombre, Descripcion, Precio FROM Productos WHERE ID = @ID";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    producto = new ProductosEL
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Descripcion = reader.GetString("Descripcion"),
                        Precio = reader.GetDecimal("Precio")
                    };
                }
            }
            return producto;
        }

        public void AgregarProducto(ProductosEL producto)
        {
            string query = "INSERT INTO Productos (Nombre, Descripcion, Precio) VALUES (@Nombre, @Descripcion, @Precio)";

            using (MySqlConnection conn = conexion.Conectar())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
