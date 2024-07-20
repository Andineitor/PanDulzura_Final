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
        private RolLogica rolLogica;
        private Usuario nuevoUser;
        //private Rol nuevoRol;


        //Listar
        public void ListarUser()
        {
            grid.DataSource = userLogica.ListarUser();
        }


        //Insertar
        public void InsertarUser()
        {
            
            nuevoUser.RolesId = (int)cbxRol.SelectedValue; // Obtener el ID del rol seleccionado
            nuevoUser.CedulaUser = txtCedula.TabIndex;
            nuevoUser.NombreUser= txtNombre.Text;
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
            
            txtNombre.Clear();
            txtCedula.Clear();
            txtMail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtContra.Clear();
            txtId.Clear();
            // Agrega más líneas para limpiar otros campos si es necesario
        }


        private void BuscarUser()
        {
            try
            {
                int idUser = Convert.ToInt32(txtId.Text); // Asegúrate de tener un TextBox para ingresar el ID del usuario a buscar
                Usuario usuario = userLogica.BuscarUser(idUser);

                if (usuario != null)
                {
                    // Rellenar los campos del formulario con los datos del usuario
                    cbxRol.SelectedValue = usuario.RolesId;
                    txtNombre.Text = usuario.NombreUser;
                    txtCedula.Text = usuario.CedulaUser.ToString();
                    txtMail.Text = usuario.MailUser;
                    txtTelefono.Text = usuario.TelefonoUser.ToString();
                    txtDireccion.Text = usuario.DireccionUser;
                    txtContra.Text = usuario.ContrasenaUser;
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message);
            }
        }


        private void EliminarUser()
        {
            try
            {
                int idUser = Convert.ToInt32(txtId.Text); // Asegúrate de tener un TextBox para ingresar el ID del usuario a eliminar
                if (userLogica.EliminarUser(idUser))
                {
                    MessageBox.Show("Usuario eliminado correctamente");
                    LimpiarCampos(); // Limpia los campos del formulario después de eliminar
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

        // Actualizar
        public void ActualizarUsuario()
        {
            if (int.TryParse(txtId.Text, out int IdUser))
            {
                Usuario usuario = new Usuario
                {
                    IdUser = IdUser,
                    RolesId = Convert.ToInt32(cbxRol.SelectedValue), // Usa SelectedValue para obtener el ID del rol
                    NombreUser = txtNombre.Text,
                    CedulaUser = Convert.ToInt64(txtCedula.Text),
                    MailUser = txtMail.Text,
                    TelefonoUser = Convert.ToInt64(txtTelefono.Text),
                    DireccionUser = txtDireccion.Text,
                    ContrasenaUser = txtContra.Text
                };

                if (userLogica.ActualizarUsuario(usuario))
                {
                    MessageBox.Show("El registro se actualizó correctamente");
                    ListarUser();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un ID de usuario válido");
            }
        }


        public FormUser()
        {
            InitializeComponent();
            userLogica = new UsuarioLogica();
            nuevoUser = new Usuario();
            rolLogica = new RolLogica();
            LoadRoles(); // Cargar roles cuando se inicializa el formulario

        }
        private void LoadRoles()
        {
            // Obtener roles de la base de datos
            DataTable roles = rolLogica.ListarRol(); // Necesitas implementar ListarRoles en UsuarioLogica
            cbxRol.DataSource = roles;
            cbxRol.DisplayMember = "nombre_rol"; // Ajusta el nombre de la columna según tu tabla
            cbxRol.ValueMember = "roles_id";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void ce_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUser();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUser();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
        }
    }
}