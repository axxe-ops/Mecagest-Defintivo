using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ORDEN_TRABAJO_BLL
    {
        DAL.MP_ORDEN_TRABAJO mapperOT = new DAL.MP_ORDEN_TRABAJO();

        public void GenerarOrdenTrabajo(BE.ORDEN_TRABAJO ot)
        {
            if (string.IsNullOrWhiteSpace(ot.DetalleFallas) ||
                string.IsNullOrWhiteSpace(ot.TareasReparacion))
            {
                throw new Exception("Debe detallar las fallas y las tareas requeridas para la reparación.");
            }

            if (ot.MecanicoAsignado == null || ot.MecanicoAsignado.Id == 0)
            {
                throw new Exception("No hay mecánicos disponibles o no se ha asignado uno a la tarea.");
            }

            mapperOT.Insertar(ot);
        }


    }
}
