using PSP_0_modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_0_control
{
    public static class ControlCalculos
    {
        public static String Calcular()
        {
            Double Promedio = Media();

            return String.Format("Media = {0} - Desviación Estandar = {1}", Promedio, DesviacionEstandar(Promedio));
        }

        private static Double Media()
        {
            Double Promedio = 0;
            int Contador = 0;
            Iterador i = ControlAplicacion.getInstancia().Lista.Iterador();

            while(i.tieneSiguiente())
            {
                Promedio = Promedio + i.Siguiente();
                Contador++;
            }
                
            Promedio = Promedio / Contador;

            return Math.Round(Promedio,2);
        }

        private static Double DesviacionEstandar(Double Promedio)
        {
            Double DesviacionEstandar = 0;
            int Contador = 0;
            Iterador i = ControlAplicacion.getInstancia().Lista.Iterador();

            Double Resta;
            Double Suma = 0;

            while (i.tieneSiguiente())
            {
                Resta = i.Siguiente() - Promedio;
                Resta = Math.Pow(Resta, 2);
                Suma = Suma + Resta;

                Contador++;
            }

            DesviacionEstandar = Math.Sqrt(Suma / (Contador - 1));

            return Math.Round(DesviacionEstandar,2);
        }
    }
}
