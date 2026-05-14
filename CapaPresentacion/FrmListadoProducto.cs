using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmListadoProducto : Form
    {
        public FrmListadoProducto()
        {
            InitializeComponent();
        }

        private void FrmListadoProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Mostrar();
        }

        public void Mostrar()
        {
            this.dlistado.DataSource = CNProducto.Listar();
        }

        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNProducto.BuscarNombre(txtbuscar.Text);
        }

        public void BuscarCodigo()
        {
            this.dlistado.DataSource = CNProducto.BuscarCodigo(txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
                BuscarNombre();
            else if (rbtncodigo.Checked)
                BuscarCodigo();
            else
                MessageBox.Show("Seleccione un criterio de búsqueda", "Sistema de Ventas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto form = new FrmRegistrarProducto();
            form.Edit = true;
            form.Insert = false;

            form.txtidproducto.Text = this.dlistado.CurrentRow.Cells["idproducto"].Value.ToString();
            form.txtcodigo.Text = this.dlistado.CurrentRow.Cells["codigo"].Value.ToString();
            form.txtnombre.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.txtprecioventa.Text = this.dlistado.CurrentRow.Cells["precio_venta"].Value.ToString();
            form.txtpreciocompra.Text = this.dlistado.CurrentRow.Cells["precio_compra"].Value.ToString();
            form.txtdescripcion.Text = this.dlistado.CurrentRow.Cells["descripcion"].Value.ToString();
            form.cboidcategoria.Text = this.dlistado.CurrentRow.Cells["idcategoria"].Value.ToString();
            form.dtfechaingreso.Value = Convert.ToDateTime(this.dlistado.CurrentRow.Cells["f_ingreso"].Value);
            form.dtfechavencimiento.Value = Convert.ToDateTime(this.dlistado.CurrentRow.Cells["f_vencimiento"].Value);
            form.txtcantidad.Text = this.dlistado.CurrentRow.Cells["stock"].Value.ToString();

            string estado = this.dlistado.CurrentRow.Cells["estado"].Value.ToString();
            if (estado == "ACTIVO") form.rbactivo.Checked = true;
            else form.rbinactivo.Checked = true;

            form.MdiParent = this.MdiParent;
            form.Show();
            form.BringToFront();
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show(
                    "¿Realmente desea eliminar el(los) registro(s)?",
                    "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dlistado.SelectedRows.Count > 0 && opcion == DialogResult.OK)
                {
                    CNProducto.Eliminar(Convert.ToInt32(dlistado.CurrentRow.Cells["idproducto"].Value));
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

        private void btnnuevo_Click_1(object sender, EventArgs e)
        {
            FrmRegistrarProducto form = new FrmRegistrarProducto();
            form.Insert = true;
            form.MdiParent = this.MdiParent;
            form.Show();
            form.BringToFront();
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ── Reporte Facturas: pasa el producto seleccionado ───────────────────
        private void btnreporte_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow == null || dlistado.CurrentRow.IsNewRow)
            {
                // Sin selección → abre reporte en modo búsqueda manual
                new FrmReporteFactura().ShowDialog();
                return;
            }

            int idproducto = Convert.ToInt32(dlistado.CurrentRow.Cells["idproducto"].Value);
            string nombre = dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            string codigo = dlistado.CurrentRow.Cells["codigo"].Value.ToString();

            // Abre en modo producto → carga facturas automáticamente
            new FrmReporteFactura(idproducto, nombre, codigo).ShowDialog();
        }

        // ── Hover botones ─────────────────────────────────────────────────────
        private void BtnHoverEnter(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(30, 90, 180);
        private void BtnHoverLeave(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(52, 120, 220);

        private void BtnSalirHoverEnter(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(160, 30, 30);
        private void BtnSalirHoverLeave(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(200, 50, 50);

        private void BtnReporteHoverEnter(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(20, 110, 70);
        private void BtnReporteHoverLeave(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(33, 150, 100);
    }
}