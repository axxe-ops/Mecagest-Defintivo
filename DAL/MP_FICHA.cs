using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_FICHA : MAPPER<BE.FICHA>
    {
        public override void Eliminar(FICHA obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(FICHA obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@FechaIngreso", obj.FechaIngreso),
                acceso.CrearParametro("@DescripcionCliente", obj.DescripcionCliente),
                acceso.CrearParametro("@Vehiculo_Id", obj.Vehiculo.Id)
            };

            acceso.Abrir();
            object resultado = acceso.EjecutarEscalar("sp_InsertarFicha", parametros);
            acceso.Cerrar();

            if (resultado != null && resultado != DBNull.Value)
            {
                obj.NumeroFicha = Convert.ToInt32(resultado);
            }
        }

        public override List<FICHA> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar(FICHA obj)
        {
            throw new NotImplementedException();
        }

        public void ActualizarFechaEgreso(FICHA obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@NumeroFicha", obj.NumeroFicha),
                acceso.CrearParametro("@FechaEgreso", obj.FechaEgreso)
            };

            acceso.Abrir();
            int res = acceso.Escribir("sp_ActualizarFicha_FechaEgreso", parametros);
            acceso.Cerrar();

        }
    }
}
