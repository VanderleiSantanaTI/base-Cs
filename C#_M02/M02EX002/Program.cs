using System;


namespace M02EX002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplos de operadores aritméticos
            int n1 = 0;
            int n2 = 0;

            Console.Write("Digite o Numerador: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Digite Denominador: ");
            int.TryParse(Console.ReadLine(), out n2);

            float res =(float) n1 / n2; // considerando o n1 como float usando o casting
            Console.WriteLine($"Dividindo {n1} ÷ {n2} = {res:F2}"); // divisão real com duas casas
            Console.WriteLine($"A Divisão inteira {n1} ÷ {n2} = {n1 / n2}"); // divisão inteira


            Console.ReadKey();
        }
    }
}
