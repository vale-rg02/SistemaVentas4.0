namespace CapaPresentacion
{
    partial class FrmListadoCategoria
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
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreporte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();

            // ── Formulario ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoCategoria";
            this.Text = "FrmListadoCategoria";
            this.Load += new System.EventHandler(this.FrmListadoCategoria_Load);

            // ── Título ────────────────────────────────────────────────────────
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Text = "Categoría";

            // ════════════════════════════════════════════════════════════════
            //  PANEL BÚSQUEDA (panel1)
            // ════════════════════════════════════════════════════════════════
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(20, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 65);

            this.label2.Text = "Buscar Categoría";
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 22);
            this.label2.Name = "label2";

            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbuscar.Location = new System.Drawing.Point(130, 18);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(330, 24);
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);

            // Buscar
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Location = new System.Drawing.Point(472, 16);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(85, 28);
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            this.btnbuscar.MouseEnter += new System.EventHandler(this.BtnHoverEnter);
            this.btnbuscar.MouseLeave += new System.EventHandler(this.BtnHoverLeave);

            // Reporte (verde)
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(33, 150, 100);
            this.btnreporte.FlatAppearance.BorderSize = 0;
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreporte.Location = new System.Drawing.Point(568, 16);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(85, 28);
            this.btnreporte.Text = "Reporte";
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            this.btnreporte.MouseEnter += new System.EventHandler(this.BtnVerdeHoverEnter);
            this.btnreporte.MouseLeave += new System.EventHandler(this.BtnVerdeHoverLeave);

            // Salir (rojo)
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Location = new System.Drawing.Point(664, 16);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(72, 28);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            this.btnsalir.MouseEnter += new System.EventHandler(this.BtnRojoHoverEnter);
            this.btnsalir.MouseLeave += new System.EventHandler(this.BtnRojoHoverLeave);

            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.btnreporte);
            this.panel1.Controls.Add(this.btnsalir);

            // ════════════════════════════════════════════════════════════════
            //  PANEL GRID
            // ════════════════════════════════════════════════════════════════
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
            this.dlistado.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dlistado.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(180, 210, 250);
            this.dlistado.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dlistado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlistado.EnableHeadersVisualStyles = false;
            this.dlistado.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dlistado.MultiSelect = false;
            this.dlistado.Name = "dlistado";
            this.dlistado.ReadOnly = true;
            this.dlistado.RowHeadersVisible = false;
            this.dlistado.RowTemplate.Height = 30;
            this.dlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.pnlGrid.Controls.Add(this.dlistado);

            // ════════════════════════════════════════════════════════════════
            //  PANEL BOTONES INFERIORES
            // ════════════════════════════════════════════════════════════════
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Location = new System.Drawing.Point(20, 455);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(740, 52);

            // Nuevo
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.Location = new System.Drawing.Point(0, 8);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(110, 36);
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            this.btnnuevo.MouseEnter += new System.EventHandler(this.BtnHoverEnter);
            this.btnnuevo.MouseLeave += new System.EventHandler(this.BtnHoverLeave);

            // Editar
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.Location = new System.Drawing.Point(122, 8);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(110, 36);
            this.btneditar.Text = "Editar";
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            this.btneditar.MouseEnter += new System.EventHandler(this.BtnHoverEnter);
            this.btneditar.MouseLeave += new System.EventHandler(this.BtnHoverLeave);

            // Eliminar (rojo)
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Location = new System.Drawing.Point(244, 8);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(110, 36);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            this.btneliminar.MouseEnter += new System.EventHandler(this.BtnRojoHoverEnter);
            this.btneliminar.MouseLeave += new System.EventHandler(this.BtnRojoHoverLeave);

            this.pnlBotones.Controls.Add(this.btnnuevo);
            this.pnlBotones.Controls.Add(this.btneditar);
            this.pnlBotones.Controls.Add(this.btneliminar);

            // ── Agregar al formulario ─────────────────────────────────────────
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotones);

            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnnuevo;
        public System.Windows.Forms.DataGridView dlistado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnbuscar;
        public System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlGrid;
    }
}