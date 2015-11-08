using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    class calculoAreaRombo
    {

        public cuadrilatero Area(cuadrilatero xR3)
        {
            xR3.AreaRombo = ((xR3.RomboDiagonalMayor * xR3.RomboDiagonalMenor)/2);
            return xR3;
        }
    }
}
