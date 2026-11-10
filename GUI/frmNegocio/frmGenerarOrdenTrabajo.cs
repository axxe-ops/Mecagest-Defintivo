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
    public partial class frmGenerarOrdenTrabajo : Form
    {
        BLL.ORDEN_TRABAJO_BLL gestorOT = new BLL.ORDEN_TRABAJO_BLL();
        public frmGenerarOrdenTrabajo()
        {
            InitializeComponent();
        }

        private void lblVehiculoConfirmado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BE.ORDEN_TRABAJO nuevaOT = new BE.ORDEN_TRABAJO();

                nuevaOT.DetalleFallas = txtDetalleFallas.Text;
                nuevaOT.TareasReparacion = txtTareasReparacion.Text;

                if (!decimal.TryParse(txtCostoEstimado.Text, out decimal costo))
                {
                    throw new Exception("El costo estimado debe ser un valor numérico válido.");
                }
                nuevaOT.CostoTotal = costo;

                if (cmbMecanicoAsignado.SelectedItem == null)
                {
                    throw new Exception("Debe seleccionar un mecánico de la lista.");
                }
                nuevaOT.MecanicoAsignado = (BE.USUARIO)cmbMecanicoAsignado.SelectedItem;

                //ficha¿?

                gestorOT.GenerarOrdenTrabajo(nuevaOT);

                MessageBox.Show("Orden de trabajo generada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
