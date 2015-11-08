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

            resolverAreaCuadrado areaT = new resolverAreaCuadrado();

            resultadoObtenido = areaT.resolverArea(cua);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }


        public void ProbarAreaRombo()
        {
            cuadrilatero cua = new cuadrilatero();
            cua.RomboDiagonalMayor = 10;
            cua.RomboDiagonalMenor = 5;


            double resultadoEsperado = 25;
            double resultadoObtenido = 0;

            resolverAreaRombo areaT = new resolverAreaRombo();

            resultadoObtenido = areaT.resolverArea(cua);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }

        public void ProbarAreaRomboide()
        {
            cuadrilatero cua = new cuadrilatero();
            cua.AlturaRomboide = 5;
            cua.LadoRomboide1 = 5;
            cua.LadoRomboide2 = 7;
            cua.BaseRomboide = cua.LadoRomboide2;

            double resultadoEsperado = 35;
            double resultadoObtenido = 0;

            resolverAreaRomboide areaT = new resolverAreaRomboide();

            resultadoObtenido = areaT.resolverArea(cua);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }

        public void ProbarAreaTrapecio()
        {
            cuadrilatero cua = new cuadrilatero();
            cua.AlturaTrapecio = 5;
            cua.TrapecioBaseMayor = 6;
            cua.TrapecioBaseMenor = 4;

            double resultadoEsperado = 25;
            double resultadoObtenido = 0;

            resolverAreaTrapecio areaT = new resolverAreaTrapecio();

            resultadoObtenido = areaT.resolverArea(cua);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }





        public void ProbarPerimetroParalelogramo()
        {
            cuadrilatero cua = new cuadrilatero();
            cua.LadoParalelogramo1 = 5;
            cua.LadoParalelogramo2 = 5;


            double resultadoEsperado = 20;
            double resultadoObtenido = 0;

            resolverPerimetroParalelogramo areaT = new resolverPerimetroParalelogramo();

            resultadoObtenido = areaT.resolverPerimetro(cua);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }

        public void ProbarPerimetroCuadrado()
        {
            cuadrilatero cua = new cuadrilatero();
            cua.LadoCuadrado1 = 5;
            cua.LadoCuadrado2 = 5;

            double resultadoEsperado = 20;
            double resultadoObtenido = 0;

            resolverPerimetroCuadrado areaT = new resolverPerimetroCuadrado();

            resultadoObtenido = areaT.resolverPerimetro(cua);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }

        public void ProbarPerimetroRombo()
        {
            cuadrilatero cua = new cuadrilatero();
            cua.LadoRombo = 7;


            double resultadoEsperado = 28;
            double resultadoObtenido = 0;

            ResolverPerimetroRombo areaT = new ResolverPerimetroRombo();

            resultadoObtenido = areaT.resolverPerimetro(cua);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }

        public void ProbarPerimetroRomboide()
        {
            cuadrilatero cua = new cuadrilatero();
            cua.LadoRomboide1 = 5;
            cua.LadoRomboide2 = 7;

            double resultadoEsperado = 24;
            double resultadoObtenido = 0;

            resolverPerimetroRomboide areaT = new resolverPerimetroRomboide();

            resultadoObtenido = areaT.resolverPerimetro(cua);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }

        public void ProbarPerimetroTrapecio()
        {
            cuadrilatero cua = new cuadrilatero();
            cua.ladoTrapecio1 = 5;
            cua.ladoTrapecio2 = 5;
            cua.TrapecioBaseMayor = 6;
            cua.TrapecioBaseMenor = 4;


            double resultadoEsperado = 20;
            double resultadoObtenido = 0;

            resolverPerimetroTrapecio areaT = new resolverPerimetroTrapecio();

            resultadoObtenido = areaT.resolverPerimetro(cua);

            Assert.IsTrue(resultadoEsperado == resultadoObtenido);

        }
    }
}
