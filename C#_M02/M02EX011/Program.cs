using System;

namespace M02EX011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op1 = 17; // podendo representar em binário tbm 0b_0010_0011=17;
            int op2 = 0b_0011; // podendo representar em binario tbm 0b_0100=3;

            Console.WriteLine($"O valor de {op1} & {op2} = {op1 & op2}");
            Console.WriteLine($"O valor de {op1} | {op2} = {op1 | op2}");
            Console.WriteLine($"O valor de {op1} ^ {op2} = {op1 ^ op2}");
            Console.WriteLine($"O valor de ~{op1} = {~op1}");
            Console.WriteLine($"O valor de {op1} >> {op2} = {op1 >> op2}");
            Console.WriteLine($"O valor de {op1} << {op2} = {op1<<op2}");
        }
    }
}
