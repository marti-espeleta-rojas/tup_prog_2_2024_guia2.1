using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Persona
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }

        public Persona (int dni,  string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }
    }
}
