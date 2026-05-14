namespace CapaPresentacion
{
    partial class FrmListadoVenta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnverdetalle = new System.Windows.Forms.Button();
            this.btnanular = new System.Windows.Forms.Button();

            this.panel1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();

            // ── Formulario ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoVenta";
            this.Text = "FrmListadoVenta";
            this.Load += new System.EventHandler(this.FrmListadoVenta_Load);

            // ── Título ────────────────────────────────────────────────────────
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Ventas";

            // ── Panel filtros ─────────────────────────────────────────────────
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(20, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 65);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Fecha Inicio
            this.lblFechaIni.Text = "FECHA INICIO";
            this.lblFechaIni.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFechaIni.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Location = new System.Drawing.Point(10, 10);

            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpInicio.Location = new System.Drawing.Point(10, 28);
            this.dtpInicio.Size = new System.Drawing.Size(145, 24);
            this.dtpInicio.Name = "dtpInicio";

            // Fecha Fin
            this.lblFechaFin.Text = "FECHA FIN";
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFechaFin.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(170, 10);

            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFin.Location = new System.Drawing.Point(170, 28);
            this.dtpFin.Size = new System.Drawing.Size(145, 24);
            this.dtpFin.Name = "dtpFin";

            // Buscar
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Location = new System.Drawing.Point(328, 20);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 32);
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            this.btnbuscar.MouseEnter += new System.EventHandler(this.BtnHoverEnter);
            this.btnbuscar.MouseLeave += new System.EventHandler(this.BtnHoverLeave);

            // Reporte
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(33, 150, 100);
            this.btnreporte.FlatAppearance.BorderSize = 0;
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreporte.Location = new System.Drawing.Point(440, 20);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(100, 32);
            this.btnreporte.Text = "REPORTE";
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            this.btnreporte.MouseEnter += new System.EventHandler(this.BtnVerdeHoverEnter);
            this.btnreporte.MouseLeave += new System.EventHandler(this.BtnVerdeHoverLeave);

            // Salir
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Location = new System.Drawing.Point(552, 20);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(100, 32);
            this.btnsalir.Text = "SALIR";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            this.btnsalir.MouseEnter += new System.EventHandler(this.BtnRojoHoverEnter);
            this.btnsalir.MouseLeave += new System.EventHandler(this.BtnRojoHoverLeave);

            this.panel1.Controls.Add(this.lblFechaIni);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.lblFechaFin);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.btnreporte);
            this.panel1.Controls.Add(this.btnsalir);

            // ── Panel Grid ────────────────────────────────────────────────────
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Location = new System.Drawing.Point(20, 125);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(740, 320);

            this.dlistado.AllowUserToAddRows = false;
            this.dlistado.AllowUserToDeleteRows = false;
            this.dlistado.BackgroundColor = System.Drawing.Color.White;
            this.dlistado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dlistado.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.dlistado.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dlistado.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dlistado.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.dlistado.ColumnHeadersHeight = 35;
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dlistado.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dlistado.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(180, 210, 250);
            this.dlistado.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dlistado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlistado.EnableHeadersVisualStyles = false;
            this.dlistado.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dlistado.MultiSelect = false;
            this.dlistado.Name = "dlistado";
            this.dlistado.ReadOnly = true;
            this.dlistado.RowHeadersVisible = false;
            this.dlistado.RowTemplate.Height = 28;
            this.dlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dlistado.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dlistado_RowPrePaint);

            this.pnlGrid.Controls.Add(this.dlistado);

            // ── Panel Botones inferiores ──────────────────────────────────────
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Location = new System.Drawing.Point(20, 455);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(740, 52);

            // Ver Detalle
            this.btnverdetalle.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.btnverdetalle.FlatAppearance.BorderSize = 0;
            this.btnverdetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverdetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnverdetalle.ForeColor = System.Drawing.Color.White;
            this.btnverdetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverdetalle.Location = new System.Drawing.Point(500, 8);
            this.btnverdetalle.Name = "btnverdetalle";
            this.btnverdetalle.Size = new System.Drawing.Size(115, 36);
            this.btnverdetalle.Text = "VER DETALLE";
            this.btnverdetalle.Click += new System.EventHandler(this.btnverdetalle_Click);
            this.btnverdetalle.MouseEnter += new System.EventHandler(this.BtnHoverEnter);
            this.btnverdetalle.MouseLeave += new System.EventHandler(this.BtnHoverLeave);

            // Anular
            this.btnanular.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnanular.FlatAppearance.BorderSize = 0;
            this.btnanular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnanular.ForeColor = System.Drawing.Color.White;
            this.btnanular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnanular.Location = new System.Drawing.Point(625, 8);
            this.btnanular.Name = "btnanular";
            this.btnanular.Size = new System.Drawing.Size(115, 36);
            this.btnanular.Text = "ANULAR";
            this.btnanular.Click += new System.EventHandler(this.btnanular_Click);
            this.btnanular.MouseEnter += new System.EventHandler(this.BtnRojoHoverEnter);
            this.btnanular.MouseLeave += new System.EventHandler(this.BtnRojoHoverLeave);

            this.pnlBotones.Controls.Add(this.btnverdetalle);
            this.pnlBotones.Controls.Add(this.btnanular);

            // ── Agregar al form ───────────────────────────────────────────────
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotones);

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel pnlGrid;
        public System.Windows.Forms.DataGridView dlistado;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnverdetalle;
        private System.Windows.Forms.Button btnanular;
    }
}