using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                dgvPedidos.AutoResizeColumns();
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
    }
}
