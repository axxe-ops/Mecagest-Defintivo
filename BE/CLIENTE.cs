using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CLIENTE
    {
        public CLIENTE(int dni, string nombre, string apellido, string correo, string telefono)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
        }


        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private int dni;
        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string correo;
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        private string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private List<VEHICULO> vehiculos;
        public List<VEHICULO> Vehiculos
        {
            get { return vehiculos; }
            set { vehiculos = value; }
        }


    }
}
