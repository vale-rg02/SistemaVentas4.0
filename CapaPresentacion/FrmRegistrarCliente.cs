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
    public partial class FrmRegistrarCliente : Form
    {
        public bool Edit = false;

        public bool Insert { get; internal set; }

        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = "";
            if (rbtnactivo.Checked == true)
            {
                estado = "ACTIVO";
            }
            else
            {
                estado = "INACTIVO";

            }

            try
            {
                if (this.txtnombre.Text == string.Empty || this.txtapellidos.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del cliente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.Insert == true)
                    {
                        CNCliente.Guardar(this.txtnombre.Text, this.txtapellidos.Text, this.txtrfc.Text, this.txtdni.Text, this.txttelefono.Text, estado);
                        MessageBox.Show("Cliente registrado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.Edit == true)
                    {
                        CNCliente.Editar(this.txtnombre.Text, this.txtapellidos.Text, this.txtrfc.Text, this.txtdni.Text, this.txttelefono.Text, estado);
                        MessageBox.Show("Cliente registrado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoCliente form = new FrmListadoCliente();
                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoCliente form = new FrmListadoCliente();
            form.Show();
            this.Hide();
        }


    }
}

