using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    class sumaLadosRomboide
    {

        public cuadrilatero Suma(cuadrilatero cR4)
        {
            cR4.PerimetroRomboide = (2 * (cR4.LadoRomboide1 + cR4.LadoRomboide2));
            return cR4;
        }
    }
}
