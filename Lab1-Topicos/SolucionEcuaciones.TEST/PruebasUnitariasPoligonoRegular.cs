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
        public void ProbarAreaResultadoConocido()
        {
            poligonoRegular pR = new poligonoRegular(20, 5);

            double resultadoEsperado = 64.95;
            double resultadoObtenido = 0;

            resolverAreaPoligono areaP = new resolverAreaPoligono();

            resultadoObtenido = areaP.resolverArea(pR);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }

        [TestMethod]
        public void ProbarPerimetroResultadoConocido()
        {
            poligonoRegular pR = new poligonoRegular(5, 2);

            double resultadoEsperado = 10;
            double resultadoObtenido = 0;

            resolverPerimetroPoligono perimetroP = new resolverPerimetroPoligono();

            resultadoObtenido = perimetroP.resolverPerimetro(pR);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }
    }
}
