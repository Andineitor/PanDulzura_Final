using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pandulzura_AccesoDatos.Entidades;
using Pandulzura_LogicaNegocio;

namespace Pandulzura_WinPresentacion
{
    public partial class FormUser : Form
    {
        private UsuarioLogica userLogica;
        private Usuario nuevoUser;

        //Listar
        public void ListarUser()
        {
            grid.DataSource = userLogica.ListarUser();
        }

        //Insertar
        public void InsertarUser()
        {
            nuevoUser.IdUser = txtId.Text;
            nuevoUser.RolesId = txtRol.TabIndex;
            nuevoUser.CedulaUser = txtCedula.TabIndex;
            nuevoUser.MailUser = txtMail.Text;
            nuevoUser.TelefonoUser = txtTelefono.TabIndex;
            nuevoUser.DireccionUser = txtDireccion.Text;
            nuevoUser.ContrasenaUser = txtContra.Text;

            if (userLogica.InsertarUsuario(nuevoUser))
            {
                MessageBox.Show("EL registro se Inserto correctamente");
                ListarUser();
            }
            else
            {
                MessageBox.Show("Error al insertar");

            }
        }
        private void LimpiarCampos()
        {
            // Limpiar el contenido de los TextBox u otros controles que desees limpiar
            txtRol.Clear();
            txtNombre.Clear();
            txtCedula.Clear();
            txtMail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtContra.Clear();
            txtId.Clear();
            // Agrega más líneas para limpiar otros campos si es necesario
        }
        public FormUser()
        {
            InitializeComponent();
            userLogica = new UsuarioLogica();
            nuevoUser = new Usuario();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnIuser(object sender, EventArgs e)
        {
            InsertarUser();
        }

        private void btnLuser(object sender, EventArgs e)
        {
            ListarUser();
        }

        private void btnCuser(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void gridUser(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}