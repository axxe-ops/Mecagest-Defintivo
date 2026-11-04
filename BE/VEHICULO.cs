using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class VEHICULO
    {
        public VEHICULO(string patente, string marca, string modelo, int anio, CLIENTE clienteDueño)
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Dueño = clienteDueño;
        }


        private CLIENTE dueño;
        public CLIENTE Dueño
        {
            get { return dueño; }
            set { dueño = value; }
        }

        private string patente;
        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private int anio;
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }




    }
}
