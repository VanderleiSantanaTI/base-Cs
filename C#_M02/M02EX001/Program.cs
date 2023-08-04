using System;

namespace M02EX001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplos de operadores aritméticos
            int op1 = 0;
            int op2 = 0;
            
            Console.Write("Digite o primeiro operando: ");
            int.TryParse(Console.ReadLine(), out op1);
            Console.Write("Digite o seundo operando: ");
            int.TryParse(Console.ReadLine(), out op2);
            Console.WriteLine($"Calculando +{op1} = {+op1}"); // Operadores de identidade
            Console.WriteLine($"Calculando -{op2} = {- op2}"); // Operadores de negação aritmética
            Console.WriteLine($"Calcumando {op1} + {op2} = {op1 + op2}"); // Operadores de suma 
            Console.WriteLine($"Calcumando {op1} - {op2} = {op1 - op2}"); // Operadores de subtração
            Console.WriteLine($"Calcumando {op1} x {op2} = {op1*op2}"); // Operadores de divisão(inteir)
            Console.WriteLine($"Calcumando {op1} ÷ {op2} = {(float) op1 / op2} **(DIVISÃO REAL)**"); // Operadores de divisão
            Console.WriteLine($"Calcumando {op1} Resto {op2} = {op1 % op2}"); // Operadores do resto da divisão interia
            Console.ReadKey();
        }
    }
}
