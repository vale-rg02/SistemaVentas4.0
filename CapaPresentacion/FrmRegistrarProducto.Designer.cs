namespace CapaPresentacion
{
    partial class FrmRegistrarProducto
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
            this.lineaCodigo = new System.Windows.Forms.Panel();
            this.lineaNombre = new System.Windows.Forms.Panel();
            this.lineaDescripcion = new System.Windows.Forms.Panel();
            this.lineaPrecioCompra = new System.Windows.Forms.Panel();
            this.lineaPrecioVenta = new System.Windows.Forms.Panel();
            this.lineaCantidad = new System.Windows.Forms.Panel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.grpBarcode = new System.Windows.Forms.GroupBox();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.grpBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Nuevo Producto";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(0, 0);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(76, 20);
            this.txtidproducto.TabIndex = 1;
            this.txtidproducto.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(500, 460);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(155, 42);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            this.btncancelar.MouseEnter += new System.EventHandler(this.btncancelar_MouseEnter);
            this.btncancelar.MouseLeave += new System.EventHandler(this.btncancelar_MouseLeave);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(75, 460);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(155, 42);
            this.btnguardar.TabIndex = 31;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            this.btnguardar.MouseEnter += new System.EventHandler(this.btnguardar_MouseEnter);
            this.btnguardar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            // 
            // rbinactivo
            // 
            this.rbinactivo.AutoSize = true;
            this.rbinactivo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbinactivo.Location = new System.Drawing.Point(658, 225);
            this.rbinactivo.Name = "rbinactivo";
            this.rbinactivo.Size = new System.Drawing.Size(70, 21);
            this.rbinactivo.TabIndex = 29;
            this.rbinactivo.Text = "Inactivo";
            // 
            // rbactivo
            // 
            this.rbactivo.AutoSize = true;
            this.rbactivo.Checked = true;
            this.rbactivo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbactivo.Location = new System.Drawing.Point(590, 225);
            this.rbactivo.Name = "rbactivo";
            this.rbactivo.Size = new System.Drawing.Size(61, 21);
            this.rbactivo.TabIndex = 28;
            this.rbactivo.TabStop = true;
            this.rbactivo.Text = "Activo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.White;
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodigo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtcodigo.Location = new System.Drawing.Point(30, 83);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(320, 19);
            this.txtcodigo.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtnombre.Location = new System.Drawing.Point(30, 153);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(320, 19);
            this.txtnombre.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.label7.Location = new System.Drawing.Point(590, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Seleccione estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.label6.Location = new System.Drawing.Point(590, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Precio Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.label5.Location = new System.Drawing.Point(30, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ingrese Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(30, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(410, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Precio Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(30, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.label8.Location = new System.Drawing.Point(590, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha Vencimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.label9.Location = new System.Drawing.Point(410, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fecha Ingreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.label10.Location = new System.Drawing.Point(410, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ingrese Cantidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.label12.Location = new System.Drawing.Point(30, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Categoria";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.White;
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescripcion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtdescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtdescripcion.Location = new System.Drawing.Point(30, 223);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(320, 19);
            this.txtdescripcion.TabIndex = 10;
            // 
            // dtfechaingreso
            // 
            this.dtfechaingreso.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtfechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaingreso.Location = new System.Drawing.Point(410, 83);
            this.dtfechaingreso.Name = "dtfechaingreso";
            this.dtfechaingreso.Size = new System.Drawing.Size(155, 24);
            this.dtfechaingreso.TabIndex = 15;
            // 
            // dtfechavencimiento
            // 
            this.dtfechavencimiento.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtfechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechavencimiento.Location = new System.Drawing.Point(590, 83);
            this.dtfechavencimiento.Name = "dtfechavencimiento";
            this.dtfechavencimiento.Size = new System.Drawing.Size(155, 24);
            this.dtfechavencimiento.TabIndex = 17;
            // 
            // cboidcategoria
            // 
            this.cboidcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboidcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboidcategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboidcategoria.Location = new System.Drawing.Point(30, 288);
            this.cboidcategoria.Name = "cboidcategoria";
            this.cboidcategoria.Size = new System.Drawing.Size(320, 25);
            this.cboidcategoria.TabIndex = 13;
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.BackColor = System.Drawing.Color.White;
            this.txtpreciocompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpreciocompra.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtpreciocompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtpreciocompra.Location = new System.Drawing.Point(410, 153);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(150, 19);
            this.txtpreciocompra.TabIndex = 19;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.BackColor = System.Drawing.Color.White;
            this.txtprecioventa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprecioventa.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtprecioventa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtprecioventa.Location = new System.Drawing.Point(590, 153);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(150, 19);
            this.txtprecioventa.TabIndex = 22;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.White;
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidad.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtcantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtcantidad.Location = new System.Drawing.Point(410, 223);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(150, 19);
            this.txtcantidad.TabIndex = 25;
            // 
            // lineaCodigo
            // 
            this.lineaCodigo.BackColor = System.Drawing.SystemColors.Highlight;
            this.lineaCodigo.Location = new System.Drawing.Point(30, 107);
            this.lineaCodigo.Name = "lineaCodigo";
            this.lineaCodigo.Size = new System.Drawing.Size(320, 2);
            this.lineaCodigo.TabIndex = 5;
            // 
            // lineaNombre
            // 
            this.lineaNombre.BackColor = System.Drawing.SystemColors.Highlight;
            this.lineaNombre.Location = new System.Drawing.Point(30, 177);
            this.lineaNombre.Name = "lineaNombre";
            this.lineaNombre.Size = new System.Drawing.Size(320, 2);
            this.lineaNombre.TabIndex = 8;
            // 
            // lineaDescripcion
            // 
            this.lineaDescripcion.BackColor = System.Drawing.SystemColors.Highlight;
            this.lineaDescripcion.Location = new System.Drawing.Point(30, 247);
            this.lineaDescripcion.Name = "lineaDescripcion";
            this.lineaDescripcion.Size = new System.Drawing.Size(320, 2);
            this.lineaDescripcion.TabIndex = 11;
            // 
            // lineaPrecioCompra
            // 
            this.lineaPrecioCompra.BackColor = System.Drawing.SystemColors.Highlight;
            this.lineaPrecioCompra.Location = new System.Drawing.Point(410, 177);
            this.lineaPrecioCompra.Name = "lineaPrecioCompra";
            this.lineaPrecioCompra.Size = new System.Drawing.Size(150, 2);
            this.lineaPrecioCompra.TabIndex = 20;
            // 
            // lineaPrecioVenta
            // 
            this.lineaPrecioVenta.BackColor = System.Drawing.SystemColors.Highlight;
            this.lineaPrecioVenta.Location = new System.Drawing.Point(590, 177);
            this.lineaPrecioVenta.Name = "lineaPrecioVenta";
            this.lineaPrecioVenta.Size = new System.Drawing.Size(150, 2);
            this.lineaPrecioVenta.TabIndex = 23;
            // 
            // lineaCantidad
            // 
            this.lineaCantidad.BackColor = System.Drawing.SystemColors.Highlight;
            this.lineaCantidad.Location = new System.Drawing.Point(410, 247);
            this.lineaCantidad.Name = "lineaCantidad";
            this.lineaCantidad.Size = new System.Drawing.Size(150, 2);
            this.lineaCantidad.TabIndex = 26;
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pnlDivider.Location = new System.Drawing.Point(388, 55);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(1, 450);
            this.pnlDivider.TabIndex = 2;
            // 
            // grpBarcode
            // 
            this.grpBarcode.Controls.Add(this.picBarcode);
            this.grpBarcode.Controls.Add(this.btnGenerar);
            this.grpBarcode.Controls.Add(this.btnImprimir);
            this.grpBarcode.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.grpBarcode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBarcode.Location = new System.Drawing.Point(410, 262);
            this.grpBarcode.Name = "grpBarcode";
            this.grpBarcode.Size = new System.Drawing.Size(345, 155);
            this.grpBarcode.TabIndex = 30;
            this.grpBarcode.TabStop = false;
            this.grpBarcode.Text = "Generar Codigo de Barras";
            // 
            // picBarcode
            // 
            this.picBarcode.BackColor = System.Drawing.Color.White;
            this.picBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBarcode.Location = new System.Drawing.Point(8, 22);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(210, 118);
            this.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarcode.TabIndex = 0;
            this.picBarcode.TabStop = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(228, 22);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 34);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            this.btnGenerar.MouseEnter += new System.EventHandler(this.btnGenerar_MouseEnter);
            this.btnGenerar.MouseLeave += new System.EventHandler(this.btnGenerar_MouseLeave);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(228, 70);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(105, 34);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseEnter += new System.EventHandler(this.btnImprimir_MouseEnter);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lineaCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lineaNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lineaDescripcion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboidcategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtfechaingreso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtfechavencimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpreciocompra);
            this.Controls.Add(this.lineaPrecioCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.lineaPrecioVenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lineaCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbactivo);
            this.Controls.Add(this.rbinactivo);
            this.Controls.Add(this.grpBarcode);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarProducto";
            this.Text = "FrmRegistrarProducto";
            this.Load += new System.EventHandler(this.FrmRegistrarProducto_Load);
            this.Shown += new System.EventHandler(this.FrmRegistrarProducto_Shown_1);
            this.grpBarcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
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
        private System.Windows.Forms.Panel lineaCodigo;
        private System.Windows.Forms.Panel lineaNombre;
        private System.Windows.Forms.Panel lineaDescripcion;
        private System.Windows.Forms.Panel lineaPrecioCompra;
        private System.Windows.Forms.Panel lineaPrecioVenta;
        private System.Windows.Forms.Panel lineaCantidad;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.GroupBox grpBarcode;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnImprimir;
    }
}