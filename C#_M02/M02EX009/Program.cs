using System;

namespace M02EX009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine($"O número {n} corresponde {Convert.ToString(n, toBase: 2)} em binário");
            Console.WriteLine($"O número {n} corresponde {Convert.ToString(n, toBase: 8)} em octal");
            Console.WriteLine($"O número {n} corresponde {Convert.ToString(n, toBase: 16)} em hexadecimal");
        }
    }
}
