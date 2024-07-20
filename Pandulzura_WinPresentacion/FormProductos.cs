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
        private Categoria nuevoCategoria;
        public FormProductos()
        {
            InitializeComponent();
            prodLogica = new ProductoLogica();
            nuevoProd = new Producto();
            nuevoCategoria = new Categoria(); 

        }

        //Listar
        public void ListarProd()
        {
            dgvProd.DataSource = prodLogica.ListarProducto();
        }

        //Insertar
        public void InsertarProd()
        {
            // Obtener valores de los controles y asignarlos al objeto Producto
            nuevoCategoria.IdCategoria = (int)cbxCategoria.SelectedValue; // Obtener el ID del rol seleccionado

            nuevoProd.NombreProd = producto.Text;
            nuevoProd.DescripcionProd = descripcion.Text;
            nuevoProd.PrecioProd = (double)precio.Value; // Asegúrate de que `precio` es un control de tipo NumericUpDown
            nuevoProd.DisponibilidadProd = disponibilidad.Text; // Asegúrate de que `disponibilidad` es un control de tipo NumericUpDown

            // Insertar el producto
            if (prodLogica.InsertarProducto(nuevoProd))
            {
                MessageBox.Show("El registro se insertó correctamente");
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
            //cbxCategoria.Text=("");
            producto.Clear();
            descripcion.Clear();
            precio.Value = 0;
            disponibilidad.Value = 0;
        }

        // Buscar Producto
        private void BuscarProd()
        {
            if (int.TryParse(productoid.Text, out int idProd)) // Verifica que 'productoid' es un TextBox
            {
                try
                {
                    Producto prod = prodLogica.BuscarProducto(idProd);

                    if (prod != null)
                    {
                        cbxCategoria.SelectedValue = prod.IdCategoria;


                        producto.Text = prod.NombreProd;
                        descripcion.Text = prod.DescripcionProd;
                        precio.Value = (decimal)prod.PrecioProd;
                        disponibilidad.Text = prod.DisponibilidadProd;
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un ID de producto válido");
            }
        }


        //// Actualizar Producto
        private void ActualizarProd()
        {
            try
            {
                int idProd = Convert.ToInt32(productoid.Text); // Asegúrate de que `productoid` es un control de entrada para el ID del producto

                // Crear el objeto Producto con los datos actualizados
                Producto prod = new Producto
                {
                    IdProd = idProd,
                    NombreProd = producto.Text,
                    DescripcionProd = descripcion.Text,
                    PrecioProd = (double)precio.Value,
                    DisponibilidadProd = disponibilidad.Text
                };

                if (prodLogica.ActualizarProducto(prod))
                {
                    MessageBox.Show("El registro se actualizó correctamente");
                    ListarProd();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message);
            }
        }


        // Eliminar Producto
        private void EliminarProd()
        {
            try
            {
                int idProd = Convert.ToInt32(productoid.Text); // Asegúrate de que `productoid` es un control de entrada para el ID del producto

                if (prodLogica.EliminarProducto(idProd))
                {
                    MessageBox.Show("Producto eliminado correctamente");
                    LimpiarCampos();
                    ListarProd();
                }
                else
                {
                    MessageBox.Show("Error al eliminar producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarProd();
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            ActualizarProd();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No de puede elimina por que depende de una categori, pero puede actulizarla");
        }
    }
}
