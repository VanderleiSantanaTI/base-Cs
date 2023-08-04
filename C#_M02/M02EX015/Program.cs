using System;

namespace M02EX015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = null; // ERRO numeros int,byte, float.... não aceita null
            //Nullable<int> num = null; // aceita com o uso do Nullable
            int? num = null; // outra forma de aceitar o null é o uso do "?" no 'int'
            int x = num ?? 10; 
            Console.WriteLine($"A variável NUM tem valor nulo {num is null}");
            Console.WriteLine($"A variável NUM tem valor dentro dela? {num.HasValue}");

            Console.WriteLine($"A variável X recebeu o valor {x}");
           
        }
    }
}