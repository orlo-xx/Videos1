using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;
using SolucionEcuaciones.BL.Acciones;

namespace SolucionEcuaciones.BL.Especificaciones
{
    class ResolverPerimetroRombo
    {

        public double resolverPerimetro(cuadrilatero cT)
        {
            //Validaciones
            if ((cT.LadoRombo > 0) && (cT.RomboDiagonalMayor > 0) && (cT.RomboDiagonalMenor > 0))
            {


                sumaLadosRombo calcPerimetroRom = new sumaLadosRombo();
                cT = calcPerimetroRom.Suma(cT);

            }
            else
            {

                Exception ex = new Exception(string.Format("Ocurrió un error al calcular el Area, verifica que:" +
                    "Todos los lados son mayores a 0."));
                throw ex;
            }
            return cT.PerimetroRombo;
        }
    }
}
