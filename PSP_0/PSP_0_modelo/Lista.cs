using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_0_modelo
{
    public class Lista
    {
        public Nodo Primero { get; set; }

        public Nodo Ultimo { get; set; }

        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }

        public void Agregar(float Numero)
        {
            Nodo NodoNuevo = new Nodo();
            NodoNuevo.Numero = Numero;

            if(this.Primero == null)
            {
                this.Primero = NodoNuevo;
                this.Primero.Siguiente = null;

                this.Ultimo = NodoNuevo;
            }
            else
            {
                this.Ultimo.Siguiente = NodoNuevo;
                NodoNuevo.Siguiente = null;

                Ultimo = NodoNuevo;
            }
        }

        public ListaIterador Iterador()
        {
            return new ListaIterador(this.Primero, this.Ultimo);
        }
    }
}