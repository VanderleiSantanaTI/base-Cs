using System;

namespace M02DESAFIO01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte idade;
            Console.Write("Digite a tua idade: ");
            byte.TryParse(Console.ReadLine(), out idade);
            bool sit01 = idade > 0 && idade < 16;
            bool sit02 = idade >= 16 && idade < 18;
            bool sit03 = idade >= 18 && idade < 65;
            bool sit04 = idade >= 65;

            Console.WriteLine($"Na idade de {idade} anos o voto é proibido? {sit01} ");
            Console.WriteLine($"Na idade de {idade} anos o voto é opcional? {sit02 || sit04} ");
            Console.WriteLine($"Na idade de {idade} anos o voto é obrigatório? {sit03} ");
            
            Console.ReadKey();
        }
    }
}
