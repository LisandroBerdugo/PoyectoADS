using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2_Fase1
{
    public class Mensajes
    {

        public static void Mensaje(String mensaje,String titulo)
        {
            MessageBox.Show(mensaje, titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void Mensaje(String mensaje )
        {
            MessageBox.Show(mensaje, "informacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void Advertencia(String mensaje, String titulo)
        {
            MessageBox.Show(mensaje, titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static void Advertencia(String mensaje)
        {
            MessageBox.Show(mensaje, "advertencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static void Error(String mensaje, String titulo)
        {
            MessageBox.Show(mensaje, titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static void Error(String mensaje)
        {
            MessageBox.Show(mensaje, "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
