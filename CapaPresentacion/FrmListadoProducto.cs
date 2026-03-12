using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            {
                BuscarNombre();
            }
            else if (rbtncodigo.Checked)
            {
                BuscarCodigo();
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de búsqueda", "Sistema de Ventas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow == null || dlistado.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro válido para editar.",
                    "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmRegistrarProducto form = new FrmRegistrarProducto();
            form.Edit = true;
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

            if (estado == "ACTIVO")
            {
                form.rbactivo.Checked = true;
            }
            else
            {
                form.rbinactivo.Checked = true;
            }

            form.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow == null || dlistado.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro válido para editar.",
                    "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DialogResult opcion = MessageBox.Show(
                    "¿Realmente desea eliminar el(los) registro(s)?",
                    "Sistema de Ventas",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (dlistado.SelectedRows.Count > 0 && opcion == DialogResult.OK)
                {
                    string idproducto = dlistado.CurrentRow.Cells["idproducto"].Value.ToString();
                    CNProducto.Eliminar(Convert.ToInt32(idproducto));

                    MessageBox.Show("Registro eliminado",
                        "Sistema de Ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Mostrar();
                }
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
            form.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


