namespace CapaPresentacion
{
    partial class FrmRegistrarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.rbinactivo = new System.Windows.Forms.RadioButton();
            this.rbactivo = new System.Windows.Forms.RadioButton();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.dtfechaingreso = new System.Windows.Forms.DateTimePicker();
            this.dtfechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.cboidcategoria = new System.Windows.Forms.ComboBox();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registrar Nuevo Producto";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(177, 62);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(100, 22);
            this.txtidproducto.TabIndex = 33;
            this.txtidproducto.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(468, 542);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(386, 542);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 31;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // rbinactivo
            // 
            this.rbinactivo.AutoSize = true;
            this.rbinactivo.Enabled = false;
            this.rbinactivo.Location = new System.Drawing.Point(115, 465);
            this.rbinactivo.Name = "rbinactivo";
            this.rbinactivo.Size = new System.Drawing.Size(74, 20);
            this.rbinactivo.TabIndex = 30;
            this.rbinactivo.TabStop = true;
            this.rbinactivo.Text = "Inactivo";
            this.rbinactivo.UseVisualStyleBackColor = true;
            // 
            // rbactivo
            // 
            this.rbactivo.AutoSize = true;
            this.rbactivo.Location = new System.Drawing.Point(44, 464);
            this.rbactivo.Name = "rbactivo";
            this.rbactivo.Size = new System.Drawing.Size(65, 20);
            this.rbactivo.TabIndex = 29;
            this.rbactivo.TabStop = true;
            this.rbactivo.Text = "Activo";
            this.rbactivo.UseVisualStyleBackColor = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(296, 137);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(138, 22);
            this.txtcodigo.TabIndex = 28;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(42, 137);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(159, 22);
            this.txtnombre.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Seleccione estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Precio de Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Precio de Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Fecha de Vencimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Fecha de Ingreso";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Cantidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "Categoria";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(42, 299);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(159, 22);
            this.txtdescripcion.TabIndex = 26;
            // 
            // dtfechaingreso
            // 
            this.dtfechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaingreso.Location = new System.Drawing.Point(44, 382);
            this.dtfechaingreso.Name = "dtfechaingreso";
            this.dtfechaingreso.Size = new System.Drawing.Size(109, 22);
            this.dtfechaingreso.TabIndex = 47;
            // 
            // dtfechavencimiento
            // 
            this.dtfechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechavencimiento.Location = new System.Drawing.Point(298, 382);
            this.dtfechavencimiento.Name = "dtfechavencimiento";
            this.dtfechavencimiento.Size = new System.Drawing.Size(109, 22);
            this.dtfechavencimiento.TabIndex = 47;
            // 
            // cboidcategoria
            // 
            this.cboidcategoria.Location = new System.Drawing.Point(297, 299);
            this.cboidcategoria.Name = "cboidcategoria";
            this.cboidcategoria.Size = new System.Drawing.Size(121, 24);
            this.cboidcategoria.TabIndex = 0;
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(42, 223);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(109, 22);
            this.txtpreciocompra.TabIndex = 48;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(295, 223);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(110, 22);
            this.txtprecioventa.TabIndex = 49;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(296, 463);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(110, 22);
            this.txtcantidad.TabIndex = 50;
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 592);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.txtpreciocompra);
            this.Controls.Add(this.cboidcategoria);
            this.Controls.Add(this.dtfechavencimiento);
            this.Controls.Add(this.dtfechaingreso);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rbinactivo);
            this.Controls.Add(this.rbactivo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarProducto";
            this.Text = "FrmRegistrarProducto";
            this.Load += new System.EventHandler(this.FrmRegistrarProducto_Load);
            this.Shown += new System.EventHandler(this.FrmRegistrarProducto_Shown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.RadioButton rbinactivo;
        public System.Windows.Forms.RadioButton rbactivo;
        public System.Windows.Forms.TextBox txtcodigo;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtdescripcion;
        public System.Windows.Forms.DateTimePicker dtfechaingreso;
        public System.Windows.Forms.DateTimePicker dtfechavencimiento;
        public System.Windows.Forms.ComboBox cboidcategoria;
        public System.Windows.Forms.TextBox txtpreciocompra;
        public System.Windows.Forms.TextBox txtprecioventa;
        public System.Windows.Forms.TextBox txtcantidad;
    }
}