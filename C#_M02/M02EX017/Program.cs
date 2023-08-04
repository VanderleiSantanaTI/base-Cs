using System;

namespace M02EX017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bas ;
            int pot ;
            Console.WriteLine("*** CALCULADORA DE POTÊNCIAS ***");
            Console.Write("Base = ");
            int.TryParse(Console.ReadLine() , out bas);
            Console.Write("Potência = ");
            int.TryParse(Console.ReadLine(), out pot);

            double quad = Math.Pow(bas, pot);

            
            Console.WriteLine($"O resultado de {bas} elevado a {pot} é igual a {quad}");
            Console.ReadKey();
        }   
    }
}
