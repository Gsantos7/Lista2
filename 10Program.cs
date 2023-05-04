using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2EX9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double m;

            Console.Write("Insira o 1º valor:");
            p1=double.Parse(Console.ReadLine());
            Console.Write("Insira o 2º valor");
            p2 =double.Parse(Console.ReadLine());

            m = (p1 + (2 * p2)) / 3;

            Console.WriteLine("A sua média foi: {0}", m);
            if (m >= 5)
                Console.WriteLine("Aprovado");
            else
                Console.WriteLine("Reprovado");
        }
    }
}
