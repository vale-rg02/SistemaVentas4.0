// CapaPresentacion
using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteFactura : Form
    {
        // ── Estado interno ────────────────────────────────────────────────────
        private DataTable _cabecera;
        private DataTable _detalle;

        private bool _modoProducto = false;
        private int _idProducto = 0;
        private string _nombreProducto = "";
        private string _codigoProducto = "";

        // ── Constructor normal (búsqueda manual por idventa) ──────────────────
        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        // ── Constructor con producto pre-seleccionado ─────────────────────────
        public FrmReporteFactura(int idproducto, string nombre, string codigo)
        {
            InitializeComponent();
            _modoProducto = true;
            _idProducto = idproducto;
            _nombreProducto = nombre;
            _codigoProducto = codigo;
        }

        // ── Form Load ─────────────────────────────────────────────────────────
        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            if (_modoProducto)
                ConfigurarModoProducto();
        }

        // ── Modo Producto: adapta la UI y carga datos automáticamente ─────────
        private void ConfigurarModoProducto()
        {
            // Adaptar panel de búsqueda para mostrar info del producto
            lblBuscar.Text = "Producto:";
            txtIdVenta.Text = _codigoProducto;
            txtIdVenta.ReadOnly = true;
            btnBuscar.Text = "Ver facturas";
            btnBuscar.Enabled = true;

            // Mostrar badge con nombre del producto
            lblTipoDoc.Text = "PRODUCTO";
            lblNumFactura.Text = _codigoProducto + "  |  " + _nombreProducto;

            // Ocultar campos de factura individual (no aplican en este modo)
            lblLblCliente.Visible = false;
            lblCliente.Visible = false;
            lblLblTel.Visible = false;
            lblTelefono.Visible = false;
            lblLblDoc.Visible = false;
            lblDocumento.Visible = false;
            lblLblTrab.Visible = false;
            lblTrabajador.Visible = false;
            lblLblFecha.Visible = false;
            lblFecha.Visible = false;

            // Mover grid hacia arriba para aprovechar espacio
            dgDetalle.Location = new System.Drawing.Point(10, 100);
            dgDetalle.Size = new System.Drawing.Size(820, 360);

            // Ocultar totales individuales (no aplican para lista de facturas)
            pnlTotales.Visible = false;

            // Cargar facturas automáticamente
            CargarFacturasPorProducto();
        }

        // ── Carga facturas que contienen el producto seleccionado ─────────────
        private void CargarFacturasPorProducto()
        {
            try
            {
                CNReporte cn = new CNReporte();
                DataTable dt = cn.ObtenerFacturasPorProducto(_idProducto);

                dgDetalle.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron facturas para el producto: " + _nombreProducto,
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Resaltar total con formato
                    foreach (DataGridViewRow row in dgDetalle.Rows)
                    {
                        if (row.IsNewRow) continue;
                        if (dgDetalle.Columns.Contains("Precio Unit."))
                            row.Cells["Precio Unit."].Value =
                                Convert.ToDecimal(row.Cells["Precio Unit."].Value).ToString("N2");
                        if (dgDetalle.Columns.Contains("Total"))
                            row.Cells["Total"].Value =
                                Convert.ToDecimal(row.Cells["Total"].Value).ToString("N2");
                    }

                    btnImprimir.Enabled = true;

                    // Calcular y mostrar total vendido del producto
                    decimal totalVendido = 0;
                    foreach (DataRow row in dt.Rows)
                        totalVendido += Convert.ToDecimal(row["Total"]);

                    pnlTotales.Visible = true;
                    lblLblSub.Text = "Total facturas:";
                    lblSubtotal.Text = dt.Rows.Count.ToString();
                    lblLblIva.Text = "Total vendido:";
                    lblIva.Text = "S/ " + totalVendido.ToString("N2");
                    pnlLineaTot.Visible = false;
                    lblLblTotal.Visible = false;
                    lblTotal.Visible = false;
                    pnlTotales.Location = new Point(10, 470);
                    pnlTotales.Size = new Size(400, 55);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar facturas:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Buscar (modo normal: por idventa) ─────────────────────────────────
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (_modoProducto)
            {
                CargarFacturasPorProducto();
                return;
            }

            int id;
            if (!int.TryParse(txtIdVenta.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Ingresa un número de factura válido.",
                    "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdVenta.Focus();
                return;
            }
            CargarFactura(id);
        }

        // ── Cargar factura individual (modo normal) ────────────────────────────
        private void CargarFactura(int idventa)
        {
            try
            {
                CNReporte cn = new CNReporte();
                _cabecera = cn.ObtenerCabeceraFactura(idventa);
                _detalle = cn.ObtenerDetalleFactura(idventa);

                if (_cabecera.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró la factura N° " + idventa,
                        "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFactura();
                    return;
                }

                MostrarCabecera();
                MostrarDetalle();
                btnImprimir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar factura:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarCabecera()
        {
            DataRow r = _cabecera.Rows[0];
            lblNumFactura.Text = r["serie"].ToString() + " - " + r["num_documento"].ToString();
            lblTipoDoc.Text = r["tipo_documento"].ToString().ToUpper();
            lblCliente.Text = r["cliente"].ToString();
            lblDocumento.Text = r["documento"].ToString();
            lblTelefono.Text = r["telefono"].ToString();
            lblTrabajador.Text = r["trabajador"].ToString();
            lblFecha.Text = Convert.ToDateTime(r["fecha"]).ToString("dddd, dd 'de' MMMM 'de' yyyy",
                                    new System.Globalization.CultureInfo("es-ES"));
            lblSubtotal.Text = "S/ " + Convert.ToDecimal(r["subtotal"]).ToString("N2");
            lblIva.Text = "S/ " + Convert.ToDecimal(r["iva"]).ToString("N2");
            lblTotal.Text = "S/ " + Convert.ToDecimal(r["total"]).ToString("N2");
        }

        private void MostrarDetalle()
        {
            dgDetalle.DataSource = null;
            dgDetalle.DataSource = _detalle;

            if (dgDetalle.Columns.Contains("iddetalleventa")) dgDetalle.Columns["iddetalleventa"].HeaderText = "ID";
            if (dgDetalle.Columns.Contains("descripcion")) dgDetalle.Columns["descripcion"].HeaderText = "Descripción";
            if (dgDetalle.Columns.Contains("precio")) dgDetalle.Columns["precio"].HeaderText = "Precio";
            if (dgDetalle.Columns.Contains("cantidad")) dgDetalle.Columns["cantidad"].HeaderText = "Cantidad";
            if (dgDetalle.Columns.Contains("total")) dgDetalle.Columns["total"].HeaderText = "Total";

            foreach (DataGridViewRow row in dgDetalle.Rows)
            {
                if (row.IsNewRow) continue;
                if (dgDetalle.Columns.Contains("precio"))
                    row.Cells["precio"].Value = Convert.ToDecimal(row.Cells["precio"].Value).ToString("N2");
                if (dgDetalle.Columns.Contains("total"))
                    row.Cells["total"].Value = Convert.ToDecimal(row.Cells["total"].Value).ToString("N2");
            }
        }

        private void LimpiarFactura()
        {
            lblNumFactura.Text = "----";
            lblTipoDoc.Text = "FACTURA";
            lblCliente.Text = "";
            lblDocumento.Text = "";
            lblTelefono.Text = "";
            lblTrabajador.Text = "";
            lblFecha.Text = "";
            lblSubtotal.Text = "S/ 0.00";
            lblIva.Text = "S/ 0.00";
            lblTotal.Text = "S/ 0.00";
            dgDetalle.DataSource = null;
            btnImprimir.Enabled = false;
        }

        private void txtIdVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscar_Click(sender, e);
            }
        }

        // ── Imprimir ──────────────────────────────────────────────────────────
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (_modoProducto)
            {
                ImprimirReporteProducto();
                return;
            }

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(ImprimirFactura);
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;
            preview.Width = 850;
            preview.Height = 700;
            preview.ShowDialog();
        }

        // ── Impresión: lista de facturas por producto ─────────────────────────
        private void ImprimirReporteProducto()
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += (s, ev) =>
            {
                Graphics g = ev.Graphics;
                Font fTitulo = new Font("Segoe UI", 14, FontStyle.Bold);
                Font fSub = new Font("Segoe UI", 10, FontStyle.Bold);
                Font fNormal = new Font("Segoe UI", 9, FontStyle.Regular);
                Font fHeader = new Font("Segoe UI", 8, FontStyle.Bold);
                Font fSmall = new Font("Segoe UI", 8, FontStyle.Regular);
                Brush azul = new SolidBrush(Color.FromArgb(52, 120, 220));
                Brush blanco = Brushes.White;
                Brush negro = Brushes.Black;

                int margen = 40;
                int y = margen;
                int ancho = ev.PageBounds.Width - margen * 2;

                // Título
                g.FillRectangle(azul, margen, y, ancho, 40);
                g.DrawString("Facturas del Producto: " + _nombreProducto, fTitulo, blanco, margen + 8, y + 8);
                y += 50;
                g.DrawString("Código: " + _codigoProducto, fSub, negro, margen, y);
                y += 30;

                // Cabecera tabla
                int[] colW = { 70, 120, 80, 160, 70, 80, 80 };
                string[] headers = { "N° Factura", "Serie", "Tipo", "Cliente", "Cantidad", "Precio", "Total" };
                int x = margen;
                foreach (var (h, w) in System.Linq.Enumerable.Zip(headers, colW, (a, b) => (a, b)))
                {
                    g.FillRectangle(azul, x, y, w, 24);
                    g.DrawString(h, fHeader, blanco, x + 3, y + 5);
                    x += w;
                }
                y += 24;

                // Filas
                DataTable dt = (DataTable)dgDetalle.DataSource;
                if (dt != null)
                {
                    bool alt = false;
                    foreach (DataRow row in dt.Rows)
                    {
                        x = margen;
                        Brush fondo = alt
                            ? new SolidBrush(Color.FromArgb(235, 243, 255))
                            : Brushes.White;
                        string[] vals =
                        {
                            row["N° Factura"].ToString(),
                            row["Serie"].ToString(),
                            row["Tipo"].ToString(),
                            row["Cliente"].ToString(),
                            row["Cantidad"].ToString(),
                            row["Precio Unit."].ToString(),
                            row["Total"].ToString()
                        };
                        for (int i = 0; i < vals.Length; i++)
                        {
                            g.FillRectangle(fondo, x, y, colW[i], 22);
                            g.DrawRectangle(Pens.LightGray, x, y, colW[i], 22);
                            g.DrawString(vals[i], fSmall, negro, x + 3, y + 4);
                            x += colW[i];
                        }
                        y += 22;
                        alt = !alt;
                    }
                }
            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;
            preview.Width = 860;
            preview.Height = 700;
            preview.ShowDialog();
        }

        // ── Impresión: factura individual ─────────────────────────────────────
        private void ImprimirFactura(object sender, PrintPageEventArgs e)
        {
            if (_cabecera == null || _cabecera.Rows.Count == 0) return;
            Graphics g = e.Graphics;
            DataRow cab = _cabecera.Rows[0];

            Font fTitulo = new Font("Segoe UI", 14, FontStyle.Bold);
            Font fSub = new Font("Segoe UI", 9, FontStyle.Regular);
            Font fBold = new Font("Segoe UI", 9, FontStyle.Bold);
            Font fNormal = new Font("Segoe UI", 9, FontStyle.Regular);
            Font fHeader = new Font("Segoe UI", 8, FontStyle.Bold);
            Font fSmall = new Font("Segoe UI", 8, FontStyle.Regular);
            Brush azul = new SolidBrush(Color.FromArgb(52, 120, 220));
            Brush blanco = Brushes.White;
            Brush negro = Brushes.Black;
            Brush gris = new SolidBrush(Color.FromArgb(90, 90, 90));

            int margen = 40;
            int y = margen;
            int ancho = e.PageBounds.Width - margen * 2;

            g.FillRectangle(azul, margen, y, 200, 70);
            g.DrawString("MI EMPRESA", fTitulo, blanco, margen + 8, y + 8);
            g.DrawString("www.miempresa.com", fSub, blanco, margen + 8, y + 35);
            g.DrawString("Tel: 000-000-000", fSub, blanco, margen + 8, y + 50);

            string tipodoc = cab["tipo_documento"].ToString().ToUpper();
            string numfact = cab["serie"].ToString() + " - " + cab["num_documento"].ToString();
            g.FillRectangle(azul, margen + ancho - 160, y, 160, 35);
            g.DrawString(tipodoc, fBold, blanco, margen + ancho - 150, y + 8);
            g.DrawString(numfact, fNormal, negro, margen + ancho - 160, y + 45);
            y += 90;

            g.DrawString("Cliente:", fBold, negro, margen, y);
            g.DrawString(cab["cliente"].ToString(), fNormal, negro, margen + 70, y);
            g.DrawString("Teléfono:", fBold, negro, margen + 350, y);
            g.DrawString(cab["telefono"].ToString(), fNormal, negro, margen + 430, y);
            y += 22;
            g.DrawString("Documento:", fBold, negro, margen, y);
            g.DrawString(cab["documento"].ToString(), fNormal, negro, margen + 70, y);
            y += 22;
            g.DrawString("Trabajador:", fBold, negro, margen, y);
            g.DrawString(cab["trabajador"].ToString(), fNormal, negro, margen + 75, y);
            string fecha = Convert.ToDateTime(cab["fecha"])
                .ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm",
                    new System.Globalization.CultureInfo("es-ES"));
            g.DrawString("Fecha:", fBold, negro, margen + 350, y);
            g.DrawString(fecha, fSmall, negro, margen + 400, y);
            y += 30;

            int[] colW = { 50, 270, 100, 80, 100 };
            string[] headers = { "ID", "Descripción", "Precio", "Cantidad", "Total" };
            int x = margen;
            for (int i = 0; i < headers.Length; i++)
            {
                g.FillRectangle(azul, x, y, colW[i], 24);
                g.DrawString(headers[i], fHeader, blanco, x + 4, y + 4);
                x += colW[i];
            }
            y += 24;

            bool altRow = false;
            foreach (DataRow row in _detalle.Rows)
            {
                x = margen;
                Brush fondo = altRow
                    ? new SolidBrush(Color.FromArgb(235, 243, 255))
                    : Brushes.White;
                string[] vals =
                {
                    row["iddetalleventa"].ToString(),
                    row["descripcion"].ToString(),
                    Convert.ToDecimal(row["precio"]).ToString("N2"),
                    row["cantidad"].ToString(),
                    Convert.ToDecimal(row["total"]).ToString("N2")
                };
                for (int i = 0; i < vals.Length; i++)
                {
                    g.FillRectangle(fondo, x, y, colW[i], 22);
                    g.DrawRectangle(Pens.LightGray, x, y, colW[i], 22);
                    g.DrawString(vals[i], fSmall, negro, x + 4, y + 4);
                    x += colW[i];
                }
                y += 22;
                altRow = !altRow;
            }
            y += 20;
            int xTot = margen + ancho - 200;
            g.DrawString("Sub Total:", fBold, gris, xTot, y);
            g.DrawString("S/ " + Convert.ToDecimal(cab["subtotal"]).ToString("N2"), fNormal, negro, xTot + 110, y);
            y += 20;
            g.DrawString("IGV:", fBold, gris, xTot, y);
            g.DrawString("S/ " + Convert.ToDecimal(cab["iva"]).ToString("N2"), fNormal, negro, xTot + 110, y);
            y += 20;
            g.DrawLine(new Pen(Color.FromArgb(52, 120, 220), 1), xTot, y, xTot + 200, y);
            y += 6;
            g.DrawString("Total pagar:", fBold, negro, xTot, y);
            g.DrawString("S/ " + Convert.ToDecimal(cab["total"]).ToString("N2"), fBold, negro, xTot + 110, y);
        }

        // ── Hover / Cerrar ────────────────────────────────────────────────────
        private void btnBuscar_MouseEnter(object sender, EventArgs e)
            => btnBuscar.BackColor = Color.FromArgb(30, 90, 180);
        private void btnBuscar_MouseLeave(object sender, EventArgs e)
            => btnBuscar.BackColor = Color.FromArgb(52, 120, 220);

        private void btnImprimir_MouseEnter(object sender, EventArgs e)
            => btnImprimir.BackColor = Color.FromArgb(20, 110, 70);
        private void btnImprimir_MouseLeave(object sender, EventArgs e)
            => btnImprimir.BackColor = Color.FromArgb(33, 150, 100);

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
            => btnCerrar.BackColor = Color.FromArgb(160, 30, 30);
        private void btnCerrar_MouseLeave(object sender, EventArgs e)
            => btnCerrar.BackColor = Color.FromArgb(200, 50, 50);

        private void btnCerrar_Click(object sender, EventArgs e)
            => this.Close();
    }
}