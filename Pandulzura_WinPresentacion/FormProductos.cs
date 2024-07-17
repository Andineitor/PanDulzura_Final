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
    public partial class FormProductos : Form
    {
        private ProductoLogica prodLogica;
        private Producto nuevoProd;
        public FormProductos()
        {
            InitializeComponent();
            prodLogica = new ProductoLogica();
            nuevoProd = new Producto();

        }

        //Listar
        public void ListarProd()
        {
            dgvProd.DataSource = prodLogica.ListarProducto();
        }

        //Insertar
        public void InsertarProd()
        {
            nuevoProd.IdProd = productoid.Text;
            nuevoProd.NombreProd = producto.Text;
            nuevoProd.DescripcionProd = descripcion.Text;
            nuevoProd.PrecioProd = precio.DecimalPlaces = 2;
            nuevoProd.DisponibilidadProd = disponibilidad.Bottom;

            if (prodLogica.InsertarProducto(nuevoProd))
            {
                MessageBox.Show("EL registro se inserto correctamente");
                ListarProd();
            }
            else
            {
                MessageBox.Show("Error al insertar");

            }
        }
        //limpiar
        private void LimpiarCampos()
        {
            productoid.Clear();
            categoriaid.Clear();
            producto.Clear();
            descripcion.Clear();
            precio.Value = 0;
            disponibilidad.Value = 0;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            InsertarProd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            ListarProd();
        }

        private void categoriaid_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
