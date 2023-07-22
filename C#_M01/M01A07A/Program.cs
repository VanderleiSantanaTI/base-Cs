using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A07A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversao Implícita int->float
            /*
             int a = 8;
             float b = a;
            */
            // Conversao Implícitofloat->int
            /*
             float a = 8.99999f;
             int b = (int)a;
            */
            // Conversao por Classes Auxiliares
            /*
              float a = 8.501f;
              int b = Convert.ToInt16(a); // arredondamento para cima dodecimal acima de 0,5
            
            float a = 8.99999f;
            int b = (int)Math.Floor(a); // Arredondamento para baixo
            */

            float a = 8.99999f;
            int b = a; // Dá erro por causa do tipo
            Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
            Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType());
        }
    }
}
