namespace CapaPresentacion
{
    partial class FrmReporteFactura
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblWeb = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.pnlTipoDoc = new System.Windows.Forms.Panel();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblLblCliente = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblLblTel = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblLblDoc = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblLblTrab = new System.Windows.Forms.Label();
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.lblLblFecha = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.lblLblSub = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblLblIva = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.pnlLineaTot = new System.Windows.Forms.Panel();
            this.lblLblTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();

            this.pnlBusqueda.SuspendLayout();
            this.pnlFactura.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlEmpresa.SuspendLayout();
            this.pnlTipoDoc.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.pnlTotales.SuspendLayout();
            this.SuspendLayout();

            // ── Formulario ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(860, 620);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte de Factura";
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // ════════════════════════════════════════════════════════════════
            //  PANEL BÚSQUEDA
            // ════════════════════════════════════════════════════════════════
            this.pnlBusqueda.BackColor = System.Drawing.Color.White;
            this.pnlBusqueda.Location = new System.Drawing.Point(10, 10);
            this.pnlBusqueda.Size = new System.Drawing.Size(840, 52);
            this.pnlBusqueda.Name = "pnlBusqueda";

            this.lblBuscar.Text = "N° Factura:";
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(15, 16);

            this.txtIdVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdVenta.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtIdVenta.Location = new System.Drawing.Point(105, 12);
            this.txtIdVenta.Size = new System.Drawing.Size(120, 24);
            this.txtIdVenta.MaxLength = 10;
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdVenta_KeyDown);

            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(238, 10);
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.btnBuscar_MouseEnter);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);

            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(33, 150, 100);
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(350, 10);
            this.btnImprimir.Size = new System.Drawing.Size(120, 30);
            this.btnImprimir.Text = "Imprimir / Vista";
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseEnter += new System.EventHandler(this.btnImprimir_MouseEnter);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);

            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(730, 10);
            this.btnCerrar.Size = new System.Drawing.Size(95, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);

            this.pnlBusqueda.Controls.Add(this.lblBuscar);
            this.pnlBusqueda.Controls.Add(this.txtIdVenta);
            this.pnlBusqueda.Controls.Add(this.btnBuscar);
            this.pnlBusqueda.Controls.Add(this.btnImprimir);
            this.pnlBusqueda.Controls.Add(this.btnCerrar);

            // ════════════════════════════════════════════════════════════════
            //  PANEL FACTURA (fondo blanco)
            // ════════════════════════════════════════════════════════════════
            this.pnlFactura.BackColor = System.Drawing.Color.White;
            this.pnlFactura.Location = new System.Drawing.Point(10, 72);
            this.pnlFactura.Size = new System.Drawing.Size(840, 538);
            this.pnlFactura.Name = "pnlFactura";

            // ── Header (empresa + badge tipo doc) ────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(840, 80);
            this.pnlHeader.Name = "pnlHeader";

            // Panel empresa (azul)
            this.pnlEmpresa.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.pnlEmpresa.Location = new System.Drawing.Point(10, 8);
            this.pnlEmpresa.Size = new System.Drawing.Size(200, 65);
            this.pnlEmpresa.Name = "pnlEmpresa";

            this.lblEmpresa.Text = "MI EMPRESA";
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(8, 8);

            this.lblWeb.Text = "www.miempresa.com";
            this.lblWeb.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblWeb.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(8, 36);

            this.lblTel.Text = "Tel: 000-000-0000";
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(8, 50);

            this.pnlEmpresa.Controls.Add(this.lblEmpresa);
            this.pnlEmpresa.Controls.Add(this.lblWeb);
            this.pnlEmpresa.Controls.Add(this.lblTel);

            // Panel tipo documento (badge azul)
            this.pnlTipoDoc.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.pnlTipoDoc.Location = new System.Drawing.Point(630, 8);
            this.pnlTipoDoc.Size = new System.Drawing.Size(200, 38);
            this.pnlTipoDoc.Name = "pnlTipoDoc";

            this.lblTipoDoc.Text = "FACTURA";
            this.lblTipoDoc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTipoDoc.ForeColor = System.Drawing.Color.White;
            this.lblTipoDoc.AutoSize = false;
            this.lblTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTipoDoc.Size = new System.Drawing.Size(200, 38);
            this.lblTipoDoc.Location = new System.Drawing.Point(0, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";

            // Número de factura (debajo del badge)
            this.lblNumFactura.Text = "----";
            this.lblNumFactura.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNumFactura.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.Location = new System.Drawing.Point(638, 52);
            this.lblNumFactura.Name = "lblNumFactura";

            this.pnlTipoDoc.Controls.Add(this.lblTipoDoc);

            this.pnlHeader.Controls.Add(this.pnlEmpresa);
            this.pnlHeader.Controls.Add(this.pnlTipoDoc);
            this.pnlHeader.Controls.Add(this.lblNumFactura);

            // ── Panel datos cliente/trabajador ───────────────────────────────
            this.pnlDatos.BackColor = System.Drawing.Color.White;
            this.pnlDatos.Location = new System.Drawing.Point(0, 88);
            this.pnlDatos.Size = new System.Drawing.Size(840, 80);
            this.pnlDatos.Name = "pnlDatos";

            // Fila 1: Cliente + Teléfono
            this.lblLblCliente.Text = "Cliente:";
            this.lblLblCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLblCliente.AutoSize = true;
            this.lblLblCliente.Location = new System.Drawing.Point(15, 8);

            this.lblCliente.Text = "";
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(80, 8);
            this.lblCliente.Name = "lblCliente";

            this.lblLblTel.Text = "Teléfono:";
            this.lblLblTel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLblTel.AutoSize = true;
            this.lblLblTel.Location = new System.Drawing.Point(420, 8);

            this.lblTelefono.Text = "";
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(492, 8);
            this.lblTelefono.Name = "lblTelefono";

            // Fila 2: Documento
            this.lblLblDoc.Text = "Documento:";
            this.lblLblDoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLblDoc.AutoSize = true;
            this.lblLblDoc.Location = new System.Drawing.Point(15, 30);

            this.lblDocumento.Text = "";
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(95, 30);
            this.lblDocumento.Name = "lblDocumento";

            // Fila 3: Trabajador + Fecha
            this.lblLblTrab.Text = "Trabajador:";
            this.lblLblTrab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLblTrab.AutoSize = true;
            this.lblLblTrab.Location = new System.Drawing.Point(15, 52);

            this.lblTrabajador.Text = "";
            this.lblTrabajador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Location = new System.Drawing.Point(95, 52);
            this.lblTrabajador.Name = "lblTrabajador";

            this.lblLblFecha.Text = "Fecha:";
            this.lblLblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLblFecha.AutoSize = true;
            this.lblLblFecha.Location = new System.Drawing.Point(420, 52);

            this.lblFecha.Text = "";
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(468, 52);
            this.lblFecha.Name = "lblFecha";

            this.pnlDatos.Controls.Add(this.lblLblCliente);
            this.pnlDatos.Controls.Add(this.lblCliente);
            this.pnlDatos.Controls.Add(this.lblLblTel);
            this.pnlDatos.Controls.Add(this.lblTelefono);
            this.pnlDatos.Controls.Add(this.lblLblDoc);
            this.pnlDatos.Controls.Add(this.lblDocumento);
            this.pnlDatos.Controls.Add(this.lblLblTrab);
            this.pnlDatos.Controls.Add(this.lblTrabajador);
            this.pnlDatos.Controls.Add(this.lblLblFecha);
            this.pnlDatos.Controls.Add(this.lblFecha);

            // ── DataGridView detalle ──────────────────────────────────────────
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.AllowUserToDeleteRows = false;
            this.dgDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetalle.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.dgDetalle.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgDetalle.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgDetalle.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.dgDetalle.ColumnHeadersHeight = 32;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDetalle.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgDetalle.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(180, 210, 250);
            this.dgDetalle.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dgDetalle.EnableHeadersVisualStyles = false;
            this.dgDetalle.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgDetalle.Location = new System.Drawing.Point(10, 175);
            this.dgDetalle.MultiSelect = false;
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.ReadOnly = true;
            this.dgDetalle.RowHeadersVisible = false;
            this.dgDetalle.RowTemplate.Height = 26;
            this.dgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalle.Size = new System.Drawing.Size(820, 240);

            // ── Panel totales ─────────────────────────────────────────────────
            this.pnlTotales.BackColor = System.Drawing.Color.White;
            this.pnlTotales.Location = new System.Drawing.Point(530, 425);
            this.pnlTotales.Size = new System.Drawing.Size(300, 100);
            this.pnlTotales.Name = "pnlTotales";

            this.lblLblSub.Text = "Sub Total:";
            this.lblLblSub.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLblSub.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.lblLblSub.AutoSize = true;
            this.lblLblSub.Location = new System.Drawing.Point(0, 8);

            this.lblSubtotal.Text = "S/ 0.00";
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(170, 8);
            this.lblSubtotal.Name = "lblSubtotal";

            this.lblLblIva.Text = "IGV:";
            this.lblLblIva.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLblIva.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.lblLblIva.AutoSize = true;
            this.lblLblIva.Location = new System.Drawing.Point(0, 30);

            this.lblIva.Text = "S/ 0.00";
            this.lblIva.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIva.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(170, 30);
            this.lblIva.Name = "lblIva";

            // Línea divisora
            this.pnlLineaTot.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.pnlLineaTot.Location = new System.Drawing.Point(0, 55);
            this.pnlLineaTot.Size = new System.Drawing.Size(300, 1);
            this.pnlLineaTot.Name = "pnlLineaTot";

            this.lblLblTotal.Text = "Total pagar:";
            this.lblLblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLblTotal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblLblTotal.AutoSize = true;
            this.lblLblTotal.Location = new System.Drawing.Point(0, 63);

            this.lblTotal.Text = "S/ 0.00";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(170, 63);
            this.lblTotal.Name = "lblTotal";

            this.pnlTotales.Controls.Add(this.lblLblSub);
            this.pnlTotales.Controls.Add(this.lblSubtotal);
            this.pnlTotales.Controls.Add(this.lblLblIva);
            this.pnlTotales.Controls.Add(this.lblIva);
            this.pnlTotales.Controls.Add(this.pnlLineaTot);
            this.pnlTotales.Controls.Add(this.lblLblTotal);
            this.pnlTotales.Controls.Add(this.lblTotal);

            // ── Ensamblar pnlFactura ──────────────────────────────────────────
            this.pnlFactura.Controls.Add(this.pnlHeader);
            this.pnlFactura.Controls.Add(this.pnlDatos);
            this.pnlFactura.Controls.Add(this.dgDetalle);
            this.pnlFactura.Controls.Add(this.pnlTotales);

            // ── Agregar al formulario ─────────────────────────────────────────
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlFactura);

            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlFactura.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlEmpresa.ResumeLayout(false);
            this.pnlEmpresa.PerformLayout();
            this.pnlTipoDoc.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            this.Load += new System.EventHandler(this.FrmReporteFactura_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlFactura;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Panel pnlTipoDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblLblCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblLblTel;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblLblDoc;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblLblTrab;
        private System.Windows.Forms.Label lblTrabajador;
        private System.Windows.Forms.Label lblLblFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgDetalle;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.Label lblLblSub;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblLblIva;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Panel pnlLineaTot;
        private System.Windows.Forms.Label lblLblTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}