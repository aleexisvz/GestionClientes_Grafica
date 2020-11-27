namespace ProyectoPedido
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Salir = new System.Windows.Forms.Button();
            this.BT_Factu = new System.Windows.Forms.Button();
            this.BT_Pedidos = new System.Windows.Forms.Button();
            this.BT_Producto = new System.Windows.Forms.Button();
            this.BT_Clientes = new System.Windows.Forms.Button();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Salir
            // 
            this.BT_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Salir.Image = global::ProyectoPedido.Properties.Resources.salir;
            this.BT_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_Salir.Location = new System.Drawing.Point(582, 312);
            this.BT_Salir.Name = "BT_Salir";
            this.BT_Salir.Size = new System.Drawing.Size(60, 38);
            this.BT_Salir.TabIndex = 4;
            this.BT_Salir.Text = "Salir";
            this.BT_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Salir.UseVisualStyleBackColor = true;
            this.BT_Salir.Click += new System.EventHandler(this.BT_Salir_Click);
            // 
            // BT_Factu
            // 
            this.BT_Factu.Image = global::ProyectoPedido.Properties.Resources.antecedentes;
            this.BT_Factu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_Factu.Location = new System.Drawing.Point(12, 242);
            this.BT_Factu.Name = "BT_Factu";
            this.BT_Factu.Size = new System.Drawing.Size(157, 51);
            this.BT_Factu.TabIndex = 3;
            this.BT_Factu.Text = "Facturación";
            this.BT_Factu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Factu.UseVisualStyleBackColor = true;
            this.BT_Factu.Click += new System.EventHandler(this.BT_Factu_Click);
            // 
            // BT_Pedidos
            // 
            this.BT_Pedidos.Image = global::ProyectoPedido.Properties.Resources.options_icon;
            this.BT_Pedidos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_Pedidos.Location = new System.Drawing.Point(12, 185);
            this.BT_Pedidos.Name = "BT_Pedidos";
            this.BT_Pedidos.Size = new System.Drawing.Size(157, 51);
            this.BT_Pedidos.TabIndex = 2;
            this.BT_Pedidos.Text = "Carga de Pedidos";
            this.BT_Pedidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Pedidos.UseVisualStyleBackColor = true;
            this.BT_Pedidos.Click += new System.EventHandler(this.BT_Pedidos_Click);
            // 
            // BT_Producto
            // 
            this.BT_Producto.Image = global::ProyectoPedido.Properties.Resources._001_01;
            this.BT_Producto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_Producto.Location = new System.Drawing.Point(12, 69);
            this.BT_Producto.Name = "BT_Producto";
            this.BT_Producto.Size = new System.Drawing.Size(157, 51);
            this.BT_Producto.TabIndex = 1;
            this.BT_Producto.Text = "Productos";
            this.BT_Producto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Producto.UseVisualStyleBackColor = true;
            this.BT_Producto.Click += new System.EventHandler(this.BT_Producto_Click);
            // 
            // BT_Clientes
            // 
            this.BT_Clientes.Image = global::ProyectoPedido.Properties.Resources.rr1;
            this.BT_Clientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_Clientes.Location = new System.Drawing.Point(12, 12);
            this.BT_Clientes.Name = "BT_Clientes";
            this.BT_Clientes.Size = new System.Drawing.Size(157, 51);
            this.BT_Clientes.TabIndex = 0;
            this.BT_Clientes.Text = "Clientes";
            this.BT_Clientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Clientes.UseVisualStyleBackColor = true;
            this.BT_Clientes.Click += new System.EventHandler(this.BT_Clientes_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Image = global::ProyectoPedido.Properties.Resources._001_01;
            this.btnIngredientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngredientes.Location = new System.Drawing.Point(12, 128);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(157, 51);
            this.btnIngredientes.TabIndex = 5;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 362);
            this.Controls.Add(this.btnIngredientes);
            this.Controls.Add(this.BT_Salir);
            this.Controls.Add(this.BT_Factu);
            this.Controls.Add(this.BT_Pedidos);
            this.Controls.Add(this.BT_Producto);
            this.Controls.Add(this.BT_Clientes);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Clientes;
        private System.Windows.Forms.Button BT_Producto;
        private System.Windows.Forms.Button BT_Pedidos;
        private System.Windows.Forms.Button BT_Factu;
        private System.Windows.Forms.Button BT_Salir;
        private System.Windows.Forms.Button btnIngredientes;
    }
}

