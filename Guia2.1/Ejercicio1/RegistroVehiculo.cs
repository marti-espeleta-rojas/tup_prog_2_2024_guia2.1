using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class RegistroVehiculo
    {
        public int Patente { get; private set; }
        public int Serie { get; set; }

        public Persona Propietario { get; private set; }
        public RegistroVehiculo(int patente, Persona propietario, int serie) 
        {
            Patente = patente;
            Serie = serie;
            Propietario= propietario;
        }
        public string VerDetalle()
        {
            string detalles;
            detalles = $"*{Propietario.Nombre}, DNI: {Propietario.DNI}, Patente: {Patente}, Serie: {Serie}";
            return detalles;
        }
    }
}
