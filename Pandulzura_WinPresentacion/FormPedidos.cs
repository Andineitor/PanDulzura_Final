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
            nuevoPedido.PedidoId = txtIdPedido.TabIndex;
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

        private void BuscarPedido()
        {
            try
            {
                int idPedido = Convert.ToInt32(txtIdPedido.Text); 
                Pedidos pedido = pedidosLogica.BuscarPedidoPorId(idPedido);

                if (pedido != null)
                {
                    // Rellenar los campos del formulario con los datos del pedido
                    cbxUser.SelectedValue = pedido.UsuarioId;
                    DateTime.Value = pedido.FechaPedido;
                    cbxEstado.SelectedItem = pedido.EstadoPedido;
                }
                else
                {
                    MessageBox.Show("Pedido no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pedido: " + ex.Message);
            }
        }

        private void EliminarPedido()
        {
            try
            {
                int idPedido = Convert.ToInt32(txtIdPedido.Text); // Asegúrate de tener un TextBox para ingresar el ID del usuario a eliminar
                if (pedidosLogica.EliminarPedidos(idPedido))
                {
                    MessageBox.Show("Usuario eliminado correctamente");
                    //LimpiarCampos(); // Limpia los campos del formulario después de eliminar
                    ListarUser(); // Actualiza la lista de usuarios
                }
                else
                {
                    MessageBox.Show("Error al eliminar usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }

        //public void ActualizarPedido()
        //{
        //    try
        //    {
        //        Pedidos pedidoActualizado = new Pedidos
        //        {
        //            PedidoId = int.Parse(txtIdPedido.Text),
        //            UsuarioId = int.Parse(cbxUser.SelectedValue.ToString()),
        //            FechaPedido = DateTime.Value,
        //            EstadoPedido = (Pedidos.Estado)Enum.Parse(typeof(Pedidos.Estado), cbxEstado.SelectedItem.ToString())
        //        };

        //        if (pedidosLogica.ActualizarPedido(pedidoActualizado))
        //        {
        //            MessageBox.Show("Pedido actualizado correctamente");
        //            ListarPedidos();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Error: No se pudo actualizar el pedido");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al actualizar pedido: " + ex.Message);
        //    }
        //}

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            cbxEstado.DataSource = Enum.GetValues(typeof(Pedidos.Estado));
            ListarUser();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            InsertarPedido();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPedido();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarPedido();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarPedidos();
        }
    }
}