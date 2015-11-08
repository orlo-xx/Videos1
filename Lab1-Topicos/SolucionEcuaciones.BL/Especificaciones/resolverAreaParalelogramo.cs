using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;
using SolucionEcuaciones.BL.Acciones;

namespace SolucionEcuaciones.BL.Especificaciones
{
    public class resolverAreaParalelogramo
    {

        public double resolverArea(cuadrilatero cT)
        {
            //Validaciones
            if ((cT.AlturaParalelogramo > 0) && (cT.LadoParalelogramo1 > 0) && (cT.LadoParalelogramo2 > 0) && (cT.BaseParalelogramo > 0))
                {


                calculoAreaParalelogramos calcAreaPara = new calculoAreaParalelogramos();
                cT = calcAreaPara.Area(cT);
           
            }
            else
            {

                Exception ex = new Exception(string.Format("Ocurrió un error al calcular el Area, verifica que:" +
                    "Todos los lados son mayores a 0."));
                throw ex;
            }
            return cT.AreaParalelogramo;
        }


    }
}
