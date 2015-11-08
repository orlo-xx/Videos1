using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    class sumaLadosRombo
    {

        public cuadrilatero Suma(cuadrilatero cR3)
        {
            cR3.PerimetroRombo = (4 * (cR3.LadoRombo));
            return cR3;
        }
    }
}
