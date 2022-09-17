using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraHerencia
{
    internal class Operacion
    {

        protected double valor1;

        public double  Valor1
        {
            get { return valor1; }  
            set { valor1 = value; }
        }

        protected double valor2;
        public double Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }

        protected double resultado;

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }



    }
}
