using System;

namespace M02EX005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = true;
            bool q = false;
            Console.WriteLine($"não {p} = {!p}"); // Operador lógico NÃO
            Console.WriteLine($"{p} e {q} = {p && q}"); // Operador lógico E
            Console.WriteLine($"{p} ou {q} = {p || q}"); // Operador lógico OU
            Console.ReadKey();
        }
    }
}
