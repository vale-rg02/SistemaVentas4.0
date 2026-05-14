namespace CapaPresentacion
{
    partial class FrmListadoProducto
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
            this.btnreporte = new System.Windows.Forms.Button();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtncodigo = new System.Windows.Forms.RadioButton();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.Producto = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════
            //  FORMULARIO
            // ════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoProducto";
            this.Text = "FrmListadoProducto";
            this.Load += new System.EventHandler(this.FrmListadoProducto_Load);

            // ── Título "Productos" ────────────────────────────────────────────
            this.Producto.AutoSize = true;
            this.Producto.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Producto.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.Producto.Location = new System.Drawing.Point(20, 15);
            this.Producto.Name = "Producto";
            this.Producto.Text = "Productos";

            // ════════════════════════════════════════════════════════════════
            //  PANEL DE BÚSQUEDA (panel1)
            // ════════════════════════════════════════════════════════════════
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(20, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 65);

            // GroupBox criterio (groupBox1)
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 58);
            this.groupBox1.Text = "Criterio de Busqueda";

            this.rbtnnombre.AutoSize = true;
            this.rbtnnombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbtnnombre.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.rbtnnombre.Location = new System.Drawing.Point(6, 28);
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.Text = "Nombre";

            this.rbtncodigo.AutoSize = true;
            this.rbtncodigo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbtncodigo.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.rbtncodigo.Location = new System.Drawing.Point(85, 28);
            this.rbtncodigo.Name = "rbtncodigo";
            this.rbtncodigo.Text = "Codigo";

            this.groupBox1.Controls.Add(this.rbtnnombre);
            this.groupBox1.Controls.Add(this.rbtncodigo);

            // TextBox buscar
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbuscar.Location = new System.Drawing.Point(182, 20);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(330, 24);

            // Botón Buscar
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Location = new System.Drawing.Point(524, 18);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(95, 28);
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            this.btnbuscar.MouseEnter += new System.EventHandler(this.BtnHoverEnter);
            this.btnbuscar.MouseLeave += new System.EventHandler(this.BtnHoverLeave);

            // Botón Salir (rojo)
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Location = new System.Drawing.Point(630, 18);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(95, 28);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            this.btnsalir.MouseEnter += new System.EventHandler(this.BtnSalirHoverEnter);
            this.btnsalir.MouseLeave += new System.EventHandler(this.BtnSalirHoverLeave);

            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.btnsalir);

            // ════════════════════════════════════════════════════════════════
            //  DATAGRIDVIEW (dlistado)
            // ════════════════════════════════════════════════════════════════
            this.dlistado.AllowUserToAddRows = false;
            this.dlistado.AllowUserToDeleteRows = false;
            this.dlistado.BackgroundColor = System.Drawing.Color.White;
            this.dlistado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dlistado.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.dlistado.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dlistado.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dlistado.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.dlistado.ColumnHeadersHeight = 35;
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dlistado.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dlistado.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(180, 210, 250);
            this.dlistado.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dlistado.EnableHeadersVisualStyles = false;
            this.dlistado.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dlistado.Location = new System.Drawing.Point(20, 128);
            this.dlistado.MultiSelect = false;
            this.dlistado.Name = "dlistado";
            this.dlistado.ReadOnly = true;
            this.dlistado.RowHeadersVisible = false;
            this.dlistado.RowTemplate.Height = 28;
            this.dlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dlistado.Size = new System.Drawing.Size(740, 320);

            // ════════════════════════════════════════════════════════════════
            //  BOTONES INFERIORES
            // ════════════════════════════════════════════════════════════════

            // Nuevo
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.Location = new System.Drawing.Point(20, 462);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(110, 36);
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click_1);
            this.btnnuevo.MouseEnter += new System.EventHandler(this.BtnHoverEnter);
            this.btnnuevo.MouseLeave += new System.EventHandler(this.BtnHoverLeave);

            // Editar
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(52, 120, 220);
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.Location = new System.Drawing.Point(142, 462);
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
            this.btneliminar.Location = new System.Drawing.Point(264, 462);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(110, 36);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            this.btneliminar.MouseEnter += new System.EventHandler(this.BtnSalirHoverEnter);
            this.btneliminar.MouseLeave += new System.EventHandler(this.BtnSalirHoverLeave);

            // Reporte Facturas (verde)
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(33, 150, 100);
            this.btnreporte.FlatAppearance.BorderSize = 0;
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreporte.Location = new System.Drawing.Point(386, 462);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(140, 36);
            this.btnreporte.Text = "Reporte Facturas";
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            this.btnreporte.MouseEnter += new System.EventHandler(this.BtnReporteHoverEnter);
            this.btnreporte.MouseLeave += new System.EventHandler(this.BtnReporteHoverLeave);

            // ── Agregar al formulario ─────────────────────────────────────────
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dlistado);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnreporte);

            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnreporte;
        public System.Windows.Forms.DataGridView dlistado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnbuscar;
        public System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rbtncodigo;
        public System.Windows.Forms.RadioButton rbtnnombre;
        private System.Windows.Forms.Label Producto;
    }
}