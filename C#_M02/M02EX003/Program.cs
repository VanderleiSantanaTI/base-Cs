using System;

namespace M02EX003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0f;
            float nota2 = 0f;
            Console.Write("Primeira nota: ");
            float.TryParse(Console.ReadLine(), out nota1);
            Console.Write("Segunda nota: ");
            float.TryParse(Console.ReadLine(), out nota2);
            float media = (nota1 + nota2) / 2;
            Console.WriteLine($"As notas registradas foram {nota1:F2} e {nota2:F2}");
            Console.WriteLine($"A média do aluno foi {media:F1}");
            Console.ReadKey();
        }
    }
}
