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
    public partial class FrmRegistrarProducto : Form
    {

        public bool Edit = false;

        public bool Insert { get; internal set; }
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
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
                if (this.txtnombre.Text == string.Empty || this.txtcodigo.Text == string.Empty || this.txtidcategoria.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del producto", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal pcompra = numpcompra.Value;
                decimal pventa = numpventa.Value;
                int stock = (int)numstock.Value;

                DateTime fingreso = dateingreso.Value;
                DateTime fvencimiento = datevencimiento.Value;

                if (fvencimiento < fingreso)
                {
                    MessageBox.Show("La fecha de vencimiento no puede ser menor que la de ingreso");
                    return;
                }

                int idcategoria = Convert.ToInt32(txtidcategoria.Text);

                if (this.Insert == true)
                {
                    CNProducto cn = new CNProducto();

                    cn.Guardar(
                        this.txtcodigo.Text,  
                        this.txtnombre.Text,
                        this.txtdescripcion.Text,
                        fingreso,
                        fvencimiento,
                        (double)pcompra,
                        (double)pventa,
                        stock,
                        estado,
                        idcategoria
                    );

                    MessageBox.Show("Producto registrado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (this.Edit == true)
                {
                    CNProducto.Editar(
                        Convert.ToInt32(this.txtidproducto.Text),
                        this.txtcodigo.Text,
                        this.txtnombre.Text,
                        this.txtdescripcion.Text,
                        fingreso,
                        fvencimiento,
                        (double)pcompra,
                        (double)pventa,
                        stock,
                        estado,
                        idcategoria
                    );

                    MessageBox.Show("Producto actualizado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
