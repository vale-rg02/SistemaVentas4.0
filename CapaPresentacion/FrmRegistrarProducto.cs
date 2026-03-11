using CapaNegocio;
using System;
using System.Collections;
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
    public partial class FrmRegistrarProducto : Form
    {
        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.CargarCategoria();
            
            if (this.Insert == false && this.Edit == false)
            {
                this.Insert = true;
            }

        }
        private void CargarCategoria()
        {
            {
                cboidcategoria.DataSource = CNCategoria.Listar();
                cboidcategoria.ValueMember = "idcategoria";
                cboidcategoria.DisplayMember = "descripcion";

            }
        }   

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = "";
            if (rbactivo.Checked == true)
            {
                estado = "ACTIVO";
            }
            else
            {
                estado = "INACTIVO";
            }

            try
            {
                if (this.txtnombre.Text == string.Empty || this.txtcodigo.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del producto", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (this.Insert == true)
                {
                    CNProducto producto = new CNProducto();
                    string resultado = producto.Guardar(
                    this.txtcodigo.Text,
                    this.txtnombre.Text,
                    this.txtdescripcion.Text,
                    this.dtfechaingreso.Value,
                    this.dtfechavencimiento.Value,
                    Convert.ToDouble(txtpreciocompra.Text),
                    Convert.ToDouble(txtprecioventa.Text),
                    Convert.ToInt32(txtcantidad.Text),
                    estado,
                    Convert.ToInt32(this.cboidcategoria.SelectedValue));
                
                if (resultado == "OK")
                {
                    MessageBox.Show("Producto registrado correctamente", "Sistema de Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: " + resultado, "Sistema de Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (this.Edit == true)
            {
                string resultado = CNProducto.Editar(
                    Convert.ToInt32(this.txtidproducto.Text),
                    this.txtcodigo.Text,
                    this.txtnombre.Text,
                    this.txtdescripcion.Text,
                    this.dtfechaingreso.Value,
                    this.dtfechavencimiento.Value,
                    Convert.ToDouble(txtpreciocompra.Text),
                    Convert.ToDouble(txtprecioventa.Text),
                    Convert.ToInt32(txtcantidad.Text),
                    estado,
                    Convert.ToInt32(this.cboidcategoria.SelectedValue));

                if (resultado == "OK")
                {
                    MessageBox.Show("Producto actualizado correctamente", "Sistema de Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: " + resultado, "Sistema de Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            this.Insert = false;
            this.Edit = false;
            FrmListadoProducto form = new FrmListadoProducto();
            form.Show();
            this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoProducto form = new FrmListadoProducto();
            form.Show();
            this.Hide();
        }
    }
}