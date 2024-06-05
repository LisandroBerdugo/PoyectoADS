using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Prueba2_Fase1.EL;
using Prueba2_Fase1.DAL;

namespace Prueba2_Fase1
{
    public partial class frmSeleccionarMateriaPrima : Form
    {
        private MateriaPrimaDAL materiaPrimaDAL;
        public List<MateriaPrimaNecesariaEL> MateriasPrimasSeleccionadas { get; private set; }

        public frmSeleccionarMateriaPrima(List<MateriaPrimaNecesariaEL> materiasPrimasSeleccionadas)
        {
            InitializeComponent();
            materiaPrimaDAL = new MateriaPrimaDAL();
            MateriasPrimasSeleccionadas = materiasPrimasSeleccionadas ?? new List<MateriaPrimaNecesariaEL>();
        }

        private void frmSeleccionarMateriaPrima_Load(object sender, EventArgs e)
        {
            CargarMateriasPrimas();
            CargarMateriasPrimasSeleccionadas();
        }

        private void CargarMateriasPrimas()
        {
            List<MateriaPrima> materiasPrimas = materiaPrimaDAL.ObtenerTodas();
            dgvMateriaPrima.DataSource = materiasPrimas;
        }

        private void CargarMateriasPrimasSeleccionadas()
        {
            dgvSeleccionadas.DataSource = null;
            dgvSeleccionadas.DataSource = MateriasPrimasSeleccionadas;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMateriaPrima.SelectedRows)
            {
                var materiaPrima = new MateriaPrimaNecesariaEL
                {
                    MateriaPrimaID = Convert.ToInt32(row.Cells["ID"].Value),
                    MateriaPrimaNombre = row.Cells["Nombre"].Value.ToString(),
                    Cantidad = Convert.ToInt32(numCantidad.Value)
                };

                MateriasPrimasSeleccionadas.Add(materiaPrima);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
