using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;
using SolucionEcuaciones.BL.Acciones;

namespace SolucionEcuaciones.BL.Especificaciones
{
    public class resolverPerimetroTrapecio
    {
        public double resolverPerimetro(cuadrilatero cT)
        {
            //Validaciones
            if ((cT.ladoTrapecio1 > 0) && (cT.ladoTrapecio2 > 0) && (cT.TrapecioBaseMayor > 0) && (cT.TrapecioBaseMenor > 0) && (cT.AlturaTrapecio > 0))
            {

                sumaLadosTrapecio calcPerimetroTra = new sumaLadosTrapecio();
                cT = calcPerimetroTra.Suma(cT);

            }
            else
            {

                Exception ex = new Exception(string.Format("Ocurrió un error al calcular el Area, verifica que:" +
                    "Todos los lados son mayores a 0."));
                throw ex;
            }
            return cT.PerimetroTrapecio;
        }
    }
}
