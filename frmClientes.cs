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

            cmbSearch.SelectedIndex = 1;
        }

        public void cargarClientes()
        {
            oList_Clientes = Business.Cliente.Consulta_Cliente();
            if (oList_Clientes != null)
            {
                dgvClientes.DataSource = oList_Clientes;
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

                    string id = InputDialog.mostrar("Inserte el ID: ");

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

                    string nombre = InputDialog.mostrar("Inserte el nombre: ");

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

                    string marca = InputDialog.mostrar("Inserte la marca: ");

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

                    string ubicCarpeta = InputDialog.mostrar("Inserte la ubicacion de la carpeta: ");

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

                    string ultmoTrabajo = InputDialog.mostrar("Inserte el ultimo trabajo: ");

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

                    string comprasHechas = InputDialog.mostrar("Inserte las compras hechas: ");

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
            DialogResult resp = MessageBox.Show("Se eliminará un cliente de la base de datos. Desea continuar?", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if(resp == DialogResult.OK)
            {
                int idCliente = Convert.ToInt32(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());

                try
                {
                    bool ok = Business.Cliente.Delete_Cliente(idCliente);
                    if (ok)
                        MessageBox.Show("El cliente se ha eliminado correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error: " + ex.Message, "Ha ocurrido un error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cargarClientes();
            }

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string ubicacion = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[3].Value.ToString();

            Process.Start("explorer.exe", ubicacion);
        }
    }
}
