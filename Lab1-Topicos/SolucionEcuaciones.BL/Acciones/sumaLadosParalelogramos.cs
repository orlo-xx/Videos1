using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    class sumaLadosParalelogramos
    {

        public cuadrilatero Suma(cuadrilatero cR)
        {
           cR.PerimetroParalelogramo = (2*(cR.LadoParalelogramo1 + cR.LadoParalelogramo2));
           return cR;
        }
    }
}
