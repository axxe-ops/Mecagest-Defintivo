using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GESTOR_ESTADIA
    {
        DAL.MP_CLIENTE mapperCliente = new DAL.MP_CLIENTE();
        DAL.MP_VEHICULO mapperVehiculo = new DAL.MP_VEHICULO();
        DAL.MP_FICHA mapperFicha = new DAL.MP_FICHA();

        //-------------- GESTION CLIENTE ---------

        public CLIENTE BuscarCliente(int dni)
        {
            if (dni <= 0)
            {
                throw new Exception("El DNI ingresado no es válido.");
            }
            return mapperCliente.BuscarPorDNI(dni);
        }

        public void RegistrarNuevoCliente(CLIENTE cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                throw new Exception("El nombre y apellido son campos obligatorios.");
            }

            CLIENTE existente = BuscarCliente(cliente.DNI);
            if (existente != null)
            {
                throw new Exception("Ya existe un cliente registrado con este DNI.");                
            }

            mapperCliente.Insertar(cliente);
        }


        //---------------------- GESTION VEHICULO ---------------
        public VEHICULO BuscarVehiculo(string patente)
        {
            if (string.IsNullOrWhiteSpace(patente))
            {
                throw new Exception("La patente no puede estar vacía para la búsqueda.");
            }

            return mapperVehiculo.BuscarPorPatente(patente);
        }

        public void RegistrarNuevoVehiculo(VEHICULO vehiculo)
        {
            if (string.IsNullOrWhiteSpace(vehiculo.Patente) || string.IsNullOrWhiteSpace(vehiculo.Marca))
            {
                throw new Exception("La patente y la marca son datos obligatorios del vehículo.");
            }
            if (vehiculo.Dueño == null || vehiculo.Dueño.Id <= 0)
            {
                throw new Exception("No se puede registrar un vehículo sin asignarle un dueño existente.");
            }

            VEHICULO existente = BuscarVehiculo(vehiculo.Patente);
            if (existente != null)
            {
                throw new Exception("Esta patente ya se encuentra registrada en el sistema.");
            }

            mapperVehiculo.Insertar(vehiculo);
        }

        //----------------- GESTION FICHA --------------------
        public void RegistrarIngresoVehiculo(VEHICULO vehiculoSeleccionado, string descripcionProblema)
        {
            BE.FICHA nuevaFicha = new BE.FICHA();
            nuevaFicha.FechaIngreso = DateTime.Now;
            nuevaFicha.DescripcionCliente = descripcionProblema;
            nuevaFicha.Vehiculo = vehiculoSeleccionado;
            
            mapperFicha.Insertar(nuevaFicha);
        }
    }
}
