using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome + "! Tudo bem? (forma concatenada)");
            Console.WriteLine($"Olá, {nome}! Tudo bem? (forma Interpolada)");

            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.WriteLine($"a data atual é {dia}/{mes}/{ano}");
            Console.ReadKey();
        }
    }
}
