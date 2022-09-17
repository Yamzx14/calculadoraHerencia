using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraHerencia
{
    internal class Sumar:Operacion //Herenecia de la clase operacion
    {
        public double operar(double v1,double v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado= valor1+ valor2;
        }


    }
}
