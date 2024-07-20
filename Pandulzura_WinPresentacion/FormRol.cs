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

    public partial class FormRol : Form
    {
        private RolLogica rolLogica;
        private Rol nuevoRol;

        public FormRol()
        {
            InitializeComponent();
            rolLogica = new RolLogica();
            nuevoRol = new Rol();
        }

        //Listar
        public void listarRol()
        {
            dgvRol.DataSource = rolLogica.ListarRol();
        }

        //Insertar
        public void insertarRol()
        {
            //nuevoRol.IdRol = txtRol.TabIndex;
            nuevoRol.NombreRol = txtNombre.Text;
            if (rolLogica.InsertarRol(nuevoRol))
            {
                MessageBox.Show("EL registro se Inserto correctamente");
                listarRol();
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
            // Agrega más líneas para limpiar otros campos si es necesario
        }

        //Eliminar
        private void EliminarRol()
        {
            try
            {
                int idRol = Convert.ToInt32(txtRol.Text); // Asegúrate de tener un TextBox para ingresar el ID del usuario a eliminar
                if (rolLogica.EliminarRol(idRol))
                {
                    MessageBox.Show("Usuario eliminado correctamente");
                    LimpiarCampos(); // Limpia los campos del formulario después de eliminar
                  
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

        //Buscar
        public void buscarRol()
        {
            if (int.TryParse(txtRol.Text, out int idRol))
            {
                Rol rol = rolLogica.BuscarRol(idRol);
                if (rol != null)
                {
                    txtNombre.Text = rol.NombreRol;
                }
                else
                {
                    MessageBox.Show("Rol no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un ID de rol válido");
            }
        }

        // Actualizar
        public void actualizarRol()
        {
            if (int.TryParse(txtRol.Text, out int idRol))
            {
                Rol rol = new Rol
                {
                    IdRol = idRol,
                    NombreRol = txtNombre.Text
                };

                if (rolLogica.ActualizarRol(rol))
                {
                    MessageBox.Show("El rol se actualizó correctamente.");
                    listarRol();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el rol.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un ID de rol válido.");
            }
        }


        private void FormRol_Load(object sender, EventArgs e)
        {
            listarRol();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listarRol();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            insertarRol();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarRol();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRol();
            listarRol();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarRol();
        }
    }
}
