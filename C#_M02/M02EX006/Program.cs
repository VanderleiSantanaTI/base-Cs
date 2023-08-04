using System;

namespace M02EX006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ENTRADA DE DADOS
            float n1 = 0f;
            float n2 = 0f;
            Console.Write("Primeira nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n1);
            Console.Write("Segunda nota do aluno: ");
            float.TryParse((string)Console.ReadLine(), out n2);
            // CÁLCULO DA MÉDIA E SITUAÇÕES   
            float média = (n1 + n2) / 2;
            bool sit01 = média >= 0 && média < 4.0;
            bool sit02 = média >= 4.0 && média < 7.0;
            bool sit03 = média >= 7.0 && média <=10.0;
            // MOSTRANDO RESULTADO
            Console.WriteLine($"A média do aluno foi {média:F1}");
            Console.WriteLine($"Aluno está reprovado? {sit01}");
            Console.WriteLine($"Aluno está recuperação? {sit02}");
            Console.WriteLine($"Aluno está aprovado? {sit03}");
        }
    }
}
