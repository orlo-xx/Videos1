using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;
using SolucionEcuaciones.BL.Acciones;

namespace SolucionEcuaciones.BL.Especificaciones
{
    public class resolverPerimetroRomboide
    {
        public double resolverPerimetro(cuadrilatero cT)
        {
            //Validaciones
            if ((cT.LadoRomboide1 > 0) && (cT.LadoRomboide2 > 0) && (cT.AlturaRomboide > 0) && (cT.BaseRomboide > 0))
            {

                sumaLadosRomboide calcPerimetroide = new sumaLadosRomboide();
                cT = calcPerimetroide.Suma(cT);

            }
            else
            {

                Exception ex = new Exception(string.Format("Ocurrió un error al calcular el Area, verifica que:" +
                    "Todos los lados son mayores a 0."));
                throw ex;
            }
            return cT.PerimetroRomboide;
        }
    }
}
