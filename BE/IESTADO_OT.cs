using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public interface IESTADO_OT
    {
        void Aprobar(ORDEN_TRABAJO ot);
        void IniciarReparacion(ORDEN_TRABAJO ot);
        void FinalizarReparacion(ORDEN_TRABAJO ot);
        void Pagar(ORDEN_TRABAJO ot);
        void Entregar(ORDEN_TRABAJO ot);


    }
}