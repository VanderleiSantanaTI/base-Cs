using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EX007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ini, fim;

            Console.WriteLine("\nSORTEADOR DE NÚMEROS");
            Console.WriteLine("-----------------------");
            Console.Write("Início: ");
            int.TryParse(Console.ReadLine(), out ini);
            Console.Write("Fim: ");
            int.TryParse(Console.ReadLine(), out fim);

            Console.WriteLine("-----------------------");
            Console.SetCursorPosition(0, 6);
            Console.Write("Sorteando.");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 6);
            Console.Write("Sorteando..");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 6);
            Console.Write("Sorteando...");
            Thread.Sleep(1000);

            Console.SetCursorPosition(0, 6);
            Random gerador = new Random();
            int num = gerador.Next(ini, fim + 1);
            Console.WriteLine($"Entre {ini} e {fim} sorteei o valor {num}.");
            Console.ReadKey();

        }
    }
}
