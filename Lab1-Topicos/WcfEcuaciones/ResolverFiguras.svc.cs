using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Figuras.DM;
using SolucionEcuaciones.BL.Especificaciones;

namespace WcfEcuaciones
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ResolverFiguras : IResolverFiguras
    {

        public double ResolverPoligonoWcf(int queCalcular, int catlados, double tamanoLados) {

            poligonoRegular pR = new poligonoRegular(catlados, tamanoLados);

            if (queCalcular == 1) {

                resolverAreaPoligono areaP = new resolverAreaPoligono();

                return areaP.resolverArea(pR);

            } else if (queCalcular == 2) {

                resolverPerimetroPoligono perimetroP = new resolverPerimetroPoligono();

                return perimetroP.resolverPerimetro(pR);
            }
            else {
                return 0;
            }
        }

        public double ResolverTrianguloWcf(int queCalcular, double lado1, double lado2, double lado3)
        {

            triangulos tr = new triangulos(lado1, lado2, lado3);

            if (queCalcular == 1)
            {

                resolverAreaTriangulos areaT = new resolverAreaTriangulos();

                return areaT.resolverArea(tr);

            }
            else if (queCalcular == 2)
            {

                resolverPerimetroTriangulos perimetroT = new resolverPerimetroTriangulos();

                return perimetroT.resolverPerimetro(tr);
            }
            else
            {
                return 0;
            }
        }

        public double ResolverCuadrilateroWcf(int queCalcular, int tipoCuadrilatero, double lado1, double lado2, double altura)
        {

            if (queCalcular == 1)
            {
                cuadrilatero cua = new cuadrilatero();
                //resolverAreaCuadrilatero areaCua = new resolverAreaCuadrilatero();

                //switch (tipoCuadrilatero)
                //{
                //    case 1://Paralelogramo
                //        cua.AlturaParalelogramo = altura;
                //        cua.LadoParalelogramo1 = lado1;
                //        cua.LadoParalelogramo2 = lado2;
                //        return areaCua;
                //        break;
                //    case 2://Cuadrado
                //        cua.LadoCuadrado1 = lado1;
                //        cua.LadoCuadrado2 = lado2;
                //        return areaCua;
                //        break;
                //    case 3://Rombo
                //        cua.LadoRombo = altura;
                //        cua.RomboDiagonalMayor = lado1;
                //        cua.RomboDiagonalMenor = lado2;
                //        return areaCua;
                //        break;
                //    case 4://Romboide
                //        cua.AlturaRomboide = altura;
                //        cua.LadoRomboide1 = lado1;
                //        cua.LadoRomboide2 = lado2;
                //        return areaCua;
                //        break;
                //    case 5://Trapecio
                //        cua.AlturaTrapecio = altura;
                //        cua.ladoTrapecio1 = lado1;
                //        cua.ladoTrapecio2 = lado2;
                //        return areaCua;
                //        break;
                //    default:
                //        return 0;
                //}              

            }
            else if (queCalcular == 2)
            {
                cuadrilatero cua = new cuadrilatero();
                //resolverAreaCuadrilatero areaCua = new resolverAreaCuadrilatero();

                //switch (tipoCuadrilatero)
                //{
                //    case 1://Paralelogramo
                //        cua.AlturaParalelogramo = altura;
                //        cua.LadoParalelogramo1 = lado1;
                //        cua.LadoParalelogramo2 = lado2;
                //        return areaCua;
                //        break;
                //    case 2://Cuadrado
                //        cua.LadoCuadrado1 = lado1;
                //        cua.LadoCuadrado2 = lado2;
                //        return areaCua;
                //        break;
                //    case 3://Rombo
                //        cua.LadoRombo = altura;
                //        cua.RomboDiagonalMayor = lado1;
                //        cua.RomboDiagonalMenor = lado2;
                //        return areaCua;
                //        break;
                //    case 4://Romboide
                //        cua.AlturaRomboide = altura;
                //        cua.LadoRomboide1 = lado1;
                //        cua.LadoRomboide2 = lado2;
                //        return areaCua;
                //        break;
                //    case 5://Trapecio
                //        cua.AlturaTrapecio = altura;
                //        cua.ladoTrapecio1 = lado1;
                //        cua.ladoTrapecio2 = lado2;
                //        return areaCua;
                //        break;
                //    default:
                //        return 0;
                //}
            }
            else
            {
                return 0;
            }
            return 0;
        }

    }
}
