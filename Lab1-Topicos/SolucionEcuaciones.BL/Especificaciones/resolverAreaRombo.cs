using Figuras.DM;
using SolucionEcuaciones.BL.Acciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEcuaciones.BL.Especificaciones
{
    public class resolverAreaRombo
    {

        public double resolverArea(cuadrilatero cT)
        {
            //Validaciones
            if ((cT.LadoRombo > 0) && (cT.RomboDiagonalMayor > 0) && (cT.RomboDiagonalMenor > 0) )
            {


                calculoAreaRombo calcAreaRom = new calculoAreaRombo();
                cT = calcAreaRom.Area(cT);

            }
            else
            {

                Exception ex = new Exception(string.Format("Ocurrió un error al calcular el Area, verifica que:" +
                    "Todos los lados son mayores a 0."));
                throw ex;
            }
            return cT.AreaRombo;
        }
    }
}
