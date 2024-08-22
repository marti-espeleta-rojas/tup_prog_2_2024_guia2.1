using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Empresa
    {
        public int AñoActual { get; set; }
        private ArrayList liquidaciones = new ArrayList();
        private ArrayList empleados = new ArrayList();
        public Empleado RegistrarEmpleado(string apellido, string nombre, int dni, double montoBasico, int horasExtras50, int horasExtras100, int añoContratado)
        {
            Empleado empleado = new Empleado(apellido, nombre, añoContratado, dni);
            empleado.HorasExtras50 = horasExtras50;
            empleado.HorasExtras100 = horasExtras100;
            empleado.MontoBasicoNominal = montoBasico;
            empleados.Add(empleado);
            return empleado;
        }
        public void GenerarLiquidaciones(int mes, int año)
        {
            for (int i = 0; i < empleados.Count; i++)
            {
                Empleado emple = empleados[i] as Empleado; //Acá casteo y hago que sólo me muestre los objetos de tipo empleado en el arraylist.
                Liquidacion liqui = new Liquidacion(emple, año, mes);
                liqui.PorcGremiales = 1.5d;
                liqui.PorcObraSocial = 3d;
                liqui.PorcJubilado = 18d;
                liquidaciones.Add(liqui);
            }
        }
        public ArrayList ListarLiquidaciones(int mes, int año, ref int cantidad)
        {
            ArrayList liquid = new ArrayList();
            for (int i =0; i < liquidaciones.Count; i++)
            {
                Liquidacion liq = liquidaciones[i] as Liquidacion;  
                if (año == liq.Año && mes==liq.Mes)
                {
                    liquid.Add(liq);
                    cantidad++;
                }
            }
            return liquid;
        }
        public double VerMontoLiquidacion(int mes, int año)
        {
            double monto = 0;
            for (int i=0; i < liquidaciones.Count; i++)
            {
                Liquidacion liq = liquidaciones[i] as Liquidacion;
                if (año == liq.Año && mes == liq.Mes)
                {
                    monto = liq.ACobrar;
                }
            }
            return monto;
        }
        public string MostrarReciboSueldo(int año, int mes, int dni)
        {
            string recibo="";
            for (int i = 0; i < liquidaciones.Count; i++)
            {
                Liquidacion liq = liquidaciones[i] as Liquidacion;
                if (año == liq.Año && mes == liq.Mes)
                {
                    recibo = liq.VerImpreso();
                }
            }
            return recibo;
        }
    }
}
