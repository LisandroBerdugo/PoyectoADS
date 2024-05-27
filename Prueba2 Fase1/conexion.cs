using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEDUDB
{
    internal class Conexion
    {
        public MySqlConnection Conectar()
        {
            string cadenaConexion = "server=" + Prueba2_Fase1.Properties.Settings.Default.ip_db +
                ";port=" + Prueba2_Fase1.Properties.Settings.Default.port_db +
                ";uid=" + Prueba2_Fase1.Properties.Settings.Default.usuario_db +
                ";password=" + Prueba2_Fase1.Properties.Settings.Default.password_db +
                ";database=" + Prueba2_Fase1.Properties.Settings.Default.name_db;
            MySqlConnection con = new MySqlConnection(cadenaConexion);
            return con;
        }
        public static bool testConexion()
        {
            bool result = true;
            try
            {
                using (MySqlConnection _conn = new Conexion().Conectar())
                {
                    _conn.Open();
                    _conn.Close();
                }
            }
            catch (Exception)
            {
                ;
                throw;
            }
            return result;
        }
        public static bool checkDB(string pConexion)
        {
            bool result = true;
            try
            {
                using (MySqlConnection _conn = new MySqlConnection(pConexion))
                {
                    _conn.Open();

                    _conn.Close();
                }
            }
            catch (Exception)
            {
                result = false;

            }
            return result;
        }
    }
}
