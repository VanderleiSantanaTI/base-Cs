using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome: ");
            string nome = Console.ReadLine();
            nome = nome.Trim();//remove os espaços em branco (espaços no início e no final) de uma string
            nome = nome.ToLower();// Torna a string em MINÚSCULAS 
            nome = nome.ToUpper();// Torna a string em MAIÚSCULAS 
            Console.WriteLine("Muinto prazer em te conheccer, " + nome);
            Console.ReadKey();

        }
    }
}
