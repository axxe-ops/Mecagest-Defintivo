using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.frmNegocio
{
    public partial class frmRegistrarVehiculo : Form
    {
        BLL.GESTOR_ESTADIA gestorEstadia = new GESTOR_ESTADIA();

        CLIENTE clienteSeleccionado = null;
        public frmRegistrarVehiculo()
        {
            InitializeComponent();
        }

        private void frmRegistrarVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                string patente =txtPatente.Text;
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                string anio = txtAnio.Text;
                


                VEHICULO nuevoVehiculo = new VEHICULO(patente, marca, modelo, anio, );

                gestorEstadia.RegistrarNuevoVehiculo(nuevoVehiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarDueño_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDNI.Text))
                {
                    throw new Exception("Por favor, ingrese un número de DNI para buscar.");
                }

                int dni = int.Parse(txtDNI.Text);

                clienteSeleccionado = gestorEstadia.BuscarCliente(dni);

                if (clienteSeleccionado != null)
                {
                    List<CLIENTE> listaResultado = new List<CLIENTE>();
                    listaResultado.Add(clienteSeleccionado);

                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = listaResultado;
                }
                else
                {
                    dgvClientes.DataSource = null;
                    throw new Exception("El cliente no existe.");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("El DNI debe contener únicamente números.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarOrdenTrabajo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    clienteSeleccionado = (CLIENTE)dgvClientes.CurrentRow.DataBoundItem;

                    txtDueño.Text = $"{clienteSeleccionado.Nombre} {clienteSeleccionado.Apellido}";

                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al confirmar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
