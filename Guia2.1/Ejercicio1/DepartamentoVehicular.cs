using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class DepartamentoVehicular
    {
        Random azar = new Random();
        public int CantidadRegistros { get; private set; }
        private ArrayList registros = new ArrayList();
        int numeroSerie = 10;
        public RegistroVehiculo RegistrarVehiculo(Persona propietario)
        {
            int patente = GenerarPatente();
            RegistroVehiculo registro = new RegistroVehiculo(patente, propietario, numeroSerie++);
            CantidadRegistros++;
            registros.Add(registro);
            return registro;
        }
        public RegistroVehiculo VerRegistro(int idx)
        {
            if (idx >=0 && idx < CantidadRegistros) 
            {
                return registros[idx] as RegistroVehiculo;
            }
            return null;
        }
        private int GenerarPatente()
        {
            int numeroPat = azar.Next(1000);
            return numeroPat;
        }
    }
}
