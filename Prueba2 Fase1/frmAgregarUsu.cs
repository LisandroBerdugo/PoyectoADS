using Prueba2_Fase1.Entities;
using Prueba2_Fase1.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prueba2_Fase1
{
    public partial class frmAgregarUsu : Form
    {
        private UsuariosDAL usuariosDAL;

        public frmAgregarUsu()
        {
            InitializeComponent();
            usuariosDAL = new UsuariosDAL();
        }

        private void frmAgregarUsu_Load(object sender, EventArgs e)
        {
            // Cargar los roles en el comboBoxRol
            try
            {
                List<Rol> roles = usuariosDAL.ObtenerRoles();
                comboBoxRol.DataSource = roles;
                comboBoxRol.DisplayMember = "Nombre";
                comboBoxRol.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = textBoxNombre.Text,
                Email = textBoxEmail.Text,
                Contraseña = textBoxContraseña.Text,
                Activo = checkBoxActivo.Checked,
                FechaRegistro = DateTime.Now,
                RolID = Convert.ToInt32(comboBoxRol.SelectedValue)
            };

            try
            {
                usuariosDAL.AgregarUsuario(nuevoUsuario);
                MessageBox.Show("Usuario agregado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }
        }
    }
}
