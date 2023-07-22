using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A13A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gustavo";
            float salario = 550.75556f;
            int idade = 22;
                                         // nome com 20 espaço de caracter alinhado a direita
            Console.WriteLine($"Muito prazer em te conhcer, {nome, 20}!!!");
                                         // nome com -20 espaço de caracter alinhado a esquerda
            Console.WriteLine($"Muito prazer em te conhcer, {nome, -20}!!!");
            //O D3 acrescenta 3 espaço e completa com zero. Usa-se {salario, 20:c3} o c3 coloca 3 casas decimais
            Console.WriteLine($"{nome, -10} tem {idade, -5:D3} e ganha {salario, 20:c3} de salario por mês.");

            Console.ReadKey();
            /*
             
             :C Monetário (currency)
             :D Decimal (inteiro)
             :N Número (real)
             :E Científico 
             :X Hexadecimal

             */

        } 
    }
}
