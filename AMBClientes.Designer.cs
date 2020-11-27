namespace ProyectoPedido
{
    partial class AMBClientes
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
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.LB_Nombre = new System.Windows.Forms.Label();
            this.LB_Direccion = new System.Windows.Forms.Label();
            this.Tb_Direccion = new System.Windows.Forms.TextBox();
            this.LB_Telefono = new System.Windows.Forms.Label();
            this.Tb_Telefono = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.BT_Modificar = new System.Windows.Forms.Button();
            this.BT_BajaCliente = new System.Windows.Forms.Button();
            this.BT_CargarCliente = new System.Windows.Forms.Button();
            this.LB_Clientes = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(73, 27);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(280, 20);
            this.TB_Nombre.TabIndex = 0;
            // 
            // LB_Nombre
            // 
            this.LB_Nombre.AutoSize = true;
            this.LB_Nombre.Location = new System.Drawing.Point(20, 30);
            this.LB_Nombre.Name = "LB_Nombre";
            this.LB_Nombre.Size = new System.Drawing.Size(47, 13);
            this.LB_Nombre.TabIndex = 1;
            this.LB_Nombre.Text = "Nombre:";
            // 
            // LB_Direccion
            // 
            this.LB_Direccion.AutoSize = true;
            this.LB_Direccion.Location = new System.Drawing.Point(15, 66);
            this.LB_Direccion.Name = "LB_Direccion";
            this.LB_Direccion.Size = new System.Drawing.Size(55, 13);
            this.LB_Direccion.TabIndex = 2;
            this.LB_Direccion.Text = "Direccion:";
            // 
            // Tb_Direccion
            // 
            this.Tb_Direccion.Location = new System.Drawing.Point(73, 63);
            this.Tb_Direccion.Name = "Tb_Direccion";
            this.Tb_Direccion.Size = new System.Drawing.Size(280, 20);
            this.Tb_Direccion.TabIndex = 3;
            // 
            // LB_Telefono
            // 
            this.LB_Telefono.AutoSize = true;
            this.LB_Telefono.Location = new System.Drawing.Point(15, 102);
            this.LB_Telefono.Name = "LB_Telefono";
            this.LB_Telefono.Size = new System.Drawing.Size(52, 13);
            this.LB_Telefono.TabIndex = 4;
            this.LB_Telefono.Text = "Teléfono:";
            // 
            // Tb_Telefono
            // 
            this.Tb_Telefono.Location = new System.Drawing.Point(73, 95);
            this.Tb_Telefono.Name = "Tb_Telefono";
            this.Tb_Telefono.Size = new System.Drawing.Size(280, 20);
            this.Tb_Telefono.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Image = global::ProyectoPedido.Properties.Resources.salir;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(289, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 46);
            this.button3.TabIndex = 9;
            this.button3.Text = "Salir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BT_Modificar
            // 
            this.BT_Modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Modificar.Image = global::ProyectoPedido.Properties.Resources.Actualizar;
            this.BT_Modificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_Modificar.Location = new System.Drawing.Point(194, 259);
            this.BT_Modificar.Name = "BT_Modificar";
            this.BT_Modificar.Size = new System.Drawing.Size(75, 46);
            this.BT_Modificar.TabIndex = 8;
            this.BT_Modificar.Text = "Modificar";
            this.BT_Modificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Modificar.UseVisualStyleBackColor = true;
            this.BT_Modificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BT_BajaCliente
            // 
            this.BT_BajaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_BajaCliente.Image = global::ProyectoPedido.Properties.Resources.Borrar;
            this.BT_BajaCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_BajaCliente.Location = new System.Drawing.Point(102, 259);
            this.BT_BajaCliente.Name = "BT_BajaCliente";
            this.BT_BajaCliente.Size = new System.Drawing.Size(75, 46);
            this.BT_BajaCliente.TabIndex = 7;
            this.BT_BajaCliente.Text = "Baja";
            this.BT_BajaCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_BajaCliente.UseVisualStyleBackColor = true;
            this.BT_BajaCliente.Click += new System.EventHandler(this.BT_BajaCliente_Click);
            // 
            // BT_CargarCliente
            // 
            this.BT_CargarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_CargarCliente.Image = global::ProyectoPedido.Properties.Resources._001_01;
            this.BT_CargarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_CargarCliente.Location = new System.Drawing.Point(6, 259);
            this.BT_CargarCliente.Name = "BT_CargarCliente";
            this.BT_CargarCliente.Size = new System.Drawing.Size(75, 46);
            this.BT_CargarCliente.TabIndex = 6;
            this.BT_CargarCliente.Text = "Alta";
            this.BT_CargarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_CargarCliente.UseVisualStyleBackColor = true;
            this.BT_CargarCliente.Click += new System.EventHandler(this.BT_CargarCliente_Click);
            // 
            // LB_Clientes
            // 
            this.LB_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Clientes.AutoSize = true;
            this.LB_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Clientes.Location = new System.Drawing.Point(520, 9);
            this.LB_Clientes.Name = "LB_Clientes";
            this.LB_Clientes.Size = new System.Drawing.Size(61, 15);
            this.LB_Clientes.TabIndex = 11;
            this.LB_Clientes.Text = "CLIENTES";
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(376, 27);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(340, 278);
            this.dgvClientes.TabIndex = 12;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // AMBClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(738, 330);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.LB_Clientes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BT_Modificar);
            this.Controls.Add(this.BT_BajaCliente);
            this.Controls.Add(this.BT_CargarCliente);
            this.Controls.Add(this.Tb_Telefono);
            this.Controls.Add(this.LB_Telefono);
            this.Controls.Add(this.Tb_Direccion);
            this.Controls.Add(this.LB_Direccion);
            this.Controls.Add(this.LB_Nombre);
            this.Controls.Add(this.TB_Nombre);
            this.Name = "AMBClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Label LB_Nombre;
        private System.Windows.Forms.Label LB_Direccion;
        private System.Windows.Forms.TextBox Tb_Direccion;
        private System.Windows.Forms.Label LB_Telefono;
        private System.Windows.Forms.TextBox Tb_Telefono;
        private System.Windows.Forms.Button BT_CargarCliente;
        private System.Windows.Forms.Button BT_BajaCliente;
        private System.Windows.Forms.Button BT_Modificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LB_Clientes;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}