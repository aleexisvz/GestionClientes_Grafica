using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InputKey;

namespace ProyectoPedido
{
    public partial class frmClientes : Form
    {
        List<Entitys.Cliente> oList_Clientes = new List<Entitys.Cliente>();

        public frmClientes()
        {
            InitializeComponent();
            cargarClientes();
        }

        private void cargarClientes()
        {
            oList_Clientes = Business.Cliente.Consulta_Cliente();
            if (oList_Clientes != null)
            {
                dgvClientes.DataSource = oList_Clientes;
                dgvClientes.AutoResizeColumns();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAgregarCliente agregar = new frmAgregarCliente();
            agregar.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string valueToSearch = cmbSearch.Text;
            


            switch (valueToSearch)
            {    
                case "ID":
                    cargarClientes();

                    string id = InputDialog.mostrar("Inserte el ID que desea buscar: ");

                    foreach (DataGridViewRow r in dgvClientes.Rows)
                    {
                        if ((r.Cells[0].Value).ToString().ToLower().Contains(id.ToLower()))
                        {
                            dgvClientes.Rows[r.Index].Visible = true;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.BackColor = Color.DarkMagenta;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    break;
                case "Nombre":
                    cargarClientes();

                    string nombre = InputDialog.mostrar("Inserte el nombre que desea buscar: ");

                    foreach (DataGridViewRow r in dgvClientes.Rows)
                    {
                        if ((r.Cells[1].Value).ToString().ToLower().Contains(nombre.ToLower()))
                        {
                            dgvClientes.Rows[r.Index].Visible = true;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.BackColor = Color.DarkMagenta;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    break;
                case "Marca":
                    cargarClientes();

                    string marca = InputDialog.mostrar("Inserte la marca que desea buscar: ");

                    foreach (DataGridViewRow r in dgvClientes.Rows)
                    {
                        if ((r.Cells[2].Value).ToString().ToLower().Contains(marca.ToLower()))
                        {
                            dgvClientes.Rows[r.Index].Visible = true;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.BackColor = Color.DarkMagenta;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    break;
                case "Ubicacion de Carpeta":
                    cargarClientes();

                    string ubicCarpeta = InputDialog.mostrar("Inserte la ubicacion de la carpeta que desea buscar: ");

                    foreach (DataGridViewRow r in dgvClientes.Rows)
                    {
                        if ((r.Cells[3].Value).ToString().ToLower().Contains(ubicCarpeta.ToLower()))
                        {
                            dgvClientes.Rows[r.Index].Visible = true;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.BackColor = Color.DarkMagenta;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    break;
                case "Ultimo Trabajo":
                    cargarClientes();

                    string ultmoTrabajo = InputDialog.mostrar("Inserte el ultimo trabajo que desea buscar: ");

                    foreach (DataGridViewRow r in dgvClientes.Rows)
                    {
                        if ((r.Cells[4].Value).ToString().ToLower().Contains(ultmoTrabajo.ToLower()))
                        {
                            dgvClientes.Rows[r.Index].Visible = true;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.BackColor = Color.DarkMagenta;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    break;
                case "Compras Hechas":
                    cargarClientes();

                    string comprasHechas = InputDialog.mostrar("Inserte las compras hechas que desea buscar: ");

                    foreach (DataGridViewRow r in dgvClientes.Rows)
                    {
                        if ((r.Cells[5].Value).ToString().ToLower().Contains(comprasHechas.ToLower()))
                        {
                            dgvClientes.Rows[r.Index].Visible = true;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.BackColor = Color.DarkMagenta;
                            dgvClientes.Rows[r.Index].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(InputDialog.mostrar("Ingrese el ID del cliente que desea eliminar:   "));

            try
            {
                bool ok = Business.Cliente.Delete_Cliente(idCliente);
                if (ok)
                    MessageBox.Show("Operación exitosa");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }

            cargarClientes();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSearch.SelectedIndex >= 0)
                btnSearch.Enabled = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmModificarCliente modCliente = new frmModificarCliente();
            modCliente.lblID.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString();
            modCliente.Show();
        }
    }
}
