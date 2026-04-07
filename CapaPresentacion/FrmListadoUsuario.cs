using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmListadoUsuario : Form
    {
        public FrmListadoUsuario()
        {
            InitializeComponent();
        }

        private void FrmListadoUsuario_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
        }

        public void Mostrar()
        {
            this.dlistado.DataSource = CNUsuario.Listar();
        }

        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNUsuario.BuscarNombre(txtbuscar.Text);
        }

        public void BuscarUsuario()
        {
            this.dlistado.DataSource = CNUsuario.BuscarNombreUsuario(txtbuscar.Text);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario form = new FrmRegistrarUsuario();

            form.Show();
            form.Insert = true;
            form.Edit = false;
            this.Hide();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                this.BuscarNombre();
            }
            else if (rbtnusuario.Checked)
            {
                this.BuscarUsuario();
            }
            else
            {
                MessageBox.Show("Ingrese un criterio de busqueda",
                    "Sistema de ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Validar que exista una fila "actual" seleccionada y que no sea la fila de nuevo registro
            if (dlistado.CurrentRow == null || dlistado.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione una fila válida antes de editar.",
                    "Sistema de ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var row = dlistado.CurrentRow;

            FrmRegistrarUsuario form = new FrmRegistrarUsuario();
            form.Edit = true;
            form.Insert = false;

            // Usar Convert.ToString para evitar NullReferenceException si Value es null
            form.txtidusuario.Text = Convert.ToString(row.Cells["idusuario"].Value);
            form.txtidempleado.Text = Convert.ToString(row.Cells["idempleado"].Value);
            form.txtnombre.Text = Convert.ToString(row.Cells["nombre"].Value);
            form.txtapellidos.Text = Convert.ToString(row.Cells["apellidos"].Value);
            form.txtusuario.Text = Convert.ToString(row.Cells["usuario"].Value);
            form.txtpassword.Text = Convert.ToString(row.Cells["pass"].Value);
            form.cboacceso.Text = Convert.ToString(row.Cells["acceso"].Value);

            string estado = Convert.ToString(row.Cells["estado"].Value);
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
            try
            {
                DialogResult op;
                op = MessageBox.Show("Realmente desea eliminar el registro",
                    "Sistema de ventas",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (dlistado.SelectedRows.Count > 0)
                {
                    if (op == DialogResult.OK)
                    {
                        string idusuario = dlistado.CurrentRow.Cells["idusuario"].Value.ToString();
                        CNUsuario.Eliminar(Convert.ToInt32(idusuario.ToString()));
                        MessageBox.Show("Registro eliminado",
                            "Sistema de ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Mostrar();
                    }
                }
                this.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
