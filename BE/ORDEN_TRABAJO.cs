using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ORDEN_TRABAJO
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private FICHA ficha;
        public FICHA Ficha
        {
            get { return ficha; }
            set { ficha = value; }
        }

        private USUARIO mecanicoAsignado;
        public USUARIO MecanicoAsignado
        {
            get { return mecanicoAsignado; }
            set { mecanicoAsignado = value; }
        }

        private int numeroOT;
        public int NumeroOT
        {
            get { return numeroOT; }
            set { numeroOT = value; }
        }

        private string estado;
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string detalleFallas;
        public string DetalleFallas
        {
            get { return detalleFallas; }
            set { detalleFallas = value; }
        }

        private string tareasReparacion;
        public string TareasReparacion
        {
            get { return tareasReparacion; }
            set { tareasReparacion = value; }
        }

        private decimal costoTotal;
        public decimal CostoTotal
        {
            get { return costoTotal; }
            set { costoTotal = value; }
        }



    }
}
