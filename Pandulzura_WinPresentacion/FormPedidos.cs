using Pandulzura_AccesoDatos.Entidades;
using Pandulzura_LogicaNegocio;
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
    public partial class FormPedidos : Form
    {
        private UsuarioLogica usuarioLogica;
        private PedidosLogica pedidosLogica;
        private Pedidos nuevoPedido;
        public FormPedidos()
        {
            InitializeComponent();
            usuarioLogica = new UsuarioLogica();
            pedidosLogica = new PedidosLogica();
            nuevoPedido = new Pedidos();
        }
        public void ListarUser()
        {
            cbxUser.DataSource = usuarioLogica.ListarUser();
            cbxUser.DisplayMember = "Nombre_User";
            cbxUser.ValueMember = "Usuario_Id";
        }
        public void ListarPedidos()
        {
            dvgListarPedidos.DataSource = pedidosLogica.ListarPedidos();
        }

        public void InsertarPedido()
        {
            nuevoPedido.PedidoId = txtPedido.TabIndex;
            nuevoPedido.FechaPedido = DateTime.Value;
            nuevoPedido.UsuarioId = int.Parse(cbxUser.SelectedValue.ToString());
            nuevoPedido.EstadoPedido = (Pedidos.Estado)cbxEstado.SelectedItem;

            if (pedidosLogica.InsertarPedido(nuevoPedido))
            {
                MessageBox.Show("El registro se inserto correctamente");
                ListarPedidos();
                //limpiarComponentes();
            }
            else
            {
                MessageBox.Show("Error: El registro no se inserto correctamente");
            }
        }
        private void FormPedidos_Load(object sender, EventArgs e)
        {
            cbxEstado.DataSource = Enum.GetValues(typeof(Pedidos.Estado));
            ListarUser();
            ListarPedidos();

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            InsertarPedido();
        }
    }
}