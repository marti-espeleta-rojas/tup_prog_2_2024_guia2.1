using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Empleado
    {
        public int DNI { get; private set; }
        public string Apellido { get; private set; }
        public string Nombre { get; private set; }
        public string ApellidoNombre
        {
            get
            {
                string apenom = $"{Apellido}-{Nombre}";
                return apenom;
            }
        }
        public int AñoContratado
        {
            get //Podemos asignar el valor de la propiedad a través del get a una variable para conocer este valor. 
            {   //int añoquerecibe=AñoContado; acá el get le está pasando el valor de la propiedad a añoquerecibe
                //AñoContado=añoquerecibe; acá el set le está asignando el valor de añoquerecibe a la propiedad AñoContado.
                return AñoContratado;
            }
            private set { }
        }
        public double MontoBasicoNominal { get; set; }
        public int HorasExtras50 { get; set; }
        public int HorasExtras100 { get; set; }

        public Empleado(string apellido, string nombre, int añoContratado, int dni)
        {
            Apellido = apellido;
            DNI = dni;
            Nombre = nombre;
            AñoContratado = añoContratado;
        }
    }
}
