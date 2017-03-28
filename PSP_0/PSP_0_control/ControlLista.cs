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
                return ControlCalculos.Calcular();

            return null;
        }
    }
}
