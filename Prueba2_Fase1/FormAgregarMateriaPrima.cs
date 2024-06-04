using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class FormAgregarMateriaPrima : Form
    {
        public MateriaPrima MateriaPrima { get; private set; }
        public int Cantidad { get; private set; }
        public decimal PrecioCompra { get; private set; }

        public FormAgregarMateriaPrima(List<MateriaPrima> materiasPrimas)
        {
            InitializeComponent();
            cbMateriasPrimas.DataSource = materiasPrimas;
            cbMateriasPrimas.DisplayMember = "Nombre";
            cbMateriasPrimas.ValueMember = "ID";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MateriaPrima = (MateriaPrima)cbMateriasPrimas.SelectedItem;
            Cantidad = int.Parse(txtCantidad.Text);
            PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
