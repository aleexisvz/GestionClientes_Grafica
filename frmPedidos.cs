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
        
        string Command, Modd;
        

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

            rtbModificar.Visible = false;
            label21.Visible = false;
            btnExecMod.Visible = false;
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
            label21.Visible = true;
            rtbModificar.Visible = true;
            btnExecMod.Visible = true;

            switch (cmbCells.SelectedIndex)
            {
                case 0:
                    Modd = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[1].Value.ToString();
                    rtbModificar.Text = Modd;
                    break;

                case 1:
                    Modd = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[2].Value.ToString();
                    rtbModificar.Text = Modd;
                    break;

                case 2:
                    Modd = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[6].Value.ToString();
                    rtbModificar.Text = Modd;
                    break;

                case 3:
                    Modd = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[7].Value.ToString();
                    rtbModificar.Text = Modd;
                    break;

                case 4:
                    Modd = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[8].Value.ToString();
                    rtbModificar.Text = Modd;
                    break;

                case 5:
                    Modd = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[9].Value.ToString();
                    rtbModificar.Text = Modd;
                    break;

                case 6:
                    Modd = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[10].Value.ToString();
                    rtbModificar.Text = Modd;
                    break;

                case 7:
                    Modd = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[11].Value.ToString();
                    rtbModificar.Text = Modd;
                    break;
            }

            
        }

        private void btnExecMod_Click(object sender, EventArgs e)
        {
            //Seteamos el comando
            switch (cmbCells.SelectedIndex)
            {
                case 0:
                    Command = $"UPDATE Pedido SET idCliente = '{rtbModificar.Text}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 1:
                    Command = $"UPDATE Pedido SET usuario = '{rtbModificar.Text}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 2:
                    Command = $"UPDATE Pedido SET producto = '{rtbModificar.Text}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 3:
                    Command = $"UPDATE Pedido SET encargo = '{rtbModificar.Text}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 4:
                    Command = $"UPDATE Pedido SET observaciones = '{rtbModificar.Text}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 5:
                    Command = $"UPDATE Pedido SET monto = '{rtbModificar.Text}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 6:
                    Command = $"UPDATE Pedido SET deuda = '{rtbModificar.Text}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;

                case 7:
                    Command = $"UPDATE Pedido SET directorio = '{rtbModificar.Text}' WHERE idPedido = {dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value}";
                    break;
            }

            MessageBox.Show(Command);

            //Creamos la conexión
            SqlConnection oSqlConn = new SqlConnection("Server=ALEXIS-PC; DataBase= ProyectoGrafica; Integrated Security= true;");

            //Ejecutamos el comando
            try
            {
                oSqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand(Command, oSqlConn);
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
