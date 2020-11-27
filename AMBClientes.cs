using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProyectoPedido
{
    public partial class AMBClientes : Form
    {
        List<Entitys.Cliente> oList_Clientes = new List<Entitys.Cliente>();

        public AMBClientes()
        {
            
            InitializeComponent();
            cargarClientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form Menu = new Menu();
            Menu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Nombre = TB_Nombre.Text;
            string Direccion = Tb_Direccion.Text;
            string Telefono = Tb_Telefono.Text;

            int currentIdClient = Convert.ToInt32(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());

            if (Business.Cliente.Update_Client(Nombre, Direccion, Telefono, currentIdClient))
            {
                MessageBox.Show("Se ha Actualizado el cliente satisfactoriamente", "Alexis V.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarClientes();
            }
        }

        private void BT_BajaCliente_Click(object sender, EventArgs e)
        {
            int currentIdClient = Convert.ToInt32(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());

            if (Business.Cliente.Delete_Client(currentIdClient))
            {
                MessageBox.Show("Se ha eliminado el cliente satisfactoriamente", "Alexis V.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarClientes();
            }
        }

        private void BT_CargarCliente_Click(object sender, EventArgs e)
        {
            bool ok = false;
            string Nombre,Direccion,Telefono;
            if(Tb_Direccion.Text != "" && TB_Nombre.Text != "" && Tb_Telefono.Text != "")
            {
                //Ingresar cliente
                Nombre = TB_Nombre.Text;
                Direccion = Tb_Direccion.Text;
                Telefono = Tb_Telefono.Text;

                ok = Business.Cliente.Insert_Client(Nombre,Direccion,Telefono);
                if(ok)
                {
                    MessageBox.Show("Se ha insertado correctamente el Cliente", "Gonzalo G.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cargarClientes();
                    Limpiar();
                        
                }
                else
                {
                    MessageBox.Show("No se ha podido insertar el cliente", "Gonzalo G.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay un campo que no se ha ingresado nada, por favor verifique lo que está ingresando","Gonzalo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
 

        }

        private void Limpiar()
        {
            Tb_Direccion.Text = "";
            TB_Nombre.Text = "";
            Tb_Telefono.Text = "";
        }

        private void cargarClientes()
        {
            oList_Clientes = Business.Cliente.Consulta_Clientes();
            if(oList_Clientes != null)
            {
                dgvClientes.DataSource = oList_Clientes;
                dgvClientes.Columns["IDCliente"].Visible = false;
            }
            
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_Nombre.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[1].Value.ToString();
            Tb_Direccion.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[2].Value.ToString();
            Tb_Telefono.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[3].Value.ToString();
        }
    }
}
