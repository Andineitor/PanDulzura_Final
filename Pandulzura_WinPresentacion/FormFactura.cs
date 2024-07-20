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
    public partial class FormFactura : Form
    {
        private FacturaLogica facturaLogica = new FacturaLogica();


        public FormFactura()
        {
            InitializeComponent();
            ListarFacturas();

        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Factura nuevaFactura = new Factura
                {
                    FECHA_FACT = DateTime.Value,
                    TOTAL_FINAL = textValorF.Text,

                };

                if (facturaLogica.InsertarFac(nuevaFactura))
                {
                    MessageBox.Show("Factura agregada exitosamente.");
                    ListarFacturas();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ListarFacturas()
        {
            try
            {
                dataGridView1.DataSource = facturaLogica.ListarFact();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string facturaId = textFacturaId.Text;
                string nuevoValor = textValorF.Text;

                Factura factura = facturaLogica.ObtenerFacturaPorId(facturaId);
                if (factura != null)
                {
                    factura.TOTAL_FINAL = nuevoValor;
                    factura.FECHA_FACT = DateTime.Value; // Asumiendo que también quieras actualizar la fecha

                    if (facturaLogica.ActualizarFactura(factura))
                    {
                        MessageBox.Show("Factura actualizada exitosamente.");
                        ListarFacturas();
                    }
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



        private void DateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormFactura_Load(object sender, EventArgs e)
        {

        }

        private void ListarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string facturaId = textFacturaId.Text;
                string nuevoValor = textValorF.Text;
                DateTime nuevafecha = DateTime.Value;

                Factura factura = facturaLogica.ObtenerFacturaPorId(facturaId);
                if (factura != null)
                {
                    factura.TOTAL_FINAL = nuevoValor;
                    if (facturaLogica.ActualizarFactura(factura))
                    {
                        MessageBox.Show("Factura actualizada exitosamente.");
                        ListarFacturas();
                    }
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

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string facturaId = textFacturaId.Text;

                if (facturaLogica.EliminarFactura(facturaId))
                {
                    MessageBox.Show("Factura eliminada exitosamente.");
                    ListarFacturas();
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
    }
}
