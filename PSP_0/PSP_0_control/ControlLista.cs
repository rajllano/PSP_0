using System;
using PSP_0_modelo;

namespace PSP_0_control
{
    public static class ControlLista
    {
        private static int CantidadNumeros;
        private static int Contador;

        public static String Iniciar(String pCantidad)
        {
            int Cantidad;

            if (!Int32.TryParse(pCantidad, out Cantidad))
                return "La cantidad de numeros debe contener solo valores numericos";

            if(Cantidad<=0)
                return "La cantidad de numeros debe ser mayor a cero";

            ControlAplicacion.getInstancia().Lista = new Lista();
            CantidadNumeros = Cantidad;
            Contador = 0;

            return null;
        }

        public static String AgregarNumero(String pNumero)
        {
            float Numero;

            //Validamos que sea un numero

            if (!float.TryParse(pNumero, out Numero))
                return "La cadena debe contener solo valores numericos";

            ControlAplicacion.getInstancia().Lista.Agregar(Numero);

            Contador++;

            if (Contador == CantidadNumeros)
                return Calcular();

            return null;
        }

        public static String Calcular()
        {
            Iterador i;
            Double Promedio = 0;
            Double DesviacionEstandar = 0;

            i = ControlAplicacion.getInstancia().Lista.Iterador(); 

            while(i.tieneSiguiente())
                Promedio = Promedio + i.Siguiente();

            Promedio = Promedio / CantidadNumeros;

            i = ControlAplicacion.getInstancia().Lista.Iterador();

            Double Resta;
            Double Suma = 0;

            while (i.tieneSiguiente())
            {
                Resta = i.Siguiente() - Promedio;
                Resta = Math.Pow(Resta, 2);
                Suma = Suma + Resta;
            }

            DesviacionEstandar = Math.Sqrt(Suma / CantidadNumeros - 1);

            String Mensaje = String.Format("Media = {0} - Desviacion Estandar = {1}", Promedio, DesviacionEstandar);

            return Mensaje;
        }
    }
}
