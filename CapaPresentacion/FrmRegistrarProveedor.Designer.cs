namespace CapaPresentacion
{
    partial class FrmRegistrarProveedor
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
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.rbtninactivo = new System.Windows.Forms.RadioButton();
            this.rbtnactivo = new System.Windows.Forms.RadioButton();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(139, 47);
            this.txtidproveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(76, 20);
            this.txtidproveedor.TabIndex = 33;
            this.txtidproveedor.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(393, 323);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(56, 19);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(332, 323);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(56, 19);
            this.btnguardar.TabIndex = 31;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // rbtninactivo
            // 
            this.rbtninactivo.AutoSize = true;
            this.rbtninactivo.Enabled = false;
            this.rbtninactivo.Location = new System.Drawing.Point(285, 218);
            this.rbtninactivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtninactivo.Name = "rbtninactivo";
            this.rbtninactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtninactivo.TabIndex = 30;
            this.rbtninactivo.TabStop = true;
            this.rbtninactivo.Text = "Inactivo";
            this.rbtninactivo.UseVisualStyleBackColor = true;
            // 
            // rbtnactivo
            // 
            this.rbtnactivo.AutoSize = true;
            this.rbtnactivo.Location = new System.Drawing.Point(232, 217);
            this.rbtnactivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnactivo.Name = "rbtnactivo";
            this.rbtnactivo.Size = new System.Drawing.Size(55, 17);
            this.rbtnactivo.TabIndex = 29;
            this.rbtnactivo.TabStop = true;
            this.rbtnactivo.Text = "Activo";
            this.rbtnactivo.UseVisualStyleBackColor = true;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(232, 87);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(186, 20);
            this.txttelefono.TabIndex = 28;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(232, 154);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(186, 20);
            this.txtdireccion.TabIndex = 27;
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(41, 216);
            this.txtrfc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(177, 20);
            this.txtrfc.TabIndex = 26;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(41, 154);
            this.txtdni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(177, 20);
            this.txtdni.TabIndex = 25;
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.Location = new System.Drawing.Point(41, 87);
            this.txtrazonsocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(177, 20);
            this.txtrazonsocial.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Seleccione estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Razón Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registrar Nuevo Proveedor";
            // 
            // FrmRegistrarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 368);
            this.Controls.Add(this.txtidproveedor);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rbtninactivo);
            this.Controls.Add(this.rbtnactivo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtrazonsocial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRegistrarProveedor";
            this.Text = "FrmRegistrarProveedor";
            this.Load += new System.EventHandler(this.FrmRegistrarProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.RadioButton rbtninactivo;
        public System.Windows.Forms.RadioButton rbtnactivo;
        public System.Windows.Forms.TextBox txttelefono;
        public System.Windows.Forms.TextBox txtdireccion;
        public System.Windows.Forms.TextBox txtrfc;
        public System.Windows.Forms.TextBox txtdni;
        public System.Windows.Forms.TextBox txtrazonsocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}