using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_0_modelo
{
    public class ListaIterador : Iterador
    {
        private Nodo Primero;
        private Nodo Ultimo;
        private Nodo Actual;

        public ListaIterador(Nodo Primero, Nodo Ultimo)
        {
            this.Primero = Primero;
            this.Ultimo = Ultimo;

            Actual = Primero;
        }

        public Double Siguiente()
        {
            Double Numero = 0;

            if(Actual!=null)
            {
                Numero = Actual.Numero;
                Actual = Actual.Siguiente;
            }

            return Numero;
        }

        public bool tieneSiguiente()
        {
            if (Actual == null)
                return false;

            return true;
        }
    }
}