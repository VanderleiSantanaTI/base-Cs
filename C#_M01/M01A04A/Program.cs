using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A04A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Valores numéricos Inteiros
            Console.WriteLine("O tipo byte vai de " + byte.MinValue + " até " + byte.MaxValue); // Usa 1 byte (8 bits)
            Console.WriteLine("O tipo sbyte vai de " + sbyte.MinValue + " até " + sbyte.MaxValue); // Usa 1 byte (8 bits)
            Console.WriteLine("O tipo short vai de " + short.MinValue + " até " + short.MaxValue); // Usa 2 byte (16 bits)
            Console.WriteLine("O tipo uhort vai de " + ushort.MinValue + " até " + ushort.MaxValue); // Usa 2 byte (16 bits)
            Console.WriteLine("O tipo int vai de " + int.MinValue + " até " + int.MaxValue); // Usa 4 byte (32 bits)
            Console.WriteLine("O tipo uint vai de " + uint.MinValue + " até " + uint.MaxValue); // Usa 4 byte (32 bits)
            Console.WriteLine("O tipo long vai de " + long.MinValue + " até " + long.MaxValue); // Usa 8 byte (64 bits)
            Console.WriteLine("O tipo ulong vai de " + ulong.MinValue + " até " + ulong.MaxValue); // Usa 8 byte (64 bits)
            // Valores numéricos Reais
            Console.WriteLine("O tipo float vai de " + float.MinValue + " até " + float.MaxValue); // Usa 4 byte (32 bits)
            Console.WriteLine("O tipo double vai de " + double.MinValue + " até " + double.MaxValue); // Usa 8 byte (64 bits)
            Console.WriteLine("O tipo decimal vai de " + decimal.MinValue + " até " + decimal.MaxValue); // Usa 16 byte (128 bits)
            // Valores Lógicos
            Console.WriteLine("O tipo bool aceita " + bool.FalseString + " ou " + bool.FalseString); // Usa 1 byte (True e False)
            Console.ReadKey();
        }
    }
}
