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
    public partial class frmRegistrarCliente : Form
    {

        BLL.GESTOR_ESTADIA gestorEstadia = new GESTOR_ESTADIA();
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    throw new Exception("Todos los campos son obligatorios. Por favor, complete la información.");
                }


                int dni = int.Parse(txtDNI.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string telefono = txtTelefono.Text;
                string correo = txtCorreo.Text;


                CLIENTE nuevoCliente = new CLIENTE(dni, nombre, apellido, correo, telefono);
                gestorEstadia.RegistrarNuevoCliente(nuevoCliente);

                MessageBox.Show("Cliente registrado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDNI.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
