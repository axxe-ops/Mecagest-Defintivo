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

namespace GUI
{
    public partial class frmRegistrarEstadia : Form
    {
        public BLL.GESTOR_ESTADIA gestorEstadia = new GESTOR_ESTADIA();

        private CLIENTE clienteSeleccionado = null;
        private VEHICULO vehiculoSeleccionado = null;
        private ORDEN_TRABAJO otSeleccionada = null;

        public frmRegistrarEstadia()
        {
            InitializeComponent();
        }

        private void frmRegistrarEstadia_Load(object sender, EventArgs e)
        {

        }


        //-------------- INGRESO --
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDNI.Text))
                {
                    throw new Exception("Por favor, ingrese un número de DNI para buscar.");
                }

                int dni = int.Parse(txtDNI.Text);

                clienteSeleccionado = gestorEstadia.BuscarCliente(dni);

                if(clienteSeleccionado != null)
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

        private void btnConfirmarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    clienteSeleccionado = (CLIENTE)dgvClientes.CurrentRow.DataBoundItem;

                    txtClienteConfirmado.Text = $"CLIENTE: {clienteSeleccionado.Nombre} {clienteSeleccionado.Apellido}\r\n" +
                       $"DNI: {clienteSeleccionado.DNI}\r\n" +
                       $"Teléfono: {clienteSeleccionado.Telefono}\r\n" +
                       $"Correo: {clienteSeleccionado.Correo}";

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

        private void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = txtDescripcionProblema.Text;
                gestorEstadia.RegistrarIngresoVehiculo(vehiculoSeleccionado, descripcion);

                MessageBox.Show("Ingreso registrado correctamente. Ficha generada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clienteSeleccionado = null;
                vehiculoSeleccionado = null;
                dgvClientes.DataSource = null;
                dgvVehiculos.DataSource = null;
                txtDNI.Clear(); 
                txtPatente.Clear(); 
                txtDescripcionProblema.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPatente.Text))
                {
                    throw new Exception("Por favor, ingrese la patente para buscar.");
                }

                string patente = txtPatente.Text;

                vehiculoSeleccionado = gestorEstadia.BuscarVehiculo(patente);

                if (vehiculoSeleccionado != null)
                {
                    List<VEHICULO> listaResultado = new List<VEHICULO>();
                    listaResultado.Add(vehiculoSeleccionado);

                    dgvVehiculos.DataSource = null;
                    dgvVehiculos.DataSource = listaResultado;
                }
                else
                {
                    MessageBox.Show("El vehículo no existe.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVehiculos.CurrentRow != null)
                {
                    vehiculoSeleccionado = (VEHICULO)dgvVehiculos.CurrentRow.DataBoundItem;

                    txtVehiculoConfirmado.Text = $"VEHÍCULO: {vehiculoSeleccionado.Marca} {vehiculoSeleccionado.Modelo} ({vehiculoSeleccionado.Anio})\r\n" +
                        $"Patente: {vehiculoSeleccionado.Patente}";
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

        // --------------- EGRESO --
        private void btnConfirmarOrdenTrabajo_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.CurrentRow != null)
            {
                otSeleccionada = (ORDEN_TRABAJO)dgvOrdenes.CurrentRow.DataBoundItem;

                txtNumeroFicha.Text = otSeleccionada.Ficha.NumeroFicha.ToString();
                txtClienteEgreso.Text = $"{otSeleccionada.Ficha.Vehiculo.Dueño.Nombre} {otSeleccionada.Ficha.Vehiculo.Dueño.Apellido}";
                txtVehiculoEgreso.Text = $"{otSeleccionada.Ficha.Vehiculo.Marca} {otSeleccionada.Ficha.Vehiculo.Modelo} - {otSeleccionada.Ficha.Vehiculo.Patente}";

                txtEstadoOT.Text = otSeleccionada.Estado;
            }
        }
    }
}
