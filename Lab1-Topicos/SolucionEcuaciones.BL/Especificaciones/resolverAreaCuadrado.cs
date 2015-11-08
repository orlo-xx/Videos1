﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;
using SolucionEcuaciones.BL.Acciones;

namespace SolucionEcuaciones.BL.Especificaciones
{
    class resolverAreaCuadrado
    {

        public double resolverArea(cuadrilatero cT)
        {
            //Validaciones
            if ((cT.LadoCuadrado1 > 0) && (cT.LadoCuadrado2 > 0))
            {
                calculoAreaCuadrado calcAreaCuad = new calculoAreaCuadrado();
                cT = calcAreaCuad.Area(cT);
           
            }
            else
            {

                Exception ex = new Exception(string.Format("Ocurrió un error al calcular el Area, verifica que:" +
                    "Todos los lados son mayores a 0."));
                throw ex;
            }
            return cT.AreaCuadrado;
        }
    }
}