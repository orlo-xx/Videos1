using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    public class calculoApotemaPoligono
    {
        public poligonoRegular apotema(poligonoRegular pR) {

            pR.apotema = Math.Sqrt(Math.Pow(3, 2) - Math.Pow((pR.tamanoLados / 2), 2));
            //
            return pR;
        }
    }
}
