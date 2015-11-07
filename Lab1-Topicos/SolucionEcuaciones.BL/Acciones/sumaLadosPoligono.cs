using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    public class sumaLadosPoligono
    {
        public poligonoRegular suma(poligonoRegular pR) {
            pR.perimetro = pR.cantidadLados * pR.tamanoLados;
            return pR;
        }
    }
}
