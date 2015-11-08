using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Figuras.DM;
using SolucionEcuaciones.BL.Especificaciones;

namespace WcfEcuaciones
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ResolverFiguras : IResolverFiguras
    {

        public double ResolverPoligonoWcf(int calculo, int catlados, double tamanoLados) {

            poligonoRegular pR = new poligonoRegular(catlados, tamanoLados);

            if (calculo == 1) {

                resolverAreaPoligono areaP = new resolverAreaPoligono();

                return areaP.resolverArea(pR);

            } else if (calculo == 2) {

                resolverPerimetroPoligono perimetroP = new resolverPerimetroPoligono();

                return perimetroP.resolverPerimetro(pR);
            }
            else {
                return 0;
            }
        }

        public double ResolverPoligonoWcf22(int calculo, int catlados, double tamanoLados)
        {

            poligonoRegular pR = new poligonoRegular(catlados, tamanoLados);

            if (calculo == 1)
            {

                resolverAreaPoligono areaP = new resolverAreaPoligono();

                return areaP.resolverArea(pR);

            }
            else if (calculo == 2)
            {

                resolverPerimetroPoligono perimetroP = new resolverPerimetroPoligono();

                return perimetroP.resolverPerimetro(pR);
            }
            else
            {
                return 0;
            }
        }

    }
}
