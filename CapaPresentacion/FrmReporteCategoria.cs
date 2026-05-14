using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteCategoria : Form
    {
        private DataTable _datos;

        public FrmReporteCategoria()
        {
            InitializeComponent();
        }

        // ── Load: carga y muestra categorías automáticamente ─────────────────
        private void FrmReporteCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                _datos = CNCategoria.Listar();
                dgCategorias.DataSource = _datos;

                // Renombrar encabezados
                if (dgCategorias.Columns.Contains("idcategoria"))
                {
                    dgCategorias.Columns["idcategoria"].HeaderText = "Código";
                    dgCategorias.Columns["idcategoria"].Width = 80;
                }
                if (dgCategorias.Columns.Contains("descripcion"))
                {
                    dgCategorias.Columns["descripcion"].HeaderText = "Descripción";
                    dgCategorias.Columns["descripcion"].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }

                lblTotal.Text = "Total registros: " + _datos.Rows.Count;
                btnImprimir.Enabled = _datos.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Imprimir ──────────────────────────────────────────────────────────
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(DibujarReporte);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;
            preview.Width = 700;
            preview.Height = 600;
            preview.ShowDialog();
        }

        private void DibujarReporte(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int margen = 50;
            int y = margen;
            int ancho = e.PageBounds.Width - margen * 2;

            Font fEmpresa = new Font("Segoe UI", 14, FontStyle.Bold);
            Font fSub = new Font("Segoe UI", 8, FontStyle.Regular);
            Font fTitulo = new Font("Segoe UI", 13, FontStyle.Bold);
            Font fHeader = new Font("Segoe UI", 9, FontStyle.Bold);
            Font fNormal = new Font("Segoe UI", 9, FontStyle.Regular);

            Brush azul = new SolidBrush(Color.FromArgb(52, 120, 220));
            Brush azulClaro = new SolidBrush(Color.FromArgb(235, 243, 255));
            Brush blanco = Brushes.White;
            Brush negro = Brushes.Black;
            Brush gris = new SolidBrush(Color.FromArgb(90, 90, 90));

            // ── Header empresa ────────────────────────────────────────────────
            g.FillRectangle(azul, margen, y, 180, 65);
            g.DrawString("MI EMPRESA", fEmpresa, blanco, margen + 8, y + 8);
            g.DrawString("www.miempresa.com", fSub, blanco, margen + 8, y + 38);
            g.DrawString("Tel: 000-000-0000", fSub, blanco, margen + 8, y + 52);

            // Fecha top derecha
            string fecha = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy",
                new System.Globalization.CultureInfo("es-ES"));
            SizeF szFecha = g.MeasureString(fecha, fSub);
            g.DrawString(fecha, fSub, gris,
                margen + ancho - szFecha.Width, y + 8);

            y += 80;

            // ── Título del reporte ────────────────────────────────────────────
            string titulo = "Listado de Categorías";
            SizeF szTit = g.MeasureString(titulo, fTitulo);
            g.DrawString(titulo, fTitulo, azul,
                margen + (ancho - szTit.Width) / 2, y);
            y += 40;

            // ── Línea decorativa bajo el título ──────────────────────────────
            g.DrawLine(new Pen(Color.FromArgb(52, 120, 220), 2),
                margen, y, margen + ancho, y);
            y += 12;

            // ── Tabla ─────────────────────────────────────────────────────────
            int colCodigo = 100;
            int colDesc = ancho - colCodigo;

            // Cabecera tabla
            g.FillRectangle(azul, margen, y, colCodigo, 26);
            g.FillRectangle(azul, margen + colCodigo, y, colDesc, 26);
            g.DrawString("Código", fHeader, blanco, margen + 6, y + 5);
            g.DrawString("Descripción", fHeader, blanco, margen + colCodigo + 6, y + 5);
            y += 26;

            // Filas
            bool altRow = false;
            foreach (DataRow row in _datos.Rows)
            {
                Brush fondo = altRow ? azulClaro : blanco;

                g.FillRectangle(fondo, margen, y, colCodigo, 22);
                g.FillRectangle(fondo, margen + colCodigo, y, colDesc, 22);

                g.DrawRectangle(Pens.LightGray, margen, y, colCodigo, 22);
                g.DrawRectangle(Pens.LightGray, margen + colCodigo, y, colDesc, 22);

                g.DrawString(row["idcategoria"].ToString(), fNormal, negro, margen + 6, y + 4);
                g.DrawString(row["descripcion"].ToString(), fNormal, negro, margen + colCodigo + 6, y + 4);

                y += 22;
                altRow = !altRow;
            }

            y += 15;

            // ── Total registros ───────────────────────────────────────────────
            g.DrawString("Total: " + _datos.Rows.Count + " categorías",
                fSub, gris, margen, y);

            // ── Línea pie de página ───────────────────────────────────────────
            g.DrawLine(new Pen(Color.FromArgb(52, 120, 220), 1),
                margen, y + 20, margen + ancho, y + 20);
        }

        // ── Cerrar ────────────────────────────────────────────────────────────
        private void btnCerrar_Click(object sender, EventArgs e)
            => this.Close();

        // ── Hover botones ─────────────────────────────────────────────────────
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