using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Prueba2_Fase1.DAL;
using Prueba2_Fase1.EL;

namespace Prueba2_Fase1
{
    public partial class FrmPrueba6 : Form
    {
        private ComprasDAL comprasDal;
        private VentasDAL ventasDal;
        private AlmacenamientoDAL almacenamientoDal;

        public FrmPrueba6()
        {
            InitializeComponent();
            comprasDal = new ComprasDAL();
            ventasDal = new VentasDAL();
            almacenamientoDal = new AlmacenamientoDAL();
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            GenerarReporteBalance();
        }

        private void BtnGenerarReporteCompras_Click(object sender, EventArgs e)
        {
            GenerarReporteCompras();
        }

        private void BtnGenerarReporteVentas_Click(object sender, EventArgs e)
        {
            GenerarReporteVentas();
        }

        private void BtnGenerarReporteCreacionJuguetes_Click(object sender, EventArgs e)
        {
            GenerarReporteCreacionJuguetes();
        }

        private void GenerarReporteBalance()
        {
            btnGenerarReporte.Cursor = Cursors.WaitCursor;
            List<ComprasEL> compras = comprasDal.ObtenerCompras();
            List<VentasEL> ventas = ventasDal.ObtenerVentas();

            int totalSteps = compras.Count + ventas.Count + 5;
            progressBar.Minimum = 0;
            progressBar.Maximum = totalSteps;
            progressBar.Value = 0;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ReporteBalance.pdf";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                document.Add(new Paragraph("Reporte de Balance de Compras y Ventas"));
                document.Add(new Paragraph(" "));
                UpdateProgressBar();

                var texto = new Paragraph("Compras");
                texto.Alignment = Element.ALIGN_CENTER;
                document.Add(texto);

                PdfPTable tableCompras = new PdfPTable(4);
                tableCompras.AddCell("ID");
                tableCompras.AddCell("Proveedor");
                tableCompras.AddCell("Fecha");
                tableCompras.AddCell("Total");

                decimal totalCompras = 0;
                foreach (var compra in compras)
                {
                    decimal totalCompra = compra.Detalles.Sum(d => d.Cantidad * d.PrecioCompra);
                    tableCompras.AddCell(compra.ID.ToString());
                    tableCompras.AddCell(compra.ProveedorNombre);
                    tableCompras.AddCell(compra.FechaCompra.ToString("dd/MM/yyyy"));
                    tableCompras.AddCell(totalCompra.ToString("C2"));
                    totalCompras += totalCompra;
                    UpdateProgressBar();
                }

                tableCompras.AddCell("");
                tableCompras.AddCell("");
                tableCompras.AddCell("Total Compras");
                tableCompras.AddCell(totalCompras.ToString("C2"));
                document.Add(tableCompras);

                document.Add(new Paragraph(" "));
                UpdateProgressBar();

                texto = new Paragraph("Ventas");
                texto.Alignment = Element.ALIGN_CENTER;
                document.Add(texto);

                PdfPTable tableVentas = new PdfPTable(4);
                tableVentas.AddCell("ID");
                tableVentas.AddCell("Cliente");
                tableVentas.AddCell("Fecha");
                tableVentas.AddCell("Total");

                decimal totalVentas = 0;
                foreach (var venta in ventas)
                {
                    decimal totalVenta = venta.Detalles.Sum(d => d.Cantidad * d.PrecioVenta);
                    tableVentas.AddCell(venta.ID.ToString());
                    tableVentas.AddCell($"{venta.ClienteNombre} {venta.ClienteApellido}");
                    tableVentas.AddCell(venta.FechaVenta.ToString("dd/MM/yyyy"));
                    tableVentas.AddCell(totalVenta.ToString("C2"));
                    totalVentas += totalVenta;
                    UpdateProgressBar();
                }

                tableVentas.AddCell("");
                tableVentas.AddCell("");
                tableVentas.AddCell("Total Ventas");
                tableVentas.AddCell(totalVentas.ToString("C2"));
                document.Add(tableVentas);

                document.Add(new Paragraph(" "));
                UpdateProgressBar();

                decimal totalGeneral = totalVentas - totalCompras;
                document.Add(new Paragraph($"Total General (Ventas - Compras): {totalGeneral:C2}"));

                document.Close();
                writer.Close();
                UpdateProgressBar();
            }

            MessageBox.Show("Reporte generado con éxito en " + Path.GetFullPath(path), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar.Value = 0;

            btnGenerarReporte.Cursor = Cursors.Arrow;
        }

        private void GenerarReporteCompras()
        {
            btnGenerarReporteCompras.Cursor = Cursors.WaitCursor;
            List<ComprasEL> compras = comprasDal.ObtenerCompras();

            int totalSteps = compras.Count + 3;
            progressBar.Minimum = 0;
            progressBar.Maximum = totalSteps;
            progressBar.Value = 0;

            string path = "ReporteCompras.pdf";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                document.Add(new Paragraph("Reporte de Compras"));
                document.Add(new Paragraph(" "));
                UpdateProgressBar();

                PdfPTable tableCompras = new PdfPTable(4);
                tableCompras.AddCell("ID");
                tableCompras.AddCell("Proveedor");
                tableCompras.AddCell("Fecha");
                tableCompras.AddCell("Total");

                decimal totalCompras = 0;
                foreach (var compra in compras)
                {
                    decimal totalCompra = compra.Detalles.Sum(d => d.Cantidad * d.PrecioCompra);
                    tableCompras.AddCell(compra.ID.ToString());
                    tableCompras.AddCell(compra.ProveedorNombre);
                    tableCompras.AddCell(compra.FechaCompra.ToString("dd/MM/yyyy"));
                    tableCompras.AddCell(totalCompra.ToString("C2"));
                    totalCompras += totalCompra;
                    UpdateProgressBar();
                }

                tableCompras.AddCell("");
                tableCompras.AddCell("");
                tableCompras.AddCell("Total Compras");
                tableCompras.AddCell(totalCompras.ToString("C2"));
                document.Add(tableCompras);

                document.Close();
                writer.Close();
                UpdateProgressBar();
            }

            MessageBox.Show("Reporte de compras generado con éxito en " + Path.GetFullPath(path), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar.Value = 0;

            btnGenerarReporteCompras.Cursor = Cursors.Arrow;
        }

        private void GenerarReporteVentas()
        {
            btnGenerarReporteVentas.Cursor = Cursors.WaitCursor;
            List<VentasEL> ventas = ventasDal.ObtenerVentas();

            int totalSteps = ventas.Count + 3;
            progressBar.Minimum = 0;
            progressBar.Maximum = totalSteps;
            progressBar.Value = 0;

            string path = "ReporteVentas.pdf";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                document.Add(new Paragraph("Reporte de Ventas"));
                document.Add(new Paragraph(" "));
                UpdateProgressBar();

                PdfPTable tableVentas = new PdfPTable(4);
                tableVentas.AddCell("ID");
                tableVentas.AddCell("Cliente");
                tableVentas.AddCell("Fecha");
                tableVentas.AddCell("Total");

                decimal totalVentas = 0;
                foreach (var venta in ventas)
                {
                    decimal totalVenta = venta.Detalles.Sum(d => d.Cantidad * d.PrecioVenta);
                    tableVentas.AddCell(venta.ID.ToString());
                    tableVentas.AddCell($"{venta.ClienteNombre} {venta.ClienteApellido}");
                    tableVentas.AddCell(venta.FechaVenta.ToString("dd/MM/yyyy"));
                    tableVentas.AddCell(totalVenta.ToString("C2"));
                    totalVentas += totalVenta;
                    UpdateProgressBar();
                }

                tableVentas.AddCell("");
                tableVentas.AddCell("");
                tableVentas.AddCell("Total Ventas");
                tableVentas.AddCell(totalVentas.ToString("C2"));
                document.Add(tableVentas);

                document.Close();
                writer.Close();
                UpdateProgressBar();
            }

            MessageBox.Show("Reporte de ventas generado con éxito en " + Path.GetFullPath(path), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar.Value = 0;

            btnGenerarReporteVentas.Cursor = Cursors.Arrow;
        }

        private void GenerarReporteCreacionJuguetes()
        {
            btnGenerarReporteCreacionJuguetes.Cursor = Cursors.WaitCursor;
            List<AlmacenamientoEL> creaciones = almacenamientoDal.ObtenerMovimientosDeTipo("USO")
                .Where(m => m.Cantidad > 0)  // Filtrar solo las cantidades positivas
                .ToList();

            int totalSteps = creaciones.Count + 4;  // Añadir pasos adicionales para las filas totales y el progreso extra
            progressBar.Minimum = 0;
            progressBar.Maximum = totalSteps;
            progressBar.Value = 0;

            string path = "ReporteCreacionJuguetes.pdf";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                document.Add(new Paragraph("Reporte de Creación de Juguetes"));
                document.Add(new Paragraph(" "));
                UpdateProgressBar();

                PdfPTable tableCreaciones = new PdfPTable(4);
                tableCreaciones.AddCell("ID");
                tableCreaciones.AddCell("Producto");
                tableCreaciones.AddCell("Fecha");
                tableCreaciones.AddCell("Cantidad");

                int totalJuguetesCreados = 0;
                foreach (var creacion in creaciones)
                {
                    tableCreaciones.AddCell(creacion.ID.ToString());
                    tableCreaciones.AddCell(creacion.ProductoNombre);
                    tableCreaciones.AddCell(creacion.FechaMovimiento.ToString("dd/MM/yyyy"));
                    tableCreaciones.AddCell(creacion.Cantidad.ToString());
                    totalJuguetesCreados += creacion.Cantidad;
                    UpdateProgressBar();
                }

                // Añadir fila de total
                tableCreaciones.AddCell("");
                tableCreaciones.AddCell("");
                tableCreaciones.AddCell("Total Juguetes Creados");
                tableCreaciones.AddCell(totalJuguetesCreados.ToString());
                document.Add(tableCreaciones);

                document.Close();
                writer.Close();
                UpdateProgressBar();
            }

            MessageBox.Show("Reporte de creación de juguetes generado con éxito en " + Path.GetFullPath(path), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar.Value = 0;

            btnGenerarReporteCreacionJuguetes.Cursor = Cursors.Arrow;
        }


        private void UpdateProgressBar()
        {
            if (progressBar.Value < progressBar.Maximum)
            {
                progressBar.Value++;
            }
        }
    }
}
