using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(20, 5);
            Console.ForegroundColor = ConsoleColor.DarkGray; // letra sinza
            Console.BackgroundColor = ConsoleColor.Yellow; //fundo amarelo
            Console.WriteLine("Olá, querido(a) estudonauta!");
            Console.ResetColor();  //para resetar a cor
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(10, 3);
            Console.ForegroundColor = ConsoleColor.White; // letra branco
            Console.BackgroundColor = ConsoleColor.Blue; //fundo azul
            Console.WriteLine("Tudo bem comvocê");
            Console.ReadKey();

        }
    }
}
