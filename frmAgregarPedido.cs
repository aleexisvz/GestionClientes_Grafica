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
    public partial class frmAgregarPedido : Form
    {
        int CantidadProductos;
        double Total;

        public frmAgregarPedido()
        {
            InitializeComponent();

            CantidadProductos = 1;
            txtCantidadProductos.Text = CantidadProductos.ToString();

            Total = 0; 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpProductos_Click(object sender, EventArgs e)
        {
            CantidadProductos++;
            txtCantidadProductos.Text = CantidadProductos.ToString();
        }

        private void btnDownProductos_Click(object sender, EventArgs e)
        {
            if(CantidadProductos >= 2)
            {
                CantidadProductos--;
                txtCantidadProductos.Text = CantidadProductos.ToString();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //DECLARACIONES
            string producto;
            int cantidad; 
            double precio;
            double precioFinal;

            if (txtPrecioProducto.Text == "" || txtProducto.Text == "" || txtCantidadProductos.Text == "")
                MessageBox.Show("Se encontraron campos vacios, rellene los todos los campos necesarios.", "Rellene los campos necesarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                cantidad = Convert.ToInt32(txtCantidadProductos.Text);
                precio = Convert.ToDouble(txtPrecioProducto.Text);
                precioFinal = cantidad * precio;

                //Agregamos el pedido
                producto = $"x{txtCantidadProductos.Text} {txtProducto.Text} - ${Convert.ToString(precioFinal)}";

                lbProductos.Items.Add(producto);

                //Sumamos al total
                Total += precioFinal;
                lblTotal.Text = Convert.ToString(Total);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos del producto a eliminar
            int currentIdProduct = lbProductos.SelectedIndex;
            string producto = lbProductos.SelectedItem.ToString();
            double precioRestar = Convert.ToDouble(producto.Substring(producto.LastIndexOf(" $") + 2));
            
            //Restamos al total
            Total -= precioRestar;

            //Removemos el producto
            lbProductos.Items.RemoveAt(currentIdProduct);
        }

        private void cmbCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCantidadEncargo.SelectedIndex == 6)
                txtCantidadEncargo.Visible = true;
            else
                txtCantidadEncargo.Visible = false;
        }

        private void cmbTiempoEstimado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTiempoEstimado.SelectedIndex == 7)
            {
                txtCantidadDias.Visible = true;
                label18.Visible = true;
            }
            else
            {
                switch (cmbTiempoEstimado.SelectedIndex)
                {
                    case 0:
                        dtpFechaEntrega.Value = DateTime.Now.AddDays(1);
                        break;
                    case 1:
                        dtpFechaEntrega.Value = DateTime.Now.AddDays(3);
                        break;
                    case 2:
                        dtpFechaEntrega.Value = DateTime.Now.AddDays(5);
                        break;
                    case 3:
                        dtpFechaEntrega.Value = DateTime.Now.AddDays(10);
                        break;
                    case 4:
                        dtpFechaEntrega.Value = DateTime.Now.AddDays(15);
                        break;
                    case 5:
                        dtpFechaEntrega.Value = DateTime.Now.AddDays(20);
                        break;
                    case 6:
                        dtpFechaEntrega.Value = DateTime.Now.AddDays(30);
                        break;
                }

                txtCantidadDias.Visible = false;
                label18.Visible = false;
            }
                
                
        }

        private void frmAgregarPedido_Load(object sender, EventArgs e)
        {
            lblTotal.Text = Total.ToString();

            //Seteamos los comboBox
            cmbCantidadEncargo.SelectedIndex = 0;
            cmbMaterial.SelectedIndex = 1;
            cmbMedidas.SelectedIndex = 0;
            cmbTiempoEstimado.SelectedIndex = 1;
            
            //Seteamos los textBox
            txtPrecioEncargo.Text = "450";

            //Seteamos los dateTimePicker
            dtpFechaEntrada.Value = DateTime.Now;

            cmbTiempoEstimado_SelectedIndexChanged(sender, e);
        }

        private void cmbMedidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedidas.SelectedIndex == 9)
            {
                txtAlto.Visible = true;
                txtAncho.Visible = true;
                label14.Visible = true;
            }
            else
            {
                txtAlto.Visible = false;
                txtAncho.Visible = false;
                label14.Visible = false;
            }
        }

        private void btnAgregarEncargo_Click(object sender, EventArgs e)
        {
            //DECLARACIONES
            string encargo;
            int cantidad;
            string medidas;
            string material;
            string tiempoEstimado;
            double precio;

            string encargoFinal;

            if (txtEncargo.Text == "" || txtPrecioEncargo.Text == "")
                MessageBox.Show("Por favor rellene los campos necearios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //Seteamos la cantidad
                if (cmbCantidadEncargo.SelectedIndex == 6)
                    cantidad = Convert.ToInt32(txtCantidadEncargo.Text);
                else
                    cantidad = Convert.ToInt32(cmbCantidadEncargo.Text);

                //Seteamos el encargo
                encargo = txtEncargo.Text;

                //Seteamos las medidas
                if (cmbCantidadEncargo.SelectedIndex == 9)
                    medidas = $"{txtAlto.Text}x{txtAncho.Text}";
                else
                    medidas = cmbMedidas.Text;

                //Seteamos el material
                material = cmbMaterial.Text;

                //Seteamos el tiempo estimado
                if (cmbTiempoEstimado.SelectedIndex == 8)
                    tiempoEstimado = txtCantidadDias.Text;
                else
                    tiempoEstimado = cmbTiempoEstimado.Text;

                //Seteamos el precio
                precio = Convert.ToDouble(txtPrecioEncargo.Text);

                //Generamos el encargo
                encargoFinal = $"x{cantidad} - {encargo} {medidas} {material} - {tiempoEstimado} - ${precio}";

                lbEncargos.Items.Add(encargoFinal);

                //Sumamos al total
                Total += precio;
                lblTotal.Text = Convert.ToString(Total);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //DECLARACIONES
            string usuario = txtUsuario.Text, observaciones = rtbObservaciones.Text, directorio = txtDirectorio.Text;
            float deuda = Convert.ToSingle(txtDeuda.Text);
            float monto = Convert.ToSingle(Total);
            bool ok = false;

            string productos = "";
            string encargos = "";
            
            DateTime fechaEntrada = dtpFechaEntrada.Value;
            DateTime fechaEntrega = dtpFechaEntrega.Value;

            frmClientes frmC = new frmClientes();

            int idCliente = 0;

            foreach (DataGridViewRow r in frmC.dgvClientes.Rows)
            {
                if ((r.Cells[1].Value).ToString().ToLower().Contains(usuario.ToLower()))
                {
                    idCliente = Convert.ToInt32(r.Cells[0].Value);
                }
            }

            //Seteamos productos
            foreach (var p in lbProductos.Items)
            {
                productos += " | " + p;
            }

            //Seteamos encargos
            foreach (var en in lbEncargos.Items)
            {
                encargos += " | " + en;    
            }

            ok = Business.Pedido.Insert_Pedido(usuario, fechaEntrada, fechaEntrega, productos, encargos, observaciones, deuda, monto, directorio);

            if (ok)
            {
                MessageBox.Show("Se ha insertado el pedido correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Business.Cliente.Update_LastWork(encargos, idCliente);

                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar insertar un pedido.", "La operacion ha fallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnSearchFolder_Click(object sender, EventArgs e)
        {
            if (fbdDirectorio.ShowDialog() == DialogResult.OK)
            {
                txtDirectorio.Text = fbdDirectorio.SelectedPath;
            }
        }
    }
}
