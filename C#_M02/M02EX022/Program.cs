using System;

namespace M02EX022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ângulo = 0;
            //A entrada deve ser em radianos Ex.:PI/2
            Console.Write("Informe um ângulo em Graus: "); 
            float.TryParse(Console.ReadLine(), out ângulo);

            float rad = ângulo * (float)Math.PI / 180;
            Console.WriteLine($"{ângulo}° corresponde a {rad}rad");
            Console.WriteLine($"O seno de {ângulo}° é igual a {Math.Sin(rad):F3}");
            Console.WriteLine($"O cosseno de {ângulo}° é igual a {Math.Cos(rad):F3}");
            Console.WriteLine($"A tangente de {ângulo}° é igual a {Math.Tan(rad):F3}");
        }
    }
}
