using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primeira parte
            Thread.Sleep(1000);
            Console.SetCursorPosition(10, 4);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Meu ");
            Console.ResetColor();

            // Segundo parte
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Brasil ");
            Console.ResetColor();

            // Terceira parte
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" brasileiro ");
            Console.ResetColor();

            Console.ReadKey();

            Console.WriteLine("\n\n\n\n\n\n");
        }
    }
}
