using InputKey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                    MessageBox.Show("Se ha producido un error: " + ex.Message, "Ha ocurrido un error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                {
                    MessageBox.Show("Se ha confirmado el pedido correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarPedidos();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "Ha ocurrido un error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            cmbCells.SelectedIndex = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Creamos la conexión
            SqlConnection oSqlConn = new SqlConnection("Server=ALEXIS-PC; DataBase= ProyectoGrafica; Integrated Security= true;");
            string command = "";

            //Seteamos el comando
            switch(cmbCells.SelectedIndex)
            {
                case 0:
                    string idCliente = InputDialog.mostrar("Ingrese el ID del cliente:");

                    command = $"UPDATE Pedido SET idCliente = '{idCliente}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 1:
                    string usuario = InputDialog.mostrar("Ingrese el usuario:");

                    command = $"UPDATE Pedido SET usuario = '{usuario}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 2:
                    string producto = InputDialog.mostrar("Ingrese el producto:");

                    command = $"UPDATE Pedido SET producto = '{producto}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 3:
                    string encargo = InputDialog.mostrar("Ingrese el encargo:");

                    command = $"UPDATE Pedido SET encargo = '{encargo}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 4:
                    string observaciones = InputDialog.mostrar("Ingrese las observaciones:");

                    command = $"UPDATE Pedido SET observaciones = '{observaciones}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 5:
                    string monto = InputDialog.mostrar("Ingrese el monto:");

                    command = $"UPDATE Pedido SET monto = '{monto}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 6:
                    string deuda = InputDialog.mostrar("Ingrese la deuda:");

                    command = $"UPDATE Pedido SET deuda = '{deuda}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 7:
                    string directorio = InputDialog.mostrar("Ingrese el directorio:");

                    command = $"UPDATE Pedido SET directorio = '{directorio}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;
            }

            //Ejecutamos el comando
            try
            {
                oSqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand(command, oSqlConn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Se ha actualizado correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oSqlConn.Close();
                cargarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
