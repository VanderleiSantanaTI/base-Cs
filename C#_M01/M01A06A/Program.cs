using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A06A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ESCOLA = "estudonauta";
            const float PI = 3.1415f;

            //escola = "CursoEmVideo"; // comando dá erro
            Console.WriteLine("Eu estudo no " + ESCOLA);
            Console.WriteLine("O valor de Pi é: " + PI);
            Console.WriteLine("O valor OFICIAL de PI é: " + Math.PI);
            Console.WriteLine("O tipo de PI no meu programa é " + PI.GetType()); // tipo single e gasta menos memória
            Console.WriteLine("O tipo de PI em Math é " + Math.PI.GetType()); // tipo bouble gasta mais memória
            Console.ReadKey();

        }
    }
}
