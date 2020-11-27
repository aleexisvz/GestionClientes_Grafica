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
    public partial class frmModificarCliente : Form
    {
        public frmModificarCliente()
        {
            InitializeComponent();

            int comprasHechas = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtMarca.Text != "" && txtCarpeta.Text != "" && txtUTrabajo.Text != "" && txtComprasHechas.Text != "")
            {
                string nombre = txtNombre.Text, marca = txtMarca.Text, carpeta = txtCarpeta.Text, uTrabajo = txtUTrabajo.Text;
                int comprasHechas = int.Parse(txtCantidad.Text), currentIdClient = Convert.ToInt32(lblID.Text);

                if (Business.Cliente.Update_Cliente(nombre, marca, carpeta, uTrabajo, comprasHechas, currentIdClient))
                {
                    MessageBox.Show("El cliente se ha modificado satisfactoriamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Rellene los campos necesarios.", "Campos vacios", MessageBoxButtons.OK);
        }
    }
}
