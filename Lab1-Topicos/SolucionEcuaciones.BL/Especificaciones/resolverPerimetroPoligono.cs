using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.DM;
using SolucionEcuaciones.BL.Acciones;

namespace SolucionEcuaciones.BL.Especificaciones
{
    public class resolverPerimetroPoligono
    {
        public double resolverPerimetro(poligonoRegular pR) {

            //Validaciones
            if ((pR.cantidadLados > 4 && pR.cantidadLados < 17) && pR.tamanoLados > 0) {

                sumaLadosPoligono sumaLados = new sumaLadosPoligono();
                pR = sumaLados.suma(pR);

            }else{

                Exception ex = new Exception(string.Format("Ocurrió un error al calcular el perímetro, verifica que:"+
                    "El tamaño de los lados sea > 2. \n La cantidad de lados sea > 4 pero < 16."));
                throw ex;
            }
            return pR.perimetro;
        }
       
    }
}
