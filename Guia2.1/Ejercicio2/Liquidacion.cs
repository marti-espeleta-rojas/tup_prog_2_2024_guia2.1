using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Liquidacion
    {
        #region Propiedades cortas.
        public int Año { get; private set; }
        public int Mes { get; private set; }
        public double PorcObraSocial { get; set; }
        public double PorcJubilado { get; set; }
        public double PorcGremiales { get; set; }
        public Empleado empleado { get; private set; }
        #endregion

        #region Propiedades largas.
        public double MontoBasico { get; private set; }
        public double PorcAntiguedad { get; private set; }
        public double MontoAntiguedad { get; private set; }
        public double HorasExtra50 { get; private set; }
        public double MontoExtras50 { get; private set; }
        public double HoraExtra100 { get; private set; }
        public double MontoExtra100 { get; private set; }
        public double Nominal { get; private set; }
        public double MontoObraSocial { get; private set; }
        public double MontoJubilado { get; private set; }
        public double MontoGremial { get; private set; }
        public double Neto { get; private set; }
        public double Productividad { get; private set; }
        public double ACobrar { get; private set; }
        #endregion
        int Contador = 1;
        public Liquidacion(Empleado empleado, int año, int mes)
        {
            Año = año;
            Mes = mes;
            this.empleado = empleado;
        }
        public string VerImpreso()
        {
            string datos = $@"---{Contador++}
                            Empleado {empleado.ApellidoNombre}
                       ------------------------------------------------------------------------
                                Concepto                    Haberes             Descuentos
                                Básico                      {MontoBasico:f2}
                                Antigüedad                  {MontoAntiguedad:f2}
                                Extras al 50%               {MontoExtras50:f2}
                                Extras al 100%              {MontoExtra100:f2}
                                Obra Social                                         {MontoObraSocial:f2}
                                Jubilación                                          {MontoJubilado:f2}
                                Ap. Gremiales                                       {MontoGremial:f2}
                                Productividad               {Productividad:f3}
                       ------------------------------------------------------------------------
                            Totales                             {Nominal:f2}        {Neto}
                       ------------------------------------------------------------------------
                                                                A Cobrar           {ACobrar:c2}";
            return datos;
        }

    }

}
