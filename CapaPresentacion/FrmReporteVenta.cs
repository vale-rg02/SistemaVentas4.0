using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteVenta : Form
    {
        private DataTable _datos;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;

        public FrmReporteVenta(DataTable datos, DateTime fechaInicio, DateTime fechaFin)
        {
            InitializeComponent();
            _datos = datos;
            _fechaInicio = fechaInicio;
            _fechaFin = fechaFin;
        }

        private void FrmReporteVenta_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            dgVentas.DataSource = _datos;

            // Renombrar encabezados
            string[] cols = { "idventa", "cliente", "fecha", "empleado", "tipo_documento", "serie", "num_documento", "subtotal", "iva", "total", "estado" };
            string[] headers = { "ID", "Cliente", "Fecha", "Empleado", "Tipo", "Serie", "N° Doc", "Subtotal", "IVA", "Total", "Estado" };
            for (int i = 0; i < cols.Length; i++)
                if (dgVentas.Columns.Contains(cols[i]))
                    dgVentas.Columns[cols[i]].HeaderText = headers[i];

            // Calcular totales
            decimal totalVentas = 0;
            int countActivo = 0;
            foreach (DataRow row in _datos.Rows)
            {
                if (row["estado"].ToString() != "ANULADO")
                {
                    totalVentas += Convert.ToDecimal(row["total"]);
                    countActivo++;
                }
            }

            lblRango.Text = _fechaInicio.ToString("dd/MM/yyyy") + "  →  " + _fechaFin.ToString("dd/MM/yyyy");
            lblCount.Text = "Total ventas activas: " + countActivo;
            lblMonto.Text = "Monto total: S/ " + totalVentas.ToString("N2");
        }

        // ── Resaltar ANULADO ──────────────────────────────────────────────────
        private void dgVentas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgVentas.Rows[e.RowIndex];
            if (row.Cells["estado"].Value?.ToString() == "ANULADO")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(150, 0, 0);
            }
        }

        // ── Imprimir ──────────────────────────────────────────────────────────
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(DibujarReporte);
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;
            preview.Width = 900;
            preview.Height = 700;
            preview.ShowDialog();
        }

        private void DibujarReporte(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int margen = 40;
            int y = margen;
            int ancho = e.PageBounds.Width - margen * 2;

            Font fEmpresa = new Font("Segoe UI", 13, FontStyle.Bold);
            Font fSub = new Font("Segoe UI", 8, FontStyle.Regular);
            Font fTitulo = new Font("Segoe UI", 12, FontStyle.Bold);
            Font fHeader = new Font("Segoe UI", 8, FontStyle.Bold);
            Font fNormal = new Font("Segoe UI", 8, FontStyle.Regular);
            Font fTotal = new Font("Segoe UI", 10, FontStyle.Bold);

            Brush azul = new SolidBrush(Color.FromArgb(52, 120, 220));
            Brush azulClaro = new SolidBrush(Color.FromArgb(235, 243, 255));
            Brush blanco = Brushes.White;
            Brush negro = Brushes.Black;
            Brush gris = new SolidBrush(Color.FromArgb(90, 90, 90));
            Brush rojo = new SolidBrush(Color.FromArgb(150, 0, 0));

            // ── Header empresa ────────────────────────────────────────────────
            g.FillRectangle(azul, margen, y, 200, 60);
            g.DrawString("MI EMPRESA", fEmpresa, blanco, margen + 8, y + 8);
            g.DrawString("www.miempresa.com", fSub, blanco, margen + 8, y + 35);
            g.DrawString("Tel: 000-000-0000", fSub, blanco, margen + 8, y + 48);

            string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            SizeF sf = g.MeasureString(fecha, fSub);
            g.DrawString(fecha, fSub, gris, margen + ancho - sf.Width, y + 8);
            y += 72;

            // ── Título ────────────────────────────────────────────────────────
            string titulo = "Reporte de Ventas";
            SizeF st = g.MeasureString(titulo, fTitulo);
            g.DrawString(titulo, fTitulo, azul, margen + (ancho - st.Width) / 2, y);
            y += 24;

            string rango = _fechaInicio.ToString("dd/MM/yyyy") + "  al  " + _fechaFin.ToString("dd/MM/yyyy");
            SizeF sr = g.MeasureString(rango, fSub);
            g.DrawString(rango, fSub, gris, margen + (ancho - sr.Width) / 2, y);
            y += 20;

            g.DrawLine(new Pen(Color.FromArgb(52, 120, 220), 2), margen, y, margen + ancho, y);
            y += 10;

            // ── Tabla ─────────────────────────────────────────────────────────
            int[] colW = { 30, 160, 65, 150, 65, 45, 60, 55, 55 };
            string[] headers = { "ID", "Cliente", "Fecha", "Empleado", "Tipo", "Serie", "N° Doc", "Total", "Estado" };

            int x = margen;
            for (int i = 0; i < headers.Length; i++)
            {
                g.FillRectangle(azul, x, y, colW[i], 24);
                g.DrawString(headers[i], fHeader, blanco, x + 3, y + 6);
                x += colW[i];
            }
            y += 24;

            bool alt = false;
            decimal totalMonto = 0;
            int countActivo = 0;

            foreach (DataRow row in _datos.Rows)
            {
                bool anulado = row["estado"].ToString() == "ANULADO";
                Brush fondo = anulado ? new SolidBrush(Color.FromArgb(255, 220, 220))
                                       : (alt ? azulClaro : blanco);
                Brush txtColor = anulado ? rojo : negro;

                x = margen;
                string[] vals = {
                    row["idventa"].ToString(),
                    row["cliente"].ToString(),
                    row["fecha"].ToString(),
                    row["empleado"].ToString(),
                    row["tipo_documento"].ToString(),
                    row["serie"].ToString(),
                    row["num_documento"].ToString(),
                    Convert.ToDecimal(row["total"]).ToString("N2"),
                    row["estado"].ToString()
                };

                for (int i = 0; i < vals.Length; i++)
                {
                    g.FillRectangle(fondo, x, y, colW[i], 20);
                    g.DrawRectangle(Pens.LightGray, x, y, colW[i], 20);
                    g.DrawString(vals[i], fNormal, txtColor, x + 2, y + 3);
                    x += colW[i];
                }

                if (!anulado)
                {
                    totalMonto += Convert.ToDecimal(row["total"]);
                    countActivo++;
                }
                y += 20;
                alt = !alt;
            }

            y += 15;
            g.DrawLine(new Pen(Color.FromArgb(52, 120, 220), 1), margen, y, margen + ancho, y);
            y += 8;

            g.DrawString("Total ventas activas: " + countActivo, fTotal, gris, margen, y);
            string montoStr = "Monto total: S/ " + totalMonto.ToString("N2");
            SizeF sm = g.MeasureString(montoStr, fTotal);
            g.DrawString(montoStr, fTotal, azul, margen + ancho - sm.Width, y);
        }

        // ── Cerrar ────────────────────────────────────────────────────────────
        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

        // ── Hover ─────────────────────────────────────────────────────────────
        private void btnImprimir_MouseEnter(object sender, EventArgs e)
            => btnImprimir.BackColor = Color.FromArgb(20, 110, 70);
        private void btnImprimir_MouseLeave(object sender, EventArgs e)
            => btnImprimir.BackColor = Color.FromArgb(33, 150, 100);

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
            => btnCerrar.BackColor = Color.FromArgb(160, 30, 30);
        private void btnCerrar_MouseLeave(object sender, EventArgs e)
            => btnCerrar.BackColor = Color.FromArgb(200, 50, 50);
    }
}