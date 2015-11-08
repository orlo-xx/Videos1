using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    class calculoAreaTrapecio
    {

        public cuadrilatero Area(cuadrilatero xR5)
        {
            xR5.AreaTrapecio = (((xR5.TrapecioBaseMayor + xR5.TrapecioBaseMenor) * xR5.AlturaTrapecio) / 2);
            return xR5;
        }
    }
}
