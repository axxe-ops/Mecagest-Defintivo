using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_VEHICULO : MAPPER<BE.VEHICULO>
    {
        public override void Eliminar(VEHICULO obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(VEHICULO obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@Patente", obj.Patente),
                acceso.CrearParametro("@Marca", obj.Marca),
                acceso.CrearParametro("@Modelo", obj.Modelo),
                acceso.CrearParametro("@Anio", obj.Anio),
                acceso.CrearParametro("@Cliente_Id", obj.Dueño.Id)
            };

            acceso.Abrir();
            acceso.Escribir("sp_InsertarVehiculo", parametros);
            acceso.Cerrar();
        }

        public override List<VEHICULO> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar(VEHICULO obj)
        {
            throw new NotImplementedException();
        }

        public VEHICULO BuscarPorPatente(string patente)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@Patente", patente)
            };

            acceso.Abrir();
            DataTable tabla = acceso.Leer("SP_BuscarVehiculoPorPatente", parametros);
            acceso.Cerrar();

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];

                // Instanciamos un Cliente "cascarón" solo con el Id para mantener la referencia
                // La capa BLL (Gestor) luego puede usar este Id para buscar los datos completos del dueño si hace falta.
                CLIENTE dueño = new CLIENTE(0, "", "", "", 0);
                dueño.Id = Convert.ToInt32(fila["Cliente_Id"]);

                VEHICULO vehiculo = new VEHICULO(
                    fila["Patente"].ToString(),
                    fila["Marca"].ToString(),
                    fila["Modelo"].ToString(),
                    Convert.ToInt32(fila["Anio"]),
                    dueño
                );

                return vehiculo;
            }
            return null;
        }
    }
}
