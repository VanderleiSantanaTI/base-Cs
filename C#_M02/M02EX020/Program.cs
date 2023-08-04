using System;

namespace M02EX020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota = 0;
            Console.Write($"A nota válida de um aluno : ");
            float.TryParse( Console.ReadLine(), out nota );
            float valid = Math.Clamp(nota, 0, 10); // (valor, min, max)
            Console.WriteLine($"A nota digitada foi {nota} e a validada é {valid}.");

            

        }
    }
}
