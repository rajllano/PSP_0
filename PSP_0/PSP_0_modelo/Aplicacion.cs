using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_0_modelo
{
    public class Aplicacion
    {
        public Lista Lista { get; set; }

        public Aplicacion()
        {
            Lista = new PSP_0_modelo.Lista();
        }
    }
}