using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sal = 0;
            Console.Write("Qual é teu salário? R$");
            float.TryParse(Console.ReadLine(), out sal); // para leitura do número float
            Console.WriteLine($"Você ganha {sal:c} por mês");// o 'c' entro da {} coloca o formato de moeda da linguagem do sistema. 
            Console.ReadKey();
        }
    }
}
