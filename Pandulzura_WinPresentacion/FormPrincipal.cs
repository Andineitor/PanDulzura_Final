using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandulzura_WinPresentacion
{
    public partial class FormPrincipal : Form
    {
      

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Usuario()
        {
            FormUser frmNuevoUser = new FormUser();
            frmNuevoUser.MdiParent = this;
            frmNuevoUser.Show();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Usuario();


        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Usuario();
        }

        private void Rol()
        {
            FormRol frmNuevoRol = new FormRol();
            frmNuevoRol.MdiParent = this;
            frmNuevoRol.Show();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rol();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            Rol();
        }

        private void Productos()
        {
            FormProductos frmNuevoProducto = new FormProductos();
            frmNuevoProducto.MdiParent = this;
            frmNuevoProducto.Show();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Productos();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos();
        }


        private void Categorias()
        {
            FormCategorias frmNuevoCategorias = new FormCategorias();
            frmNuevoCategorias.MdiParent = this;
            frmNuevoCategorias.Show();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Categorias();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias();
        }

        private void Pedidos()
        {
            FormPedidos frmNuevoPedido = new FormPedidos();
            frmNuevoPedido.MdiParent = this;
            frmNuevoPedido.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Pedidos();
        }


        private void DetalleP()
        {
            FormDetallePedido frmNuevoDetallePedido = new FormDetallePedido();
            frmNuevoDetallePedido.MdiParent = this;
            frmNuevoDetallePedido.Show();
        }

        private void detallePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalleP();
        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            DetalleP();
        }

        private void Fatura()
        {
            FormFactura frmFactura = new FormFactura();
            frmFactura.MdiParent = this;
            frmFactura.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Fatura();
        }
    }
}
