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
    public class MP_CLIENTE : MAPPER<CLIENTE>
    {
        public override void Eliminar(CLIENTE obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(CLIENTE obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@DNI", obj.DNI),
                acceso.CrearParametro("@Nombre", obj.Nombre),
                acceso.CrearParametro("@Apellido", obj.Apellido),
                acceso.CrearParametro("@Correo", obj.Correo),
                acceso.CrearParametro("@Telefono", obj.Telefono)
            };

            acceso.Abrir();
            acceso.Escribir("sp_InsertarCliente", parametros);
            acceso.Cerrar();
        }

        public override List<CLIENTE> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar(CLIENTE obj)
        {
            throw new NotImplementedException();
        }

        public CLIENTE BuscarPorDNI(int dni)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@DNI", dni)
            };

            acceso.Abrir();
            DataTable tabla = acceso.Leer("sp_BuscarClientePorDNI", parametros);
            acceso.Cerrar();

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                CLIENTE cliente = new CLIENTE(
                    Convert.ToInt32(fila["DNI"]),
                    fila["Nombre"].ToString(),
                    fila["Apellido"].ToString(),
                    fila["Correo"].ToString(),
                    fila["Telefono"].ToString()
                );
                cliente.Id = Convert.ToInt32(fila["Id"]);
                return cliente;
            }
            return null;
        }
    }
}
