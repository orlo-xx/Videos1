using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;
using SolucionEcuaciones.BL.Acciones;

namespace SolucionEcuaciones.BL.Especificaciones
{
    class resolverPerimetroCuadrado
    {

        public double resolverPerimetro(cuadrilatero cT)
        {
            //Validaciones
            if ((cT.LadoCuadrado1 > 0) && (cT.LadoCuadrado2 > 0))
            {
                sumaLadosCuadrado calcPerimetroCuad = new sumaLadosCuadrado();
                cT = calcPerimetroCuad.Suma(cT);

            }
            else
            {

                Exception ex = new Exception(string.Format("Ocurrió un error al calcular el Area, verifica que:" +
                    "Todos los lados son mayores a 0."));
                throw ex;
            }
            return cT.PerimetroCuadrado;
        }
    }
}