using System;

namespace M02EX021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num = 0;
            Console.Write("Digite um número real: ");
            float.TryParse(Console.ReadLine(), out num); // se num = 3,6
            Console.WriteLine($"Analisando o número {num}");
            Console.WriteLine($"Usando o Ceiling() = {Math.Ceiling(num)}");
            Console.WriteLine($"Usando Floor() = {MathF.Floor(num)}");
            Console.WriteLine($"Usando Truncatel() = {Math.Truncate(num)}");
            Console.WriteLine($"Usando o Round() = {Math.Round(num)}");
            
            Console.ReadKey();

        }
    }
}
