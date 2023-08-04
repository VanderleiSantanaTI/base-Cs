using System;

namespace M02EX013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lotação = 10;
            int total = 4;
            int grupo = 0;  
            Console.Write($"Quantas pessoas chegraram? ");
            int.TryParse( Console.ReadLine(), out grupo );
            total += grupo;
            Console.WriteLine($"Chegando um grupo de {grupo} pessoas, agora temos {total} na festa");
            Console.WriteLine($"Lotou a balada? {total >= lotação}");
           
        }
    }
}
