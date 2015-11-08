using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figuras.DM;
using SolucionEcuaciones.BL.Especificaciones;

namespace SolucionEcuaciones.TEST
{
    [TestClass]
    public class PruebasUnitariasTriangulo
    {
        [TestMethod]
        public void ProbarAreaResultadoConocido()
        {
            triangulos tr = new triangulos(5, 5, 5);

            double resultadoEsperado = 10.82531755;
            double resultadoObtenido = 0;

            resolverAreaTriangulos areaT = new resolverAreaTriangulos();

            resultadoObtenido = areaT.resolverArea(tr);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }

        [TestMethod]
        public void ProbarPerimetroResultadoConocido()
        {
            triangulos tr = new triangulos(5, 5, 5);

            double resultadoEsperado = 15;
            double resultadoObtenido = 0;

            resolverPerimetroTriangulos perimetroP = new resolverPerimetroTriangulos();

            resultadoObtenido = perimetroP.resolverPerimetro(tr);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }
    }
}
