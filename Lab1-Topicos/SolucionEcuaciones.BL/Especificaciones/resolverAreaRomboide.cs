using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;
using SolucionEcuaciones.BL.Acciones;

namespace SolucionEcuaciones.BL.Especificaciones
{
    class resolverAreaRomboide
    {
        public double resolverArea(cuadrilatero cT)
        {
            //Validaciones
            if ((cT.LadoRomboide1 > 0) && (cT.LadoRomboide2 > 0) && (cT.AlturaRomboide > 0) && (cT.BaseRomboide > 0))
            {

                calculoAreaRomboide calcAreaide = new calculoAreaRomboide();
                cT = calcAreaide.Area(cT);

            }
            else
            {

                Exception ex = new Exception(string.Format("Ocurrió un error al calcular el Area, verifica que:" +
                    "Todos los lados son mayores a 0."));
                throw ex;
            }
            return cT.AreaRomboide;
        }

    }
}
