using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_ORDEN_TRABAJO : MAPPER<BE.ORDEN_TRABAJO>
    {
        public override void Eliminar(ORDEN_TRABAJO obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(ORDEN_TRABAJO obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@FallasDetalladas", obj.DetalleFallas),
                acceso.CrearParametro("@TareasRequeridas", obj.TareasReparacion),
                acceso.CrearParametro("@CostoTotal", obj.CostoTotal.ToString()),
                acceso.CrearParametro("@MecanicoAsignado_id", obj.MecanicoAsignado.Id),
                acceso.CrearParametro("@Estado", obj.Estado),
                acceso.CrearParametro("@Ficha_Id", obj.Ficha.Id)
            };

            acceso.Abrir();
            object resultado = acceso.EjecutarEscalar("sp_InsertarOrdenTrabajo", parametros);
            acceso.Cerrar();

            if (resultado != null && resultado != DBNull.Value)
            {
                obj.Id = Convert.ToInt32(resultado);
            }
        }

        public override List<ORDEN_TRABAJO> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar(ORDEN_TRABAJO obj)
        {
            throw new NotImplementedException();
        }

        public void ActualizarEstadoOT(ORDEN_TRABAJO obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@NumeroOT", obj.NumeroOT),
                acceso.CrearParametro("@Estado", obj.Estado)
            };

            acceso.Abrir();
            int res = acceso.Escribir("sp_ActualizarEstado_OT", parametros);
            acceso.Cerrar();
        }
    }
}
