using System;

namespace M02EX014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 6;
            int n2= 9;
            //n1 ++; // mesma coisa que n1 = n1 + 1
            //n2 --; // mesma coisa que n2 = n2 - 1
            //int n3 = n1++; // pós-incrementro(n3 recebe o valor de N1 SEM o incremento)
            //int n3= ++n1; // pré-incremento(n3 recebe o valor de N1 já COM incremento)
            int n3 = n1++ + --n2; 

            Console.WriteLine($"n1 vale {n1} e n2 vale {n2} e n3 vale {n3}");
 
        }
    }
}
