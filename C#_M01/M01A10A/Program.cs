﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01A10A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.WriteLine("a data atual é " + dia + "/" + mes + "/" + ano);

            int hora = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            Console.WriteLine("a hora atual é " + hora + ":" + min + ":" + sec);
            
            Console.ReadKey();
        }
    }
}
