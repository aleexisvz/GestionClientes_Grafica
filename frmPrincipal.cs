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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelPedidoSubmenu.Visible = false;
            panelClientesSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if(panelPedidoSubmenu.Visible == true)
                panelPedidoSubmenu.Visible = false;
            if (panelClientesSubmenu.Visible == true)
                panelClientesSubmenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
            
        }

        #region PedidiosSubMenu
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPedidoSubmenu);
        }

        private void btnPrincipalP_Click(object sender, EventArgs e)
        {
            
            hideSubmenu();
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }

        private void btnModificarPedido_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }
        #endregion

        #region ClientesSubmenu
        private void btnPrincipalC_Click(object sender, EventArgs e)
        {
            openChildForm(new frmClientes());

            hideSubmenu();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            
            hideSubmenu();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubmenu(panelClientesSubmenu);
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }
    }
}
