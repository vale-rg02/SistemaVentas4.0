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

        public bool Insert = false;
        public bool Edit = false;

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
            FrmRegistrarProducto form = new FrmRegistrarProducto();

            form.Edit = true;

            if (dlistado.CurrentRow == null || dlistado.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un registro válido para editar.",
                    "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewCell cell in dlistado.CurrentRow.Cells)
            {
                MessageBox.Show(cell.OwningColumn.Name);
            }

            form.txtcodigo.Text = this.dlistado.CurrentRow.Cells["codigo"].Value.ToString();
            form.txtnombre.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.numpventa.Value = Convert.ToDecimal(this.dlistado.CurrentRow.Cells["pventa"].Value);
            form.numpcompra.Value = Convert.ToDecimal(this.dlistado.CurrentRow.Cells["pcompra"].Value);
            form.txtdescripcion.Text = this.dlistado.CurrentRow.Cells["descripcion"].Value.ToString();
            form.txtidcategoria.Text = this.dlistado.CurrentRow.Cells["idcategoria"].Value.ToString();
            form.dateingreso.Value = Convert.ToDateTime(this.dlistado.CurrentRow.Cells["dateingreso"].Value);
            form.datevencimiento.Value = Convert.ToDateTime(this.dlistado.CurrentRow.Cells["datevencimiento"].Value);
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

            form.Insert = true;

            form.Show();
            form.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

