
namespace ProyectoPedido
{
    partial class frmPrincipal
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelClientesSubmenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnPrincipalC = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelPedidoSubmenu = new System.Windows.Forms.Panel();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.btnPrincipalP = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelClientesSubmenu.SuspendLayout();
            this.panelPedidoSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelSideMenu.Controls.Add(this.panelClientesSubmenu);
            this.panelSideMenu.Controls.Add(this.btnClientes);
            this.panelSideMenu.Controls.Add(this.panelPedidoSubmenu);
            this.panelSideMenu.Controls.Add(this.btnPedidos);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 581);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelClientesSubmenu
            // 
            this.panelClientesSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelClientesSubmenu.Controls.Add(this.button1);
            this.panelClientesSubmenu.Controls.Add(this.btnEliminarCliente);
            this.panelClientesSubmenu.Controls.Add(this.btnModificarCliente);
            this.panelClientesSubmenu.Controls.Add(this.btnBuscarCliente);
            this.panelClientesSubmenu.Controls.Add(this.btnPrincipalC);
            this.panelClientesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientesSubmenu.Location = new System.Drawing.Point(0, 369);
            this.panelClientesSubmenu.Name = "panelClientesSubmenu";
            this.panelClientesSubmenu.Size = new System.Drawing.Size(250, 210);
            this.panelClientesSubmenu.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(0, 160);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar Cliente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEliminarCliente.Location = new System.Drawing.Point(0, 120);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarCliente.Size = new System.Drawing.Size(250, 40);
            this.btnEliminarCliente.TabIndex = 3;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnModificarCliente.Location = new System.Drawing.Point(0, 80);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnModificarCliente.Size = new System.Drawing.Size(250, 40);
            this.btnModificarCliente.TabIndex = 2;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBuscarCliente.Location = new System.Drawing.Point(0, 40);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBuscarCliente.Size = new System.Drawing.Size(250, 40);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnPrincipalC
            // 
            this.btnPrincipalC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrincipalC.FlatAppearance.BorderSize = 0;
            this.btnPrincipalC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipalC.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipalC.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPrincipalC.Location = new System.Drawing.Point(0, 0);
            this.btnPrincipalC.Name = "btnPrincipalC";
            this.btnPrincipalC.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPrincipalC.Size = new System.Drawing.Size(250, 40);
            this.btnPrincipalC.TabIndex = 0;
            this.btnPrincipalC.Text = "Principal";
            this.btnPrincipalC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipalC.UseVisualStyleBackColor = true;
            this.btnPrincipalC.Click += new System.EventHandler(this.btnPrincipalC_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClientes.Location = new System.Drawing.Point(0, 329);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(250, 40);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelPedidoSubmenu
            // 
            this.panelPedidoSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPedidoSubmenu.Controls.Add(this.btnAgregarPedido);
            this.panelPedidoSubmenu.Controls.Add(this.btnEliminarPedido);
            this.panelPedidoSubmenu.Controls.Add(this.btnModificarPedido);
            this.panelPedidoSubmenu.Controls.Add(this.btnBuscarPedido);
            this.panelPedidoSubmenu.Controls.Add(this.btnPrincipalP);
            this.panelPedidoSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPedidoSubmenu.Location = new System.Drawing.Point(0, 119);
            this.panelPedidoSubmenu.Name = "panelPedidoSubmenu";
            this.panelPedidoSubmenu.Size = new System.Drawing.Size(250, 210);
            this.panelPedidoSubmenu.TabIndex = 1;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarPedido.FlatAppearance.BorderSize = 0;
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAgregarPedido.Location = new System.Drawing.Point(0, 160);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarPedido.Size = new System.Drawing.Size(250, 40);
            this.btnAgregarPedido.TabIndex = 4;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarPedido.FlatAppearance.BorderSize = 0;
            this.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPedido.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEliminarPedido.Location = new System.Drawing.Point(0, 120);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarPedido.Size = new System.Drawing.Size(250, 40);
            this.btnEliminarPedido.TabIndex = 3;
            this.btnEliminarPedido.Text = "Eliminar Pedido";
            this.btnEliminarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarPedido.FlatAppearance.BorderSize = 0;
            this.btnModificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPedido.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPedido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnModificarPedido.Location = new System.Drawing.Point(0, 80);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnModificarPedido.Size = new System.Drawing.Size(250, 40);
            this.btnModificarPedido.TabIndex = 2;
            this.btnModificarPedido.Text = "Modificar Pedido";
            this.btnModificarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPedido.UseVisualStyleBackColor = true;
            this.btnModificarPedido.Click += new System.EventHandler(this.btnModificarPedido_Click);
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarPedido.FlatAppearance.BorderSize = 0;
            this.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedido.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPedido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBuscarPedido.Location = new System.Drawing.Point(0, 40);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBuscarPedido.Size = new System.Drawing.Size(250, 40);
            this.btnBuscarPedido.TabIndex = 1;
            this.btnBuscarPedido.Text = "Buscar Pedido";
            this.btnBuscarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPedido.UseVisualStyleBackColor = true;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // btnPrincipalP
            // 
            this.btnPrincipalP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrincipalP.FlatAppearance.BorderSize = 0;
            this.btnPrincipalP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipalP.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipalP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPrincipalP.Location = new System.Drawing.Point(0, 0);
            this.btnPrincipalP.Name = "btnPrincipalP";
            this.btnPrincipalP.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPrincipalP.Size = new System.Drawing.Size(250, 40);
            this.btnPrincipalP.TabIndex = 0;
            this.btnPrincipalP.Text = "Principal";
            this.btnPrincipalP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipalP.UseVisualStyleBackColor = true;
            this.btnPrincipalP.Click += new System.EventHandler(this.btnPrincipalP_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPedidos.Location = new System.Drawing.Point(0, 79);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPedidos.Size = new System.Drawing.Size(250, 40);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.AutoScroll = true;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 79);
            this.panelLogo.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(934, 581);
            this.panelChildForm.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 581);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.panelSideMenu.ResumeLayout(false);
            this.panelClientesSubmenu.ResumeLayout(false);
            this.panelPedidoSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelClientesSubmenu;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnPrincipalC;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelPedidoSubmenu;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnModificarPedido;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.Button btnPrincipalP;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button button1;
    }
}