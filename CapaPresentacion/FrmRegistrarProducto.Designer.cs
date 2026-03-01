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
            this.rbtninactivo = new System.Windows.Forms.RadioButton();
            this.rbtnactivo = new System.Windows.Forms.RadioButton();
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
            this.numpventa = new System.Windows.Forms.NumericUpDown();
            this.numpcompra = new System.Windows.Forms.NumericUpDown();
            this.numstock = new System.Windows.Forms.NumericUpDown();
            this.dateingreso = new System.Windows.Forms.DateTimePicker();
            this.datevencimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numpventa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpcompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numstock)).BeginInit();
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
            // rbtninactivo
            // 
            this.rbtninactivo.AutoSize = true;
            this.rbtninactivo.Enabled = false;
            this.rbtninactivo.Location = new System.Drawing.Point(115, 465);
            this.rbtninactivo.Name = "rbtninactivo";
            this.rbtninactivo.Size = new System.Drawing.Size(74, 20);
            this.rbtninactivo.TabIndex = 30;
            this.rbtninactivo.TabStop = true;
            this.rbtninactivo.Text = "Inactivo";
            this.rbtninactivo.UseVisualStyleBackColor = true;
            // 
            // rbtnactivo
            // 
            this.rbtnactivo.AutoSize = true;
            this.rbtnactivo.Location = new System.Drawing.Point(44, 464);
            this.rbtnactivo.Name = "rbtnactivo";
            this.rbtnactivo.Size = new System.Drawing.Size(65, 20);
            this.rbtnactivo.TabIndex = 29;
            this.rbtnactivo.TabStop = true;
            this.rbtnactivo.Text = "Activo";
            this.rbtnactivo.UseVisualStyleBackColor = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(297, 137);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(246, 22);
            this.txtcodigo.TabIndex = 28;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(43, 137);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(235, 22);
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
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Stock";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "IdCategoria";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(43, 299);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(235, 22);
            this.txtdescripcion.TabIndex = 26;
            // 
            // numpventa
            // 
            this.numpventa.Location = new System.Drawing.Point(298, 223);
            this.numpventa.Name = "numpventa";
            this.numpventa.Size = new System.Drawing.Size(120, 22);
            this.numpventa.TabIndex = 43;
            // 
            // numpcompra
            // 
            this.numpcompra.Location = new System.Drawing.Point(44, 223);
            this.numpcompra.Name = "numpcompra";
            this.numpcompra.Size = new System.Drawing.Size(120, 22);
            this.numpcompra.TabIndex = 44;
            // 
            // numstock
            // 
            this.numstock.Location = new System.Drawing.Point(298, 464);
            this.numstock.Name = "numstock";
            this.numstock.Size = new System.Drawing.Size(120, 22);
            this.numstock.TabIndex = 45;
            // 
            // dateingreso
            // 
            this.dateingreso.Location = new System.Drawing.Point(44, 382);
            this.dateingreso.Name = "dateingreso";
            this.dateingreso.Size = new System.Drawing.Size(200, 22);
            this.dateingreso.TabIndex = 47;
            // 
            // datevencimiento
            // 
            this.datevencimiento.Location = new System.Drawing.Point(298, 382);
            this.datevencimiento.Name = "datevencimiento";
            this.datevencimiento.Size = new System.Drawing.Size(200, 22);
            this.datevencimiento.TabIndex = 48;
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.Location = new System.Drawing.Point(297, 299);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbcategoria.TabIndex = 0;
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 592);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.datevencimiento);
            this.Controls.Add(this.dateingreso);
            this.Controls.Add(this.numstock);
            this.Controls.Add(this.numpcompra);
            this.Controls.Add(this.numpventa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rbtninactivo);
            this.Controls.Add(this.rbtnactivo);
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
            ((System.ComponentModel.ISupportInitialize)(this.numpventa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpcompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.RadioButton rbtninactivo;
        public System.Windows.Forms.RadioButton rbtnactivo;
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
        public System.Windows.Forms.NumericUpDown numpcompra;
        public System.Windows.Forms.NumericUpDown numpventa;
        public System.Windows.Forms.NumericUpDown numstock;
        public System.Windows.Forms.DateTimePicker dateingreso;
        public System.Windows.Forms.DateTimePicker datevencimiento;
        public System.Windows.Forms.ComboBox cmbcategoria;
    }
}