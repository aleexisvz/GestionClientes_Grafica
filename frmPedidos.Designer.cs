
namespace ProyectoPedido
{
    partial class frmPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbCells = new System.Windows.Forms.ComboBox();
            this.rtbModificar = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnExecMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.ForeColor = System.Drawing.Color.Plum;
            this.btnAgregarPedido.Location = new System.Drawing.Point(25, 374);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(60, 32);
            this.btnAgregarPedido.TabIndex = 4;
            this.btnAgregarPedido.Text = "ADD";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidos.GridColor = System.Drawing.Color.Indigo;
            this.dgvPedidos.Location = new System.Drawing.Point(24, 39);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(850, 329);
            this.dgvPedidos.TabIndex = 5;
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPedido.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedido.ForeColor = System.Drawing.Color.Plum;
            this.btnEliminarPedido.Location = new System.Drawing.Point(25, 417);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(60, 32);
            this.btnEliminarPedido.TabIndex = 6;
            this.btnEliminarPedido.Text = "DELETE";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Plum;
            this.btnConfirmar.Location = new System.Drawing.Point(91, 374);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 32);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Plum;
            this.btnActualizar.Location = new System.Drawing.Point(399, 374);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 32);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.Plum;
            this.btnAbrir.Location = new System.Drawing.Point(794, 374);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(81, 32);
            this.btnAbrir.TabIndex = 9;
            this.btnAbrir.Text = "ABRIR";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Plum;
            this.btnModificar.Location = new System.Drawing.Point(91, 417);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 32);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbCells
            // 
            this.cmbCells.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCells.FormattingEnabled = true;
            this.cmbCells.Items.AddRange(new object[] {
            "idCliente",
            "usuario",
            "producto",
            "encargo",
            "observaciones",
            "monto",
            "deuda",
            "directorio"});
            this.cmbCells.Location = new System.Drawing.Point(191, 424);
            this.cmbCells.Name = "cmbCells";
            this.cmbCells.Size = new System.Drawing.Size(121, 21);
            this.cmbCells.TabIndex = 11;
            // 
            // rtbModificar
            // 
            this.rtbModificar.Location = new System.Drawing.Point(24, 491);
            this.rtbModificar.Name = "rtbModificar";
            this.rtbModificar.Size = new System.Drawing.Size(288, 86);
            this.rtbModificar.TabIndex = 12;
            this.rtbModificar.Text = "";
            this.rtbModificar.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(95, 459);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(153, 29);
            this.label21.TabIndex = 40;
            this.label21.Text = "MODIFICACIONES:";
            this.label21.Visible = false;
            // 
            // btnExecMod
            // 
            this.btnExecMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExecMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecMod.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecMod.ForeColor = System.Drawing.Color.Plum;
            this.btnExecMod.Location = new System.Drawing.Point(328, 521);
            this.btnExecMod.Name = "btnExecMod";
            this.btnExecMod.Size = new System.Drawing.Size(63, 28);
            this.btnExecMod.TabIndex = 41;
            this.btnExecMod.Text = "EXEC";
            this.btnExecMod.UseVisualStyleBackColor = true;
            this.btnExecMod.Visible = false;
            this.btnExecMod.Click += new System.EventHandler(this.btnExecMod_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(895, 589);
            this.Controls.Add(this.btnExecMod);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.rtbModificar);
            this.Controls.Add(this.cmbCells);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnEliminarPedido);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnAgregarPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbCells;
        private System.Windows.Forms.RichTextBox rtbModificar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnExecMod;
    }
}