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
        public void BuscarDni()
        {
            this.dlistado.DataSource = CNProducto.BuscarCodigo(txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                BuscarNombre();
            }
            else if (rdbtnidproducto.Checked)
            {
                BuscarDni();
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de busqueda.", "Sistema de Ventas",
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
            form.ModoEdit = true;

            form.txtcodigo.Text = this.dlistado.CurrentRow.Cells["codigo"].Value.ToString();
            form.txtnombre.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.numpventa.Value = Convert.ToDecimal(this.dlistado.CurrentRow.Cells["precio_venta"].Value);
            form.numpcompra.Value = Convert.ToDecimal(this.dlistado.CurrentRow.Cells["precio_compra"].Value);
            form.txtdescripcion.Text = this.dlistado.CurrentRow.Cells["descripcion"].Value.ToString();
            form.cmbcategoria.SelectedValue = this.dlistado.CurrentRow.Cells["idcategoria"].Value;
            form.dateingreso.Value = Convert.ToDateTime(this.dlistado.CurrentRow.Cells["f_ingreso"].Value);
            form.datevencimiento.Value = Convert.ToDateTime(this.dlistado.CurrentRow.Cells["f_vencimiento"].Value);
            form.numstock.Value = Convert.ToDecimal(this.dlistado.CurrentRow.Cells["stock"].Value);

            string estado = this.dlistado.CurrentRow.Cells["estado"].Value.ToString();

            if (estado == "ACTIVO")
            {
                form.rbtnactivo.Checked = true;
            }
            else
            {
                form.rbtninactivo.Checked = true;
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

            form.ModoInsert = true;

            form.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

