using Figuras.DM;
using SolucionEcuaciones.BL.Acciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolucionEcuaciones.BL.Especificaciones
{
    class resolverPerimetroTriangulos
    {
        public double resolverArea(triangulos tR)
        {
            //Validaciones
            if ((tR.lado1 != 0 && tR.lado2 != 0 && tR.lado3 != 0) && (tR.lado1 <= (tR.lado2 + tR.lado3)) || (tR.lado2 <= (tR.lado1 + tR.lado3)) || (tR.lado3 <= (tR.lado2 + tR.lado1)))
            {

                sumaLadosTriangulo calcPerimetro = new sumaLadosTriangulo();
                tR = calcPerimetro.Suma(tR);
            }
            else
            {

                Exception ex = new Exception(string.Format("Ocurrió un error al calcular el Area, verifica que:" +
                    "Todos los lados son mayores a 0. \n La suma de 2 lados sea menor o igual al tercer lado."));
                throw ex;
            }
            return tR.perimetro;
        }
    }
}
