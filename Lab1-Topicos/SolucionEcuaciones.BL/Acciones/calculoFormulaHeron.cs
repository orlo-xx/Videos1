using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    public class calculoFormulaHeron
    {
        public triangulos formulaHeron (triangulos tR)
        {
            double semiperimetro = (tR.lado3/2);
            tR.area = Math.Sqrt(semiperimetro * (semiperimetro - tR.lado1) * (semiperimetro - tR.lado2) * (semiperimetro - tR.lado3));
            return tR;
        }
    }
}
