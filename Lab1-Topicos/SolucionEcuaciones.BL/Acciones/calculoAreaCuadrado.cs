using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    class calculoAreaCuadrado
    {

        public cuadrilatero Area(cuadrilatero xR2)
        {
            xR2.AreaCuadrado = (xR2.LadoCuadrado1 * xR2.LadoCuadrado2);
            return xR2;
        }
    }
}
