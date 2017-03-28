using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSP_0_control;

namespace PSP_0_sqa
{
    [TestClass]
    public class PruebaUnitaria_1
    {
        [TestMethod]
        public void CalculoDesviacionEstandar_1()
        {
            String Respuesta = null;

            ControlLista.Iniciar("10");

            ControlLista.AgregarNumero("160");
            ControlLista.AgregarNumero("591");
            ControlLista.AgregarNumero("114");
            ControlLista.AgregarNumero("229");
            ControlLista.AgregarNumero("230");
            ControlLista.AgregarNumero("270");
            ControlLista.AgregarNumero("128");
            ControlLista.AgregarNumero("1657");
            ControlLista.AgregarNumero("624");
            Respuesta = ControlLista.AgregarNumero("1503");

            Assert.AreEqual(Respuesta, "Media = 550,6 - Desviación Estandar = 572,03");
        }
    }
}
