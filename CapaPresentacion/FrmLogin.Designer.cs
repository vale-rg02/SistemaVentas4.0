// Archivo nuevo → agrégalo al proyecto CapaPresentacion
namespace CapaPresentacion
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuarioLbl;
        private System.Windows.Forms.Label lblPasswordLbl;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox chkMostrarPass;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuarioLbl = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPasswordLbl = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkMostrarPass = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();

            this.pnlCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // ── Formulario ───────────────────────────
            this.Text = "Sistema de Ventas - Iniciar sesion";
            this.ClientSize = new System.Drawing.Size(420, 520);
            this.BackColor = System.Drawing.Color.FromArgb(22, 42, 74);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5f);

            // ── pnlCard ──────────────────────────────
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Size = new System.Drawing.Size(340, 400);
            this.pnlCard.Location = new System.Drawing.Point(40, 60);

            // ── pnlHeader ────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 97, 180);
            this.pnlHeader.Size = new System.Drawing.Size(340, 90);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);

            // ── lblTitulo ────────────────────────────
            this.lblTitulo.Text = "Sistema de Ventas";
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Size = new System.Drawing.Size(340, 50);
            this.lblTitulo.Location = new System.Drawing.Point(0, 8);

            // ── lblSubtitulo ─────────────────────────
            this.lblSubtitulo.Text = "Inicia sesion para continuar";
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(180, 215, 255);
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblSubtitulo.AutoSize = false;
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSubtitulo.Size = new System.Drawing.Size(340, 20);
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 60);

            // ── lblUsuarioLbl ────────────────────────
            this.lblUsuarioLbl.Text = "Usuario";
            this.lblUsuarioLbl.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblUsuarioLbl.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblUsuarioLbl.AutoSize = true;
            this.lblUsuarioLbl.Location = new System.Drawing.Point(30, 118);

            // ── txtUsuario ───────────────────────────
            this.txtUsuario.Size = new System.Drawing.Size(280, 30);
            this.txtUsuario.Location = new System.Drawing.Point(30, 138);
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10.5f);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);

            // ── lblPasswordLbl ───────────────────────
            this.lblPasswordLbl.Text = "Contrasena";
            this.lblPasswordLbl.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblPasswordLbl.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblPasswordLbl.AutoSize = true;
            this.lblPasswordLbl.Location = new System.Drawing.Point(30, 188);

            // ── txtPassword ──────────────────────────
            this.txtPassword.Size = new System.Drawing.Size(280, 30);
            this.txtPassword.Location = new System.Drawing.Point(30, 208);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5f);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.MaxLength = 50;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);

            // ── chkMostrarPass ───────────────────────
            this.chkMostrarPass.Text = "Mostrar contrasena";
            this.chkMostrarPass.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.chkMostrarPass.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.chkMostrarPass.AutoSize = true;
            this.chkMostrarPass.Location = new System.Drawing.Point(30, 248);
            this.chkMostrarPass.CheckedChanged += new System.EventHandler(this.chkMostrarPass_CheckedChanged);

            // ── lblError ─────────────────────────────
            this.lblError.Text = "Usuario o contrasena incorrectos.";
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblError.AutoSize = false;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Size = new System.Drawing.Size(280, 22);
            this.lblError.Location = new System.Drawing.Point(30, 276);
            this.lblError.Visible = false;

            // ── btnIngresar ───────────────────────────
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(33, 97, 180);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnIngresar.Size = new System.Drawing.Size(280, 42);
            this.btnIngresar.Location = new System.Drawing.Point(30, 310);
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.MouseEnter += new System.EventHandler(this.btnIngresar_MouseEnter);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_MouseLeave);

            // ── Jerarquía de controles ────────────────
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);

            this.pnlCard.Controls.Add(this.pnlHeader);
            this.pnlCard.Controls.Add(this.lblUsuarioLbl);
            this.pnlCard.Controls.Add(this.txtUsuario);
            this.pnlCard.Controls.Add(this.lblPasswordLbl);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.chkMostrarPass);
            this.pnlCard.Controls.Add(this.lblError);
            this.pnlCard.Controls.Add(this.btnIngresar);

            this.Controls.Add(this.pnlCard);

            this.pnlCard.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}