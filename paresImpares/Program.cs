using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SUMA_DE_N_NÚMEROS_PARES_E_IMPARES
{
    class Program
    {
        static void Main(string[] args)
        {
            byte NUM, I;
            int SUMP = 0;
            int SUMI = 0;
            string linea;
            Console.Write("NÚMERO MÁXIMO: "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            for (I = 1; I <= NUM; I += 2)
            {
                SUMP = SUMP + I;
            }
            for (I = 2; I <= NUM; I += 2)
            {
                SUMI = SUMI + I;
            }
            Console.WriteLine("TOTAL EN PARES : " + SUMP);
            Console.WriteLine("TOTAL EN IMPARES : " + SUMI);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}