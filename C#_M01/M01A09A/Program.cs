using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A09A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int n = gerador.Next(5, 10); // (5, 10) irá gerar os números entre (5, 6, 7, 8, 9)
            /*int n = gerador.Next(5); // (5, 10) irá gerar os números entre 0 a 5 (0, 1, 2, 3, 4)*/
            Console.WriteLine("Acabei de gerar o número " +  n);
            Console.ReadKey();
        }
    }
}
