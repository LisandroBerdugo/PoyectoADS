using System.Windows.Forms;

namespace Prueba2_Fase1
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            this.StartPosition = FormStartPosition.CenterScreen; // Centrado en pantalla
        }
    }
}
