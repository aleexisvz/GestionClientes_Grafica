
namespace ProyectoPedido
{
    partial class AMBPedidos
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.btnAddC = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.Gb_Pedido = new System.Windows.Forms.GroupBox();
            this.BT_Salir2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.Gb_Pedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(31, 43);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(192, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR CLIENTE";
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(70, 69);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(97, 36);
            this.btnBuscarC.TabIndex = 4;
            this.btnBuscarC.Text = "Buscar Cliente";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(67, 297);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(97, 33);
            this.btnBuscarP.TabIndex = 8;
            this.btnBuscarP.Text = "Buscar Producto";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BUSCAR PRODUCTO";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(28, 271);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(192, 20);
            this.txtProducto.TabIndex = 5;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(246, 27);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(460, 222);
            this.dgvClientes.TabIndex = 10;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(246, 255);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(460, 222);
            this.dgvProductos.TabIndex = 11;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(712, 299);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(46, 20);
            this.nudCantidad.TabIndex = 12;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(712, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbProductos
            // 
            this.lbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.ItemHeight = 24;
            this.lbProductos.Location = new System.Drawing.Point(976, 273);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(243, 172);
            this.lbProductos.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(972, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(989, 456);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 20);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(782, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "DIRECCION";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(782, 87);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(192, 20);
            this.txtDireccion.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(782, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "NOMBRE";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(782, 43);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(192, 20);
            this.TB_Nombre.TabIndex = 19;
            // 
            // btnAddC
            // 
            this.btnAddC.Location = new System.Drawing.Point(715, 27);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(46, 31);
            this.btnAddC.TabIndex = 21;
            this.btnAddC.Text = "ADD";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(820, 407);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 39);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "CERRAR VENTA";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Gb_Pedido
            // 
            this.Gb_Pedido.Controls.Add(this.BT_Salir2);
            this.Gb_Pedido.Controls.Add(this.label1);
            this.Gb_Pedido.Controls.Add(this.dgvProductos);
            this.Gb_Pedido.Controls.Add(this.lblNombre);
            this.Gb_Pedido.Controls.Add(this.btnCerrar);
            this.Gb_Pedido.Controls.Add(this.txtCliente);
            this.Gb_Pedido.Controls.Add(this.btnAddC);
            this.Gb_Pedido.Controls.Add(this.btnBuscarC);
            this.Gb_Pedido.Controls.Add(this.txtProducto);
            this.Gb_Pedido.Controls.Add(this.TB_Nombre);
            this.Gb_Pedido.Controls.Add(this.label2);
            this.Gb_Pedido.Controls.Add(this.label4);
            this.Gb_Pedido.Controls.Add(this.btnBuscarP);
            this.Gb_Pedido.Controls.Add(this.txtDireccion);
            this.Gb_Pedido.Controls.Add(this.dgvClientes);
            this.Gb_Pedido.Controls.Add(this.lblTotal);
            this.Gb_Pedido.Controls.Add(this.label3);
            this.Gb_Pedido.Controls.Add(this.nudCantidad);
            this.Gb_Pedido.Controls.Add(this.lbProductos);
            this.Gb_Pedido.Controls.Add(this.btnAdd);
            this.Gb_Pedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gb_Pedido.Location = new System.Drawing.Point(0, 0);
            this.Gb_Pedido.Name = "Gb_Pedido";
            this.Gb_Pedido.Size = new System.Drawing.Size(1245, 510);
            this.Gb_Pedido.TabIndex = 23;
            this.Gb_Pedido.TabStop = false;
            this.Gb_Pedido.Text = "Pedido";
            // 
            // BT_Salir2
            // 
            this.BT_Salir2.Image = global::ProyectoPedido.Properties.Resources.salir;
            this.BT_Salir2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_Salir2.Location = new System.Drawing.Point(13, 456);
            this.BT_Salir2.Name = "BT_Salir2";
            this.BT_Salir2.Size = new System.Drawing.Size(75, 46);
            this.BT_Salir2.TabIndex = 23;
            this.BT_Salir2.Text = "Salir";
            this.BT_Salir2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Salir2.UseVisualStyleBackColor = true;
            this.BT_Salir2.Click += new System.EventHandler(this.BT_Salir2_Click);
            // 
            // AMBPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 522);
            this.Controls.Add(this.Gb_Pedido);
            this.Name = "AMBPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.AMBPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.Gb_Pedido.ResumeLayout(false);
            this.Gb_Pedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox Gb_Pedido;
        private System.Windows.Forms.Button BT_Salir2;
    }
}