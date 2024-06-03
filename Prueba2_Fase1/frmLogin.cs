using Prueba2_Fase1.DAL;
using Prueba2_Fase1.Entities;
using System;
using System.Windows.Forms;

namespace Prueba2_Fase1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string password = txtPassword.Text;
            UsuariosDAL usuariosDal = new UsuariosDAL();
            Usuario usuario = usuariosDal.AutenticarUsuario(nombre, password);

            if (usuario != null)
            {
                this.Hide();
                FormaMenu formaMenu = new FormaMenu();
                formaMenu.RolUsuario = usuario.RolID;
                formaMenu.FormClosed += (s, args) =>
                {
                    this.Show();
                    LimpiarCampos();
                };
                formaMenu.Show();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas o cuenta desactivada", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Cerrar la aplicación cuando se cierre el formulario de login
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
