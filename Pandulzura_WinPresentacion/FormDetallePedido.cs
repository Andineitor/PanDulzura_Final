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
    public partial class FormDetallePedido : Form
    {
        private DetallePedidoLogica detalleLogica;
        private DetallePedido nuevoDetalle;

        public FormDetallePedido()
        {
            InitializeComponent();
            detalleLogica = new DetallePedidoLogica();
            nuevoDetalle = new DetallePedido();
            ListarDetalle();
        }

        //Listar
        public void ListarDetalle()
        {
            dgtDetalle.DataSource = detalleLogica.ListarDetalle();
        }

        //Insertar
        public void InsertarDetalle()
        {
            nuevoDetalle.ProductoId = productid.Text;
            nuevoDetalle.CantidadPedido = Cantidad.Text;

            if (detalleLogica.InsertarDetalle(nuevoDetalle))
            {
                MessageBox.Show("EL registro se inserto correctamente");
                ListarDetalle();
            }
            else
            {
                MessageBox.Show("Error al insertar");

            }
        }
        private void LimpiarCampos()
        {
            productid.Clear();
            Cantidad.Clear();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DetalleId_TextChanged(object sender, EventArgs e)
        {

        }

        private void PedidoId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FacturaId_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductoId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            InsertarDetalle();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            ListarDetalle();
        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgtDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormDetallePedido_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void productid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string detalleid =  txtdetalleid.Text;

                if (detalleLogica.EliminarDetalle(detalleid))
                {
                    MessageBox.Show("Factura eliminada exitosamente.");
                    ListarDetalle();
                }
                else
                {
                    MessageBox.Show("Factura no encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void detalleid_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
