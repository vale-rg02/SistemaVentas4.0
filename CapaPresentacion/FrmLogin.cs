// Archivo nuevo → agrégalo al proyecto CapaPresentacion
using System;
using System.Data;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // ─────────────────────────────────────────────
        //  Evento: clic en botón Ingresar
        // ─────────────────────────────────────────────
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor ingresa usuario y contraseña.",
                    "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ValidarLogin();
        }

        // ─────────────────────────────────────────────
        //  Validación a través de CapaNegocio
        // ─────────────────────────────────────────────
        private void ValidarLogin()
        {
            try
            {
                CNUsuario cn = new CNUsuario();
                DataTable dt = cn.ValidarUsuario(
                    txtUsuario.Text.Trim(),
                    txtPassword.Text.Trim()
                );

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    SesionActual.IdUsuario = Convert.ToInt32(row["idusuario"]);
                    SesionActual.NombreUsuario = row["usuario"].ToString();
                    SesionActual.Acceso = row["acceso"].ToString();
                    SesionActual.NombreEmpleado = row["nombre"].ToString() + " " + row["apellidos"].ToString();

                    FrmInicio frm = new FrmInicio();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Visible = true;
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────────
        //  Teclado: Enter navega entre campos
        // ─────────────────────────────────────────────
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnIngresar_Click(sender, e);
            }
        }

        // ─────────────────────────────────────────────
        //  Ocultar error al escribir
        // ─────────────────────────────────────────────
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        // ─────────────────────────────────────────────
        //  Checkbox: mostrar/ocultar contraseña
        // ─────────────────────────────────────────────
        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkMostrarPass.Checked ? '\0' : '*';
        }

        // ─────────────────────────────────────────────
        //  Hover del botón Ingresar
        // ─────────────────────────────────────────────
        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.BackColor = System.Drawing.Color.FromArgb(25, 75, 145);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = System.Drawing.Color.FromArgb(33, 97, 180);
        }
    }
}