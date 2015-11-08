using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    class sumaLadosTrapecio
    {

        public cuadrilatero Suma(cuadrilatero cR5)
        {
            cR5.PerimetroTrapecio = (cR5.ladoTrapecio1 + cR5.ladoTrapecio2 + cR5.TrapecioBaseMayor + cR5.TrapecioBaseMenor);
            return cR5;
        }
    }
}
