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

// ── Requiere NuGet: Install-Package ZXing.Net  (en CapaPresentacion) ──
using ZXing;
using ZXing.Common;

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

        // ── Load ──────────────────────────────────────────────────────────────
        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.CargarCategoria();
        }

        // ── Shown ─────────────────────────────────────────────────────────────
        private void FrmRegistrarProducto_Shown_1(object sender, EventArgs e)
        {
            if (this.Insert == false && this.Edit == false)
                this.Insert = true;
        }

        // ── Cargar categorías (sin cambios) ───────────────────────────────────
        private void CargarCategoria()
        {
            cboidcategoria.DataSource = CNCategoria.Listar();
            cboidcategoria.ValueMember = "idcategoria";
            cboidcategoria.DisplayMember = "descripcion";
        }

        // ── Guardar / Editar (sin cambios en lógica) ──────────────────────────
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = rbactivo.Checked ? "ACTIVO" : "INACTIVO";

            try
            {
                if (this.txtnombre.Text == string.Empty || this.txtcodigo.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del producto", "Sistema de Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (this.Insert == true)
                {
                    CNProducto.Guardar(
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

                    MessageBox.Show("Producto registrado correctamente", "Sistema de Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (this.Edit == true)
                {
                    CNProducto.Editar(
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

                    MessageBox.Show("Producto actualizado correctamente", "Sistema de Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Insert = false;
                this.Edit = false;

                // ── MDI: vuelve a FrmListadoProducto dentro de FrmInicio ──────
                AbrirListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // ── Cancelar → vuelve al listado dentro del MDI ───────────────────────
        private void btncancelar_Click(object sender, EventArgs e)
        {
            AbrirListado();
        }

        // ── Helper: abre FrmListadoProducto en el MDI y cierra este form ──────
        private void AbrirListado()
        {
            FrmListadoProducto form = new FrmListadoProducto();
            form.MdiParent = this.MdiParent;
            form.Show();
            form.BringToFront();
            this.Close();
        }

        // ── Generar código de barras ──────────────────────────────────────────
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcodigo.Text))
            {
                MessageBox.Show("Ingresa un código antes de generar el código de barras.",
                    "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcodigo.Focus();
                return;
            }

            try
            {
                var writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.CODE_128,
                    Options = new EncodingOptions
                    {
                        Width = picBarcode.Width,
                        Height = picBarcode.Height,
                        Margin = 4
                    }
                };
                picBarcode.Image = writer.Write(txtcodigo.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar código de barras:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Imprimir código de barras ─────────────────────────────────────────
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (picBarcode.Image == null)
            {
                MessageBox.Show("Primero genera el código de barras.",
                    "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDialog pd = new PrintDialog();
            var doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawImage(picBarcode.Image,
                    new System.Drawing.Rectangle(10, 10, picBarcode.Width, picBarcode.Height));
            };
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }

        // ── Hover botones ─────────────────────────────────────────────────────
        private void btnguardar_MouseEnter(object sender, EventArgs e)
            => btnguardar.BackColor = System.Drawing.Color.FromArgb(30, 90, 180);
        private void btnguardar_MouseLeave(object sender, EventArgs e)
            => btnguardar.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);

        private void btncancelar_MouseEnter(object sender, EventArgs e)
            => btncancelar.BackColor = System.Drawing.Color.FromArgb(30, 90, 180);
        private void btncancelar_MouseLeave(object sender, EventArgs e)
            => btncancelar.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);

        private void btnGenerar_MouseEnter(object sender, EventArgs e)
            => btnGenerar.BackColor = System.Drawing.Color.FromArgb(30, 90, 180);
        private void btnGenerar_MouseLeave(object sender, EventArgs e)
            => btnGenerar.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);

        private void btnImprimir_MouseEnter(object sender, EventArgs e)
            => btnImprimir.BackColor = System.Drawing.Color.FromArgb(30, 90, 180);
        private void btnImprimir_MouseLeave(object sender, EventArgs e)
            => btnImprimir.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
    }
}