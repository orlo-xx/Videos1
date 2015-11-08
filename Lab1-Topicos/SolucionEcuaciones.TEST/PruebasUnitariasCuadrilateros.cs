using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolucionEcuaciones.BL.Especificaciones;
using Figuras.DM;

namespace SolucionEcuaciones.TEST
{
    [TestClass]
    public class PruebasUnitariasCuadrilateros
    {
        [TestMethod]

        public void ProbarAreaParalelogramo()
        {
            cuadrilatero cua = new cuadrilatero();
            cua.AlturaParalelogramo = 7;
            cua.LadoParalelogramo1 = 5;
            cua.LadoParalelogramo2 = 5;
            cua.BaseParalelogramo = cua.LadoParalelogramo2;


            double resultadoEsperado = 35;
            double resultadoObtenido = 0;

            resolverAreaParalelogramo areaT = new resolverAreaParalelogramo();

            resultadoObtenido = areaT.resolverArea(cua);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }

        public void ProbarAreaCuadrado()
        {
            cuadrilatero cua = new cuadrilatero();
            cua.LadoCuadrado1 = 5;
            cua.LadoCuadrado2 = 5;
         
            double resultadoEsperado = 25;
            double resultadoObtenido = 0;

            resolverAreaParalelogramo areaT = new resolverAreaParalelogramo();

            resultadoObtenido = areaT.resolverArea(cua);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }
    }
}
