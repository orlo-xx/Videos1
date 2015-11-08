using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    class calculoAreaRomboide
    {

        public cuadrilatero Area(cuadrilatero xR4)
        {
            xR4.AreaRomboide = (xR4.BaseRomboide * xR4.AlturaRomboide);
            return xR4;
        }
    }
}
