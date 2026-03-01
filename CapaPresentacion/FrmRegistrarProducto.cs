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
        public bool ModoEdit = false;
        public bool ModoInsert = false;

        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            cmbcategoria.DataSource = CNProducto.ListarCategorias();
            cmbcategoria.DisplayMember = "descripcion";
            cmbcategoria.ValueMember = "idcategoria";

            if (this.ModoInsert == false && this.ModoEdit == false)
            {
                this.ModoInsert = true;
            }
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
                if (this.txtnombre.Text == string.Empty || this.txtcodigo.Text == string.Empty)
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

                int idcategoria = Convert.ToInt32(cmbcategoria.Text);

                if (this.ModoInsert == true)
                {
                    CNProducto cn = new CNProducto();
                    string resultado = cn.Guardar(
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
                else if (this.ModoEdit == true)
                {
                    string resultado = CNProducto.Editar(
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

                this.ModoInsert = false;
                this.ModoEdit = false;
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