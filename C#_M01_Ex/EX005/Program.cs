using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EX005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu? ");
            int nasc;
            int.TryParse(Console.ReadLine(), out nasc);
            int  atual = DateTime.Now.Year;
            int idade = atual - nasc;
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Estamos atualmente no ano de {atual}.");
            Console.WriteLine($"Se você nasceu em {nasc}, vai ter {idade} anos.");
            Console.ReadKey();
        }
    }
}
