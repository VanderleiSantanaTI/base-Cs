using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A05B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte idade = 25;
            ushort @publico = 45_239;
            float média = 4.5f;
            decimal estela_maior = 4.9847373723m;
            bool _aprovado = false;

            Console.WriteLine(idade);
            Console.WriteLine(@publico);
            Console.WriteLine(média);
            Console.WriteLine(estela_maior);
            Console.WriteLine(_aprovado);
            Console.ReadKey();


        }
    }
}
