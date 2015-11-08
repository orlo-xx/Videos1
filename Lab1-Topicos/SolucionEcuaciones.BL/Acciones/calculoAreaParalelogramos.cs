using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    class calculoAreaParalelogramos
    {

        public cuadrilatero Area(cuadrilatero xR)
        {
            xR.AreaParalelogramo = (xR.BaseParalelogramo * xR.AlturaParalelogramo);
            return xR;
        }
    }
}
