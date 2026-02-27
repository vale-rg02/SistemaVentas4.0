using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmListadoCliente : Form
    {
        public bool Insert = false;
        public bool Edit = false;


        public FrmListadoCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmListadoCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

        }

        public void Mostrar()
        {
            this.dlistado.DataSource = CNCliente.Listar();
        }

        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNCliente.BuscarNombre(txtbuscar.Text);
        }
        public void BuscarDni()
        {
            this.dlistado.DataSource = CNCliente.BuscarDni(txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                BuscarNombre();
            }
            else if (rdbtndni.Checked)
            {
                BuscarDni();
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de busqueda.", "Sistema de Ventas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente form = new FrmRegistrarCliente();
            form.Show();
            form.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente form = new FrmRegistrarCliente();

            form.Edit = true;

            form.txtidcliente.Text = this.dlistado.CurrentRow.Cells["idcliente"].Value.ToString();
            form.txtnombre.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.txtapellidos.Text = this.dlistado.CurrentRow.Cells["apellidos"].Value.ToString();
            form.txtdni.Text = this.dlistado.CurrentRow.Cells["dni"].Value.ToString();
            form.txtrfc.Text = this.dlistado.CurrentRow.Cells["rfc"].Value.ToString();
            form.txttelefono.Text = this.dlistado.CurrentRow.Cells["telefono"].Value.ToString();

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
            string idcliente = dlistado.CurrentRow.Cells["idcliente"].Value.ToString();
            CNCliente.Eliminar(Convert.ToInt32(idcliente));

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
            FrmRegistrarCliente form = new FrmRegistrarCliente();

            form.Insert = true;

            form.Show();
            form.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
