using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("\nDigite um número Real:  ");
            float num;
            float.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Você digitou o valor {num:n3}");

            int parteInteira = (int)num; // passa para um número inteiro
            int arredondado = Convert.ToInt16(num); // cria uma inteiro arrendondado
            Console.WriteLine($"A parte inteira do número é {parteInteira:D}");
            Console.WriteLine($"Arrendondando, temos o número  {arredondado:D}");
            Console.ReadKey();
        }
    }
}
