using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoPedido
{
    public partial class frmPedidos : Form
    {
        List<Entitys.Pedido> oList_Pedidos = new List<Entitys.Pedido>();

        public frmPedidos()
        {
            InitializeComponent();
            cargarPedidos();
        }

        public void cargarPedidos()
        {
            oList_Pedidos = Business.Pedido.Consulta_Pedido();
            if (oList_Pedidos != null)
            {
                dgvPedidos.DataSource = oList_Pedidos;
                //dgvPedidos.AutoResizeColumns();
            }
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            frmAgregarPedido agregar = new frmAgregarPedido();
            agregar.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarPedidos();
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Se eliminará un pedido de la base de datos. Desea continuar?", "¡ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if(resp == DialogResult.OK)
            {
                int idPedido = Convert.ToInt32(dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value.ToString());

                try
                {
                    bool ok = Business.Pedido.Delete_Pedido(idPedido);
                    if (ok)
                        MessageBox.Show("Se ha eliminado el pedido correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Se ha producido un error: " + ex.Message);
                }

                cargarPedidos();
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string ubicacion = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[11].Value.ToString();

            Process.Start("explorer.exe", ubicacion);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idPedido = Convert.ToInt32(dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value.ToString());

            try
            {
                bool ok = Business.Pedido.Confirm_Pedido(idPedido, DateTime.Now);
                if (ok)
                    MessageBox.Show("Se ha confirmado el pedido correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }
    }
}
