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
    public partial class FormCategorias : Form
    {
        private CategoriaLogica cateLogica;
        private Categoria nuevaCate;
        public FormCategorias()
        {
            InitializeComponent();
            cateLogica = new CategoriaLogica();
            nuevaCate = new Categoria();
        }

        //Listar
        public void ListarCategoria()
        {
            dgvCategoria.DataSource = cateLogica.ListarCategoria();
        }

        //Insertar
        public void InsertarCategoria()
        {
            nuevaCate.IdCategoria = idCategoria.TabIndex;
            nuevaCate.NombreCategoria = categoria.Text;
            if (cateLogica.InsertarCategoria(nuevaCate))
            {
                MessageBox.Show("EL registro se inserto correctamente");
                ListarCategoria();
            }
            else
            {
                MessageBox.Show("Error al insertar");

            }
        }
        //limpiar
        private void LimpiarCampos()
        {
            idCategoria.Clear();
            categoria.Clear();
        }

        private void BuscarCategoria()
        {
            try
            {
                int idCategoria = Convert.ToInt32(txtIdCategoria.Text); // Asegúrate de tener un TextBox para ingresar el ID de la categoría a buscar
                Categoria categoria = categoriaLogica.BuscarCategoriaPorId(idCategoria);

                if (categoria != null)
                {
                    // Rellenar los campos del formulario con los datos de la categoría
                    txtNombreCategoria.Text = categoria.NombreCategoria;
                }
                else
                {
                    MessageBox.Show("Categoría no encontrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar categoría: " + ex.Message);
            }
        }

        private void EliminarCategoria()
        {
            try
            {
                int idCategoria = Convert.ToInt32(txtIdCategoria.Text); // Asegúrate de tener un TextBox para ingresar el ID de la categoría a eliminar
                if (categoriaLogica.EliminarCategoria(idCategoria))
                {
                    MessageBox.Show("Categoría eliminada correctamente");
                    //LimpiarCampos(); // Limpia los campos del formulario después de eliminar
                    ListarCategorias(); // Actualiza la lista de categorías
                }
                else
                {
                    MessageBox.Show("Error al eliminar categoría");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar categoría: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarCategoria();
        }

        private void limpiarbt_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void listarbt_Click(object sender, EventArgs e)
        {
            ListarCategoria();
        }

        private void idCategoria_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            BuscarCategoria();
        }

        private void Eliminarbt_Click(object sender, EventArgs e)
        {
            EliminarCategoria();
        }