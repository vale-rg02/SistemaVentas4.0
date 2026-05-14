using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmListadoVenta : Form
    {
        public FrmListadoVenta()
        {
            InitializeComponent();
        }

        private void FrmListadoVenta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            // Carga del día por defecto
            Buscar();
        }

        // ── Buscar ventas por rango de fechas ─────────────────────────────────
        private void Buscar()
        {
            try
            {
                CNVenta cn = new CNVenta();
                dlistado.DataSource = cn.ListarPorFecha(dtpInicio.Value, dtpFin.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar ventas:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e) => Buscar();

        // ── Ver Detalle → abre FrmReporteFactura con la venta seleccionada ────
        private void btnverdetalle_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow == null || dlistado.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona una venta para ver el detalle.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idventa = Convert.ToInt32(dlistado.CurrentRow.Cells["idventa"].Value);
            FrmReporteFactura frm = new FrmReporteFactura();
            frm.ShowDialog();
            // Pre-carga el ID en el form de reporte
            // (el usuario ingresa el idventa manualmente o puedes pasarlo)
            // Alternativa directa: usa el constructor con idventa si lo agregas
        }

        // ── Anular venta ──────────────────────────────────────────────────────
        private void btnanular_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow == null || dlistado.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona una venta para anular.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string estado = dlistado.CurrentRow.Cells["estado"].Value.ToString();
            if (estado == "ANULADO")
            {
                MessageBox.Show("Esta venta ya está anulada.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resp = MessageBox.Show(
                "¿Deseas anular esta venta? Esta acción no se puede revertir.",
                "Confirmar Anulación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resp == DialogResult.Yes)
            {
                try
                {
                    int idventa = Convert.ToInt32(dlistado.CurrentRow.Cells["idventa"].Value);
                    CNVenta cn = new CNVenta();
                    if (cn.Anular(idventa))
                    {
                        MessageBox.Show("Venta anulada correctamente.",
                            "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Buscar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al anular:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ── Reporte por rango de fechas ───────────────────────────────────────
        private void btnreporte_Click(object sender, EventArgs e)
        {
            DataTable dt = dlistado.DataSource as DataTable;
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el reporte. Realiza una búsqueda primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            new FrmReporteVenta(dt, dtpInicio.Value, dtpFin.Value).ShowDialog();
        }

        // ── Salir ─────────────────────────────────────────────────────────────
        private void btnsalir_Click(object sender, EventArgs e) => this.Close();

        // ── Resaltar fila ANULADO en rojo ─────────────────────────────────────
        private void dlistado_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dlistado.Rows[e.RowIndex];
            if (row.Cells["estado"].Value?.ToString() == "ANULADO")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(150, 0, 0);
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30);
            }
        }

        // ── Hover botones ─────────────────────────────────────────────────────
        private void BtnHoverEnter(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(30, 90, 180);
        private void BtnHoverLeave(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(52, 120, 220);

        private void BtnRojoHoverEnter(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(160, 30, 30);
        private void BtnRojoHoverLeave(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(200, 50, 50);

        private void BtnVerdeHoverEnter(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(20, 110, 70);
        private void BtnVerdeHoverLeave(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(33, 150, 100);
    }
}