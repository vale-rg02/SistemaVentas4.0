namespace CapaPresentacion
{
    partial class FrmRegistrarCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.rbtnactivo = new System.Windows.Forms.RadioButton();
            this.rbtninactivo = new System.Windows.Forms.RadioButton();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Nuevo Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "RFC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Seleccione estado";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(44, 125);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(235, 22);
            this.txtnombre.TabIndex = 7;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(44, 207);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(235, 22);
            this.txtapellidos.TabIndex = 8;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(44, 284);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(235, 22);
            this.txtdni.TabIndex = 9;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(298, 207);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(246, 22);
            this.txttelefono.TabIndex = 10;
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(298, 125);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(246, 22);
            this.txtrfc.TabIndex = 11;
            // 
            // rbtnactivo
            // 
            this.rbtnactivo.AutoSize = true;
            this.rbtnactivo.Location = new System.Drawing.Point(298, 285);
            this.rbtnactivo.Name = "rbtnactivo";
            this.rbtnactivo.Size = new System.Drawing.Size(65, 20);
            this.rbtnactivo.TabIndex = 12;
            this.rbtnactivo.TabStop = true;
            this.rbtnactivo.Text = "Activo";
            this.rbtnactivo.UseVisualStyleBackColor = true;
            // 
            // rbtninactivo
            // 
            this.rbtninactivo.AutoSize = true;
            this.rbtninactivo.Enabled = false;
            this.rbtninactivo.Location = new System.Drawing.Point(369, 286);
            this.rbtninactivo.Name = "rbtninactivo";
            this.rbtninactivo.Size = new System.Drawing.Size(74, 20);
            this.rbtninactivo.TabIndex = 13;
            this.rbtninactivo.TabStop = true;
            this.rbtninactivo.Text = "Inactivo";
            this.rbtninactivo.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(431, 415);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 14;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(513, 415);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(174, 76);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(100, 22);
            this.txtidcliente.TabIndex = 16;
            this.txtidcliente.Visible = false;
            // 
            // FrmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rbtninactivo);
            this.Controls.Add(this.rbtnactivo);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarCliente";
            this.Text = "FrmRegistrarCliente";
            this.Load += new System.EventHandler(this.FrmRegistrarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txtapellidos;
        public System.Windows.Forms.TextBox txtdni;
        public System.Windows.Forms.TextBox txttelefono;
        public System.Windows.Forms.TextBox txtrfc;
        public System.Windows.Forms.RadioButton rbtnactivo;
        public System.Windows.Forms.RadioButton rbtninactivo;
        public System.Windows.Forms.TextBox txtidcliente;
    }
}