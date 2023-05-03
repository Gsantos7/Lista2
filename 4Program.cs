using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2__EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;

            Console.Write("Insira o valor da base do retangulo:");
            b=int.Parse(Console.ReadLine());
            Console.Write("Insira o valor da altura do retangulo:");
            h=int.Parse(Console.ReadLine());
            a = b * h;
            Console.WriteLine("O valor da área é: {0}", a);
            if (a > 100)
                Console.WriteLine("Terreno Grande");


        }
    }
}
