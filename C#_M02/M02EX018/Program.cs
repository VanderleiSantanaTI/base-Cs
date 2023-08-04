using System;


namespace M02EX018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** CALCULADORA DE RAÍZES ***");
            int num;
            Console.Write("Número: ");
            int.TryParse(Console.ReadLine(), out num);
            double rq = Math.Sqrt(num); // gasta 8 byte por variável para maior precisão
            float rc = MathF.Cbrt(num); // gasta 4 byte por variável
            Console.WriteLine($"A raiz quatrada de {num} é {rq}");
            Console.WriteLine($"A raiz cúbico de {num} é {rc:F2}");
            Console.ReadKey();
        }
    }
}
