using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    public class sumaLadosTriangulo
    {
        public triangulos Suma (triangulos tR)
        {
            tR.perimetro= (tR.lado1 + tR.lado2 + tR.lado3);
            return tR;
        }
    }
}
