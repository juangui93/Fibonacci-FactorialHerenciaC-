using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Taller1HerenciaPOO
{
    public class Fibonacci : Calculo
    {
        public List<int> calcularFibonacci()
        {

            List<int> fibonacci = new List<int>();

            int numero;

            numero = this.getNumero();


            int a;
            int b;
            int c;

            a = 0;
            b = 1;
            c = 0;

            for (int i = 0; i < numero; i++)
            {
                if (i == 0)
                {
                    fibonacci.Add(i);
                }

                a = b + c;
                b = c;
                c = a;

                fibonacci.Add(a);
            }

            return fibonacci;
        }
 
    }
}
