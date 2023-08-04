using System;

namespace M02EX008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esntrada
            int num = 0;
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out num);

            string tipo = num % 2 == 0 ? "PAR" : "IMPAR";
            // mostar resultado
            Console.WriteLine($"O número {num:D} é {tipo} ");
            Console.ReadKey();
        }
    }
}
