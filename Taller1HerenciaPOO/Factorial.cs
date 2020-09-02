using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Taller1HerenciaPOO
{
    public class Factorial : Calculo
    {
        int factorial; 

        public int getFactorial()
        {
            return factorial; 
        }

        public void calcularFactorial()
        {
            int i;

            factorial = 1; 

            if (this.getNumero() < 0)
            {
                factorial = 0; 
            }else if (this.getNumero() == 0)
            {
                factorial = 1; 
            }else
            {
                for (i = 1; i <= this.getNumero(); i++)
                {
                    factorial = factorial * i; 
                }
            }
        }
       
    }
}
