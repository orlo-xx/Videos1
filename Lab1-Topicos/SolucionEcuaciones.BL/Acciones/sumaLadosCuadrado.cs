using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    class sumaLadosCuadrado
    {

        public cuadrilatero Suma(cuadrilatero cR2)
        {
            cR2.PerimetroCuadrado = (4 * (cR2.LadoCuadrado1));
            return cR2;
        }

    }
}
