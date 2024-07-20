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
    }
}
