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
            String Respuesta;

            ControlLista.Iniciar("3");

            ControlLista.AgregarNumero("5");
            ControlLista.AgregarNumero("3");
            Respuesta = ControlLista.AgregarNumero("8");

            Console.WriteLine(Respuesta);

            Console.ReadKey();
        }
    }
}
