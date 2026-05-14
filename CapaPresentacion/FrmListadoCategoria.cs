using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmListadoCategoria : Form
    {
        public FrmListadoCategoria()
        {
            InitializeComponent();
        }

        private void FrmListadoCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
        }

        public void Mostrar()
        {
            this.dlistado.DataSource = CNCategoria.Listar();
        }

        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNCategoria.BuscarNombre(txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e) => this.Buscar();
        private void txtbuscar_TextChanged(object sender, EventArgs e) => this.Buscar();
        private void Buscar() => this.BuscarNombre();

        // ── Nuevo → MDI ───────────────────────────────────────────────────────
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria form = new FrmRegistrarCategoria();
            form.Insert = true;
            form.MdiParent = this.MdiParent;
            form.Show();
            form.BringToFront();
            this.Close();
        }

        // ── Editar → MDI ──────────────────────────────────────────────────────
        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria form = new FrmRegistrarCategoria();
            form.Edit = true;
            form.Insert = false;
            form.txtidcategoria.Text = this.dlistado.CurrentRow.Cells["idcategoria"].Value.ToString();
            form.txtdescripcion.Text = this.dlistado.CurrentRow.Cells["descripcion"].Value.ToString();
            form.MdiParent = this.MdiParent;
            form.Show();
            form.BringToFront();
            this.Close();
        }

        // ── Eliminar (sin cambios) ────────────────────────────────────────────
        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show(
                    "¿Realmente desea eliminar el(los) registro(s)?",
                    "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dlistado.SelectedRows.Count > 0 && opcion == DialogResult.OK)
                {
                    CNCategoria.Eliminar(Convert.ToInt32(
                        dlistado.CurrentRow.Cells["idcategoria"].Value));
                    MessageBox.Show("Registro eliminado", "Sistema de Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        // ── Salir → cierra el hijo MDI ────────────────────────────────────────
        private void btnsalir_Click(object sender, EventArgs e) => this.Close();

        // ── Reporte → abre FrmReporteCategoria ───────────────────────────────
        private void btnreporte_Click(object sender, EventArgs e)
        {
            new FrmReporteCategoria().ShowDialog();
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