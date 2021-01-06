
namespace ProyectoPedido
{
    partial class frmAgregarPedido
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.txtCantidadProductos = new System.Windows.Forms.TextBox();
            this.btnDownProductos = new System.Windows.Forms.Button();
            this.btnUpProductos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbEncargo = new System.Windows.Forms.GroupBox();
            this.btnSearchFolder = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarEncargo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioEncargo = new System.Windows.Forms.TextBox();
            this.cmbMedidas = new System.Windows.Forms.ComboBox();
            this.btnAgregarEncargo = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbTiempoEstimado = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtCantidadEncargo = new System.Windows.Forms.TextBox();
            this.cmbCantidadEncargo = new System.Windows.Forms.ComboBox();
            this.lbEncargos = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEncargo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtbObservaciones = new System.Windows.Forms.RichTextBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.fbdDirectorio = new System.Windows.Forms.FolderBrowserDialog();
            this.gbProducto.SuspendLayout();
            this.gbEncargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Plum;
            this.btnCancelar.Location = new System.Drawing.Point(304, 565);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Plum;
            this.btnAgregar.Location = new System.Drawing.Point(540, 565);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 32);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(22, 46);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(202, 23);
            this.txtProducto.TabIndex = 21;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(53, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(202, 20);
            this.txtUsuario.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(104, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Producto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(108, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha de entrada: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(132, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario:";
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Location = new System.Drawing.Point(53, 77);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(202, 20);
            this.dtpFechaEntrada.TabIndex = 28;
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.label9);
            this.gbProducto.Controls.Add(this.label8);
            this.gbProducto.Controls.Add(this.txtPrecioProducto);
            this.gbProducto.Controls.Add(this.btnEliminarProducto);
            this.gbProducto.Controls.Add(this.btnAgregarProducto);
            this.gbProducto.Controls.Add(this.lbProductos);
            this.gbProducto.Controls.Add(this.txtCantidadProductos);
            this.gbProducto.Controls.Add(this.btnDownProductos);
            this.gbProducto.Controls.Add(this.btnUpProductos);
            this.gbProducto.Controls.Add(this.label6);
            this.gbProducto.Controls.Add(this.label3);
            this.gbProducto.Controls.Add(this.txtProducto);
            this.gbProducto.Font = new System.Drawing.Font("Lato Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbProducto.Location = new System.Drawing.Point(306, 348);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(652, 175);
            this.gbProducto.TabIndex = 29;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "PRODUCTOS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(188, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 27);
            this.label9.TabIndex = 36;
            this.label9.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(185, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Precio de unidad:";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPrecioProducto.Location = new System.Drawing.Point(209, 127);
            this.txtPrecioProducto.MaxLength = 8;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(70, 23);
            this.txtPrecioProducto.TabIndex = 34;
            this.txtPrecioProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.Plum;
            this.btnEliminarProducto.Location = new System.Drawing.Point(256, 54);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(29, 23);
            this.btnEliminarProducto.TabIndex = 33;
            this.btnEliminarProducto.Text = "-";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Plum;
            this.btnAgregarProducto.Location = new System.Drawing.Point(256, 25);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(29, 23);
            this.btnAgregarProducto.TabIndex = 32;
            this.btnAgregarProducto.Text = "+";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.ItemHeight = 16;
            this.lbProductos.Location = new System.Drawing.Point(291, 25);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(302, 132);
            this.lbProductos.TabIndex = 31;
            // 
            // txtCantidadProductos
            // 
            this.txtCantidadProductos.Enabled = false;
            this.txtCantidadProductos.Location = new System.Drawing.Point(14, 99);
            this.txtCantidadProductos.Name = "txtCantidadProductos";
            this.txtCantidadProductos.Size = new System.Drawing.Size(84, 23);
            this.txtCantidadProductos.TabIndex = 30;
            this.txtCantidadProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDownProductos
            // 
            this.btnDownProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownProductos.ForeColor = System.Drawing.Color.Plum;
            this.btnDownProductos.Location = new System.Drawing.Point(104, 99);
            this.btnDownProductos.Name = "btnDownProductos";
            this.btnDownProductos.Size = new System.Drawing.Size(23, 23);
            this.btnDownProductos.TabIndex = 29;
            this.btnDownProductos.Text = "<";
            this.btnDownProductos.UseVisualStyleBackColor = true;
            this.btnDownProductos.Click += new System.EventHandler(this.btnDownProductos_Click);
            // 
            // btnUpProductos
            // 
            this.btnUpProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpProductos.ForeColor = System.Drawing.Color.Plum;
            this.btnUpProductos.Location = new System.Drawing.Point(127, 99);
            this.btnUpProductos.Name = "btnUpProductos";
            this.btnUpProductos.Size = new System.Drawing.Size(23, 23);
            this.btnUpProductos.TabIndex = 28;
            this.btnUpProductos.Text = ">";
            this.btnUpProductos.UseVisualStyleBackColor = true;
            this.btnUpProductos.Click += new System.EventHandler(this.btnUpProductos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(27, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(657, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 56);
            this.label7.TabIndex = 30;
            this.label7.Text = "TOTAL: $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Green;
            this.lblTotal.Location = new System.Drawing.Point(811, 553);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(123, 56);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "598,34";
            // 
            // gbEncargo
            // 
            this.gbEncargo.Controls.Add(this.btnSearchFolder);
            this.gbEncargo.Controls.Add(this.label22);
            this.gbEncargo.Controls.Add(this.txtDirectorio);
            this.gbEncargo.Controls.Add(this.label4);
            this.gbEncargo.Controls.Add(this.btnEliminarEncargo);
            this.gbEncargo.Controls.Add(this.label5);
            this.gbEncargo.Controls.Add(this.txtPrecioEncargo);
            this.gbEncargo.Controls.Add(this.cmbMedidas);
            this.gbEncargo.Controls.Add(this.btnAgregarEncargo);
            this.gbEncargo.Controls.Add(this.label18);
            this.gbEncargo.Controls.Add(this.txtCantidadDias);
            this.gbEncargo.Controls.Add(this.label17);
            this.gbEncargo.Controls.Add(this.cmbTiempoEstimado);
            this.gbEncargo.Controls.Add(this.label16);
            this.gbEncargo.Controls.Add(this.cmbMaterial);
            this.gbEncargo.Controls.Add(this.label15);
            this.gbEncargo.Controls.Add(this.label14);
            this.gbEncargo.Controls.Add(this.txtAlto);
            this.gbEncargo.Controls.Add(this.txtAncho);
            this.gbEncargo.Controls.Add(this.txtCantidadEncargo);
            this.gbEncargo.Controls.Add(this.cmbCantidadEncargo);
            this.gbEncargo.Controls.Add(this.lbEncargos);
            this.gbEncargo.Controls.Add(this.label12);
            this.gbEncargo.Controls.Add(this.label11);
            this.gbEncargo.Controls.Add(this.label10);
            this.gbEncargo.Controls.Add(this.txtEncargo);
            this.gbEncargo.Font = new System.Drawing.Font("Lato Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEncargo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbEncargo.Location = new System.Drawing.Point(306, 15);
            this.gbEncargo.Name = "gbEncargo";
            this.gbEncargo.Size = new System.Drawing.Size(652, 327);
            this.gbEncargo.TabIndex = 32;
            this.gbEncargo.TabStop = false;
            this.gbEncargo.Text = "ENCARGO";
            // 
            // btnSearchFolder
            // 
            this.btnSearchFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFolder.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFolder.ForeColor = System.Drawing.Color.Plum;
            this.btnSearchFolder.Location = new System.Drawing.Point(228, 141);
            this.btnSearchFolder.Name = "btnSearchFolder";
            this.btnSearchFolder.Size = new System.Drawing.Size(29, 23);
            this.btnSearchFolder.TabIndex = 37;
            this.btnSearchFolder.Text = "...";
            this.btnSearchFolder.UseVisualStyleBackColor = true;
            this.btnSearchFolder.Click += new System.EventHandler(this.btnSearchFolder_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(22, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 20);
            this.label22.TabIndex = 47;
            this.label22.Text = "Directorio: ";
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(20, 141);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Size = new System.Drawing.Size(202, 25);
            this.txtDirectorio.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(30, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 27);
            this.label4.TabIndex = 39;
            this.label4.Text = "$";
            // 
            // btnEliminarEncargo
            // 
            this.btnEliminarEncargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEncargo.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEncargo.ForeColor = System.Drawing.Color.Plum;
            this.btnEliminarEncargo.Location = new System.Drawing.Point(107, 212);
            this.btnEliminarEncargo.Name = "btnEliminarEncargo";
            this.btnEliminarEncargo.Size = new System.Drawing.Size(29, 23);
            this.btnEliminarEncargo.TabIndex = 38;
            this.btnEliminarEncargo.Text = "-";
            this.btnEliminarEncargo.UseVisualStyleBackColor = true;
            this.btnEliminarEncargo.Click += new System.EventHandler(this.btnEliminarEncargo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(61, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Precio: ";
            // 
            // txtPrecioEncargo
            // 
            this.txtPrecioEncargo.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPrecioEncargo.Location = new System.Drawing.Point(53, 283);
            this.txtPrecioEncargo.MaxLength = 6;
            this.txtPrecioEncargo.Name = "txtPrecioEncargo";
            this.txtPrecioEncargo.Size = new System.Drawing.Size(59, 25);
            this.txtPrecioEncargo.TabIndex = 37;
            this.txtPrecioEncargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbMedidas
            // 
            this.cmbMedidas.FormattingEnabled = true;
            this.cmbMedidas.Items.AddRange(new object[] {
            "3cm",
            "4cm",
            "5cm",
            "6cm",
            "7cm",
            "8cm",
            "9cm",
            "10cm",
            "15cm",
            "Otro..."});
            this.cmbMedidas.Location = new System.Drawing.Point(382, 50);
            this.cmbMedidas.Name = "cmbMedidas";
            this.cmbMedidas.Size = new System.Drawing.Size(112, 26);
            this.cmbMedidas.TabIndex = 45;
            this.cmbMedidas.SelectedIndexChanged += new System.EventHandler(this.cmbMedidas_SelectedIndexChanged);
            // 
            // btnAgregarEncargo
            // 
            this.btnAgregarEncargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEncargo.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEncargo.ForeColor = System.Drawing.Color.Plum;
            this.btnAgregarEncargo.Location = new System.Drawing.Point(107, 183);
            this.btnAgregarEncargo.Name = "btnAgregarEncargo";
            this.btnAgregarEncargo.Size = new System.Drawing.Size(29, 23);
            this.btnAgregarEncargo.TabIndex = 37;
            this.btnAgregarEncargo.Text = "+";
            this.btnAgregarEncargo.UseVisualStyleBackColor = true;
            this.btnAgregarEncargo.Click += new System.EventHandler(this.btnAgregarEncargo_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(596, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 20);
            this.label18.TabIndex = 44;
            this.label18.Text = "dias.";
            this.label18.Visible = false;
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Location = new System.Drawing.Point(559, 151);
            this.txtCantidadDias.MaxLength = 3;
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(37, 25);
            this.txtCantidadDias.TabIndex = 43;
            this.txtCantidadDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidadDias.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(362, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 20);
            this.label17.TabIndex = 42;
            this.label17.Text = "Tiempo estimado:";
            // 
            // cmbTiempoEstimado
            // 
            this.cmbTiempoEstimado.FormattingEnabled = true;
            this.cmbTiempoEstimado.Items.AddRange(new object[] {
            "1 dia",
            "3 dias",
            "5 dias",
            "10 dias",
            "15 dias",
            "20 dias",
            "30 dias",
            "Otro..."});
            this.cmbTiempoEstimado.Location = new System.Drawing.Point(466, 150);
            this.cmbTiempoEstimado.Name = "cmbTiempoEstimado";
            this.cmbTiempoEstimado.Size = new System.Drawing.Size(87, 26);
            this.cmbTiempoEstimado.TabIndex = 41;
            this.cmbTiempoEstimado.SelectedIndexChanged += new System.EventHandler(this.cmbTiempoEstimado_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(533, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "Material:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Items.AddRange(new object[] {
            "Autoadhesivo",
            "Transp. / OPP",
            "Metalizado"});
            this.cmbMaterial.Location = new System.Drawing.Point(500, 50);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(130, 26);
            this.cmbMaterial.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(406, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "Medidas: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(430, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 24);
            this.label14.TabIndex = 37;
            this.label14.Text = "x";
            this.label14.Visible = false;
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(449, 78);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(37, 25);
            this.txtAlto.TabIndex = 36;
            this.txtAlto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAlto.Visible = false;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(390, 78);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(37, 25);
            this.txtAncho.TabIndex = 35;
            this.txtAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAncho.Visible = false;
            // 
            // txtCantidadEncargo
            // 
            this.txtCantidadEncargo.Location = new System.Drawing.Point(311, 50);
            this.txtCantidadEncargo.Name = "txtCantidadEncargo";
            this.txtCantidadEncargo.Size = new System.Drawing.Size(65, 25);
            this.txtCantidadEncargo.TabIndex = 34;
            this.txtCantidadEncargo.Text = "2500";
            this.txtCantidadEncargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidadEncargo.Visible = false;
            // 
            // cmbCantidadEncargo
            // 
            this.cmbCantidadEncargo.FormattingEnabled = true;
            this.cmbCantidadEncargo.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "500",
            "1000",
            "2000",
            "Otro..."});
            this.cmbCantidadEncargo.Location = new System.Drawing.Point(239, 50);
            this.cmbCantidadEncargo.Name = "cmbCantidadEncargo";
            this.cmbCantidadEncargo.Size = new System.Drawing.Size(65, 26);
            this.cmbCantidadEncargo.TabIndex = 33;
            this.cmbCantidadEncargo.Text = "100";
            this.cmbCantidadEncargo.SelectedIndexChanged += new System.EventHandler(this.cmbCantidad_SelectedIndexChanged);
            // 
            // lbEncargos
            // 
            this.lbEncargos.FormattingEnabled = true;
            this.lbEncargos.ItemHeight = 18;
            this.lbEncargos.Location = new System.Drawing.Point(139, 183);
            this.lbEncargos.Name = "lbEncargos";
            this.lbEncargos.Size = new System.Drawing.Size(491, 130);
            this.lbEncargos.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(224, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "x";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(236, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cantidad: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(16, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Encargo: ";
            // 
            // txtEncargo
            // 
            this.txtEncargo.Location = new System.Drawing.Point(20, 50);
            this.txtEncargo.Name = "txtEncargo";
            this.txtEncargo.Size = new System.Drawing.Size(202, 25);
            this.txtEncargo.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(114, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Observaciones";
            // 
            // rtbObservaciones
            // 
            this.rtbObservaciones.Font = new System.Drawing.Font("Lato Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.rtbObservaciones.Location = new System.Drawing.Point(22, 179);
            this.rtbObservaciones.MaxLength = 500;
            this.rtbObservaciones.Name = "rtbObservaciones";
            this.rtbObservaciones.Size = new System.Drawing.Size(261, 98);
            this.rtbObservaciones.TabIndex = 33;
            this.rtbObservaciones.Text = "";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(53, 128);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(202, 20);
            this.dtpFechaEntrega.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(104, 105);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 20);
            this.label20.TabIndex = 37;
            this.label20.Text = "Fecha de entrega:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(70, 303);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 37);
            this.label21.TabIndex = 39;
            this.label21.Text = "DEUDA:";
            // 
            // txtDeuda
            // 
            this.txtDeuda.Font = new System.Drawing.Font("Lato Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeuda.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtDeuda.Location = new System.Drawing.Point(182, 308);
            this.txtDeuda.MaxLength = 8;
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(70, 23);
            this.txtDeuda.TabIndex = 40;
            this.txtDeuda.Text = "0";
            this.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label19.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Green;
            this.label19.Location = new System.Drawing.Point(153, 304);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 37);
            this.label19.TabIndex = 41;
            this.label19.Text = "$";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmAgregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(970, 607);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rtbObservaciones);
            this.Controls.Add(this.gbEncargo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarPedido";
            this.Load += new System.EventHandler(this.frmAgregarPedido_Load);
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.gbEncargo.ResumeLayout(false);
            this.gbEncargo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidadProductos;
        private System.Windows.Forms.Button btnDownProductos;
        private System.Windows.Forms.Button btnUpProductos;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbEncargo;
        private System.Windows.Forms.ComboBox cmbCantidadEncargo;
        private System.Windows.Forms.ListBox lbEncargos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEncargo;
        private System.Windows.Forms.TextBox txtCantidadEncargo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbTiempoEstimado;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbMedidas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtbObservaciones;
        private System.Windows.Forms.Button btnEliminarEncargo;
        private System.Windows.Forms.Button btnAgregarEncargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioEncargo;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSearchFolder;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectorio;
    }
}