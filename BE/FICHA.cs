using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FICHA
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int numeroFicha;
        public int NumeroFicha
        {
            get { return numeroFicha; }
            set { numeroFicha = value; }
        }

        private DateTime fechaIngreso;
        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }

        private DateTime fechaEgreso;

        public DateTime FechaEgreso
        {
            get { return fechaEgreso; }
            set { fechaEgreso = value; }
        }

        private string descripcionCliente;
        public string DescripcionCliente
        {
            get { return descripcionCliente; }
            set { descripcionCliente = value; }
        }

        private VEHICULO vehiculo;
        public VEHICULO Vehiculo
        {
            get { return vehiculo; }
            set { vehiculo = value; }
        }


        

    }
}
