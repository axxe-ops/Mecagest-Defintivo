using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class EstadoPresupuestada : IESTADO_OT
    {
        public void Aprobar(ORDEN_TRABAJO ot)
        {
            ot.EstadoComportamiento = new EstadoPresupuestada();
            ot.Estado = "Aprobada";
        }

        public void IniciarReparacion(ORDEN_TRABAJO ot)
        {
            throw new Exception("El cliente debe aprobar el presupuesto antes de iniciar la reparación.");
        }

        public void FinalizarReparacion(ORDEN_TRABAJO ot)
        {
            throw new Exception("No se puede finalizar una reparación que no ha comenzado.");
        }

        public void Pagar(ORDEN_TRABAJO ot)
        {
            throw new Exception("No se puede cobrar un presupuesto que no ha sido reparado.");
        }

        public void Entregar(ORDEN_TRABAJO ot)
        {
            throw new Exception("No se puede entregar el vehículo. La orden recién fue presupuestada.");
        }
    }
}