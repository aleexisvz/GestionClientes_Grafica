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
    public partial class AMBProductos : Form
    {
        List<Entitys.Producto> oList_Productos = new List<Entitys.Producto>();

        public AMBProductos()
        {
            InitializeComponent();
            cargarProductos();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";

        }

        private void cargarProductos()
        {
            oList_Productos = Business.Producto.Consulta_Productos();
            if(oList_Productos != null)
            {
                dgvProductos.DataSource = oList_Productos;
                dgvProductos.Columns["IDProducto"].Visible = false;
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool ok = false;
            string Nombre, Descripcion;
            int Precio;
            int Unidad_Medida;

            if (txtNombre.Text != "" && txtDescripcion.Text != "" && txtPrecio.Text != "" )
            {
                //Ingresar producto
                Nombre = txtNombre.Text;
                Descripcion = txtDescripcion.Text;
                Precio = int.Parse(txtPrecio.Text);

                ok = Business.Producto.Insert_Product(Nombre, Precio, Descripcion);
                if (ok)
                {
                    MessageBox.Show("Se ha insertado correctamente el Producto", "Alexis V.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cargarProductos();
                    Limpiar();

                }
                else
                {
                    MessageBox.Show("No se ha podido insertar el Producto", "Alexis V.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay un campo que no se ha ingresado nada, por favor verifique lo que está ingresando", "Alexis V.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form menu = new Menu();
            menu.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Obtiene el producto seleccionado en la dgv
            int currentIdProduct = Convert.ToInt32(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString());
            var currentProduct = oList_Productos.FirstOrDefault(x => x.IDProducto == currentIdProduct);

            if (Business.Producto.Delete_Product(currentIdProduct))
            {
                MessageBox.Show("Se ha eliminado el producto satisfactoriamente", "Alexis V.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarProductos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool ok = false;
            string Nombre, Descripcion;
            int Precio;

            if (txtNombre.Text != "" && txtDescripcion.Text != "" && txtPrecio.Text != "")
            {
                //Modificar producto
                int IDProducto = Convert.ToInt32(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString()); ;
                Nombre = txtNombre.Text;
                Descripcion = txtDescripcion.Text;
                Precio = int.Parse(txtPrecio.Text);

                ok = Business.Producto.Modify_Product(Nombre, Descripcion, Precio, IDProducto);
                if (ok)
                {
                    MessageBox.Show("Se ha modificado el correctamente el Producto", "Alexis V.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cargarProductos();
                    Limpiar();

                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el Producto", "Alexis V.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay un campo que no se ha ingresado nada, por favor verifique lo que está ingresando", "Alexis V.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Limpiar();
            cargarProductos();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescripcion.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[2].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[3].Value.ToString();
        }
    }
}
