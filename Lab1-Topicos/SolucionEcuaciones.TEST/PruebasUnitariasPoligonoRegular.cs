using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolucionEcuaciones.BL.Especificaciones;
using Figuras.DM;

namespace SolucionEcuaciones.TEST
{
    [TestClass]
    public class PruebasUnitariasPoligonoRegular
    {
        [TestMethod]
        public void ProbarResultadoConocido()
        {
            poligonoRegular pR = new poligonoRegular(6, 5);

            double resultadoEsperado = 64.95;
            double resultadoObtenido = 0;

            resolverAreaPoligono areaP = new resolverAreaPoligono();

            resultadoObtenido = areaP.resolverArea(pR);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }
    }
}
