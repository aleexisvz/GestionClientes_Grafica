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
    public partial class Menu : Form
    {
        List<Entitys.Cliente> oList_Clientes = new List<Entitys.Cliente>();   
        public Menu()
        {
            
            InitializeComponent();
        }

        private void BT_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form oClientes = new AMBClientes();
            oClientes.Show();
           
        }

        private void BT_Producto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form oProductos = new AMBProductos();
            oProductos.Show();
        }

        private void BT_Pedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form oPedidos = new AMBPedidos();
            oPedidos.Show();
        }

        private void BT_Factu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En proceso","Gonzalo G.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form oIngredientes = new AMBIngredientes();
            oIngredientes.Show();
        }
    }
}
