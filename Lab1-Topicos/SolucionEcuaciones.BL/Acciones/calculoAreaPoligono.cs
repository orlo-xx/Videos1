using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;

namespace SolucionEcuaciones.BL.Acciones
{
    public class calculoAreaPoligono
    {
        public poligonoRegular area(poligonoRegular pR) {

            calculoApotemaPoligono calcApo = new calculoApotemaPoligono();
            sumaLadosPoligono sumaLados = new sumaLadosPoligono();

            pR.area = ((pR.perimetro)*(pR.apotema)) / 2;

            return pR;
            //
        }
    }
}
