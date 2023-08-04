using System;

namespace M02EX007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esntrada
            float altura = 0f;
            Console.Write("Qual é a sua altura em metro: ");
            // verificação de status
            float.TryParse(Console.ReadLine(), out altura);
            // mostar resultado
            string status = (altura <= 1.70) ? "baixa":"alta";
            Console.WriteLine($"Alguém com {altura:F2}m  de altura é considerado uma pessoa {status}");
            Console.ReadKey();

        }
    }
}
