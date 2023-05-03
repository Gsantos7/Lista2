using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1___EX6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p;
            double h;
            double r;

            Console.Write("Insira o peso:");
            p = double.Parse(Console.ReadLine());
            Console.Write("Insira a altura:");
            h = double.Parse(Console.ReadLine());
            r = p / (h * h);

            if (r < 20)
                Console.WriteLine("Abaixo do peso");
            else
            if (r >= 20 & r<25)
                Console.WriteLine("Peso ideal");
            else
            if (r >= 25)
                Console.WriteLine("Acima do Peso");
           
        }
    }
}
