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
    public partial class frmAgregarCliente : Form
    {
        int ComprasHechas = 0;

        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            txtComprasHechas.Text = "0";
        }

        private void btnNumberUp_Click(object sender, EventArgs e)
        {
            txtComprasHechas.Text = (ComprasHechas + 1).ToString(); 
        }

        private void btnNumberDown_Click(object sender, EventArgs e)
        {
            txtComprasHechas.Text = (ComprasHechas - 1).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //DECLARACIONES
            string nombre, marca, ubicCarpeta, ultimoTrabajo;
            int comprasHechas;

            bool ok = false;

            if (txtNombre.Text != "" && txtMarca.Text != "" && txtUbicacion.Text != "" && txtUltimoTrabajo.Text != "")
            {
                //Ingresar cliente
                nombre = txtNombre.Text;
                marca = txtMarca.Text;
                ubicCarpeta = txtUbicacion.Text;
                ultimoTrabajo= txtUltimoTrabajo.Text;
                comprasHechas = Convert.ToInt32(txtComprasHechas.Text);

                ok = Business.Cliente.Insert_Cliente(nombre, marca, ubicCarpeta, ultimoTrabajo, comprasHechas);

                if (ok)
                {
                    MessageBox.Show("Se ha insertado el cliente correctamente.", "Operaciòn exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar insertar un cliente.", "La operaciòn ha fallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Campos vacìos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
