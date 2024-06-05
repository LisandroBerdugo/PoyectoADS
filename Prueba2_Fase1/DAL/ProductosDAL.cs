using MySqlConnector;
using Prueba2_Fase1.EL;
using System;
using System.Collections.Generic;

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

            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                string query = "SELECT * FROM Productos";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProductosEL producto = new ProductosEL
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Descripcion = reader.GetString("Descripcion"),
                        Precio = reader.GetDecimal("Precio"),
                        MateriaPrimaNecesaria = ObtenerMateriasPrimasPorProducto(reader.GetInt32("ID"))
                    };
                    productos.Add(producto);
                }
            }
            return productos;
        }

        public ProductosEL ObtenerProductoPorID(int id)
        {
            ProductosEL producto = null;

            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                string query = "SELECT * FROM Productos WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    producto = new ProductosEL
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("Nombre"),
                        Descripcion = reader.GetString("Descripcion"),
                        Precio = reader.GetDecimal("Precio"),
                        MateriaPrimaNecesaria = ObtenerMateriasPrimasPorProducto(reader.GetInt32("ID"))
                    };
                }
            }
            return producto;
        }

        public void AgregarProducto(ProductosEL producto)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                string query = "INSERT INTO Productos (Nombre, Descripcion, Precio) VALUES (@Nombre, @Descripcion, @Precio)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.ExecuteNonQuery();
                producto.ID = (int)cmd.LastInsertedId;

                foreach (var materiaPrima in producto.MateriaPrimaNecesaria)
                {
                    AgregarMateriaPrimaAlProducto(producto.ID, materiaPrima);
                }
            }
        }

        public void EditarProducto(ProductosEL producto)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                string query = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@ID", producto.ID);
                cmd.ExecuteNonQuery();

                // Eliminar materias primas existentes y agregar las nuevas
                EliminarMateriasPrimasDelProducto(producto.ID);
                foreach (var materiaPrima in producto.MateriaPrimaNecesaria)
                {
                    AgregarMateriaPrimaAlProducto(producto.ID, materiaPrima);
                }
            }
        }

        private List<MateriaPrimaNecesariaEL> ObtenerMateriasPrimasPorProducto(int productoID)
        {
            List<MateriaPrimaNecesariaEL> materiasPrimas = new List<MateriaPrimaNecesariaEL>();

            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                string query = @"
                    SELECT mp.ID, mp.Nombre, pmp.Cantidad
                    FROM ProductoMateriaPrima pmp
                    JOIN MateriaPrima mp ON pmp.MateriaPrimaID = mp.ID
                    WHERE pmp.ProductoID = @ProductoID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MateriaPrimaNecesariaEL materiaPrima = new MateriaPrimaNecesariaEL
                    {
                        MateriaPrimaID = reader.GetInt32("ID"),
                        MateriaPrimaNombre = reader.GetString("Nombre"),
                        Cantidad = reader.GetInt32("Cantidad")
                    };
                    materiasPrimas.Add(materiaPrima);
                }
            }
            return materiasPrimas;
        }

        private void AgregarMateriaPrimaAlProducto(int productoID, MateriaPrimaNecesariaEL materiaPrima)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                string query = "INSERT INTO ProductoMateriaPrima (ProductoID, MateriaPrimaID, Cantidad) VALUES (@ProductoID, @MateriaPrimaID, @Cantidad)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                cmd.Parameters.AddWithValue("@MateriaPrimaID", materiaPrima.MateriaPrimaID);
                cmd.Parameters.AddWithValue("@Cantidad", materiaPrima.Cantidad);
                cmd.ExecuteNonQuery();
            }
        }

        private void EliminarMateriasPrimasDelProducto(int productoID)
        {
            using (MySqlConnection conn = conexion.Conectar())
            {
                conn.Open();
                string query = "DELETE FROM ProductoMateriaPrima WHERE ProductoID = @ProductoID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
