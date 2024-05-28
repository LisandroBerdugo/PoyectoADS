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

        public FrmPrueba6()
        {
            InitializeComponent();
            comprasDal = new ComprasDAL();
            ventasDal = new VentasDAL();
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            List<ComprasEL> compras = comprasDal.ObtenerCompras();
            List<VentasEL> ventas = ventasDal.ObtenerVentas();

            string path = "ReporteBalance.pdf";
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                // Título del documento
                document.Add(new Paragraph("Reporte de Balance de Compras y Ventas"));
                document.Add(new Paragraph(" "));

                // Sección de Compras
                document.Add(new Paragraph("Compras"));
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
                }

                // Agregar total de compras
                tableCompras.AddCell("");
                tableCompras.AddCell("");
                tableCompras.AddCell("Total Compras");
                tableCompras.AddCell(totalCompras.ToString("C2"));

                document.Add(tableCompras);

                // Espacio entre tablas
                document.Add(new Paragraph(" "));

                // Sección de Ventas
                document.Add(new Paragraph("Ventas"));
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
                }

                // Agregar total de ventas
                tableVentas.AddCell("");
                tableVentas.AddCell("");
                tableVentas.AddCell("Total Ventas");
                tableVentas.AddCell(totalVentas.ToString("C2"));

                document.Add(tableVentas);

                // Espacio entre tablas
                document.Add(new Paragraph(" "));

                // Total General
                decimal totalGeneral = totalVentas - totalCompras;
                document.Add(new Paragraph($"Total General (Ventas - Compras): {totalGeneral:C2}"));

                document.Close();
                writer.Close();
            }

            MessageBox.Show("Reporte generado con éxito en " + Path.GetFullPath(path), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
