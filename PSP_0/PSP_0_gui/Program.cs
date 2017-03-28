using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSP_0_control;

namespace PSP_0_gui
{
    class Program
    {
        static void Main(string[] args)
        {
            String Cadena = null;  

            Console.WriteLine("**************************************");
            Console.WriteLine("Calculo de Media y Desviacion Estandar ");
            Console.WriteLine("**************************************");

            Console.WriteLine("Por favor digite el cuantos números desea ingresar: ");

            do
            {
                if (Cadena != null)
                    Console.WriteLine(Cadena);

                Cadena = Console.ReadLine();

            } while (ControlLista.Iniciar(Cadena) != null);

            Console.WriteLine("Usted va a ingresar " + Cadena + " números");

            Cadena = null;

            do
            {
                if (Cadena != null)
                    Console.WriteLine(Cadena);

                Cadena = Console.ReadLine();

                Cadena = ControlLista.AgregarNumero(Cadena);

            } while (Cadena == null);

            Console.WriteLine(Cadena);

            Console.ReadKey();
        }
    }
}
