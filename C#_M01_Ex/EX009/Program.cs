﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX009
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        // lendo produto 1
            Console.Write("\nProduto 1: ");
            
            string n1 = Console.ReadLine().Trim();
            Console.Write("Preço 1: R$");
            float p1;
            float.TryParse(Console.ReadLine(), out p1);
            // lendo produto 2
            Console.Write("Produto 2: ");
            string n2 = Console.ReadLine().Trim();
            Console.Write("Preço 2: ");
            float p2;
            float.TryParse(Console.ReadLine(), out p2);
            //Resultado.
            Console.SetCursorPosition(0, 10);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{" Produto", -20}{"Preço ", 13}");
            Console.ResetColor();
            Console.BackgroundColor= ConsoleColor.DarkGray;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine($"{n1, -20}{p1, 13:c2}");
            Console.WriteLine($"{n2,-20}{p2, 13:c2}");


            Console.ReadKey();


        }
    }
}
