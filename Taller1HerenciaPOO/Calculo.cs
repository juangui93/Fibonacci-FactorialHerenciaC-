using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1HerenciaPOO
{
    public class Calculo
    {
        //Atributos por usuario
        private int numero;

     
        //Métodos setter y getter

        public void setNumero(int valor)
        {
            this.numero = valor; 
        }

        public int getNumero()
        {
            return this.numero; 
        }
    }
}
