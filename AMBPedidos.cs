using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoPedido
{
    public partial class AMBPedidos : Form
    {
        List<Entitys.Cliente> oList_Clientes = new List<Entitys.Cliente>();
        List<Entitys.Producto> oList_Productos = new List<Entitys.Producto>();

        public AMBPedidos()
        {
            InitializeComponent();
        }

        private void cargarClientes()
        {
            oList_Clientes = Business.Cliente.Consulta_Clientes();
            dgvClientes.DataSource = oList_Clientes;
            dgvClientes.Columns["IDCliente"].Visible = false;
      
        }

        private void cargarProductos()
        {
            oList_Productos = Business.Producto.Consulta_Productos();
            dgvProductos.DataSource = oList_Productos;
            dgvProductos.Columns["IDProducto"].Visible = false;
        }

        private void buscarCliente()
        {
            cargarClientes();

            //Recorre todas las rows hasta encontrar el valor de txtCliente
            foreach (DataGridViewRow r in dgvClientes.Rows)
            {
                if ((r.Cells[1].Value).ToString().ToLower().Contains(txtCliente.Text.ToLower()))
                    dgvClientes.Rows[r.Index].Visible = true;
            }
        }

        private void buscarProducto()
        {
            cargarProductos();

            //Recorre todas las rows hasta encontrar el valor de txtProducto
            foreach (DataGridViewRow r in dgvProductos.Rows)
            {
                if ((r.Cells[1].Value).ToString().ToLower().Contains(txtProducto.Text.ToLower()))
                    dgvProductos.Rows[r.Index].Visible = true;
            }
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                buscarCliente();
                Limpiar();
            }
            else
                MessageBox.Show("Rellene los campos necesarios", "Alexis V.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            txtCliente.Text = "";
            txtProducto.Text = "";
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            if(txtProducto.Text != "")
            {
                buscarProducto();
                Limpiar();
            }
            else
                MessageBox.Show("Rellene los campos necesarios", "Alexis V.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Obtiene el producto seleccionado en la dgv
            int currentIdProduct = Convert.ToInt32(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString());
            var currentProduct = oList_Productos.FirstOrDefault(x => x.IDProducto == currentIdProduct);

            //Agrega el producto seleccionado a la lb
            string nombre = currentProduct.Nombre + " - " + currentProduct.Descripcion + " x " + nudCantidad.Value.ToString();
            lbProductos.Items.Add(nombre);

            //Suma el precio del producto seleccionado multiplicado por la cantidad al total
            int precio = Convert.ToInt32(lblTotal.Text) + Convert.ToInt32(currentProduct.Precio) * Convert.ToInt32(nudCantidad.Value);
            lblTotal.Text = precio.ToString();
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            //Obtiene el cliente seleccionado en la dgv
            int currentIdClient = Convert.ToInt32(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
            var currentClient = oList_Clientes.FirstOrDefault(x => x.IDCliente == currentIdClient);

            //Agrega el nombre y direccion a los txt
            TB_Nombre.Text = currentClient.Nombre;
            txtDireccion.Text = currentClient.Direccion;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {



        }

        private void AMBPedidos_Load(object sender, EventArgs e)
        {
            txtCliente.Focus();
        }

        private void BT_Salir2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form oForm = new Menu();
            oForm.Show();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIdClient = Convert.ToInt32(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
            var currentClient = oList_Clientes.FirstOrDefault(x => x.IDCliente == currentIdClient);

            TB_Nombre.Text = currentClient.Nombre;
            txtDireccion.Text = currentClient.Direccion;

        }
    }
    
}
