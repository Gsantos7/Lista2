using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2EX8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.Write("Insira o primeiro valor: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Insira o terceiro valor: ");
            c = double.Parse(Console.ReadLine());

            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            c = Math.Pow(c, 2);

            if ((a + b) == c)
                Console.WriteLine("Formam um triângulo retângulo");
            else
                if ((b + c) == a)
                    Console.WriteLine("Formam um triângulo retângulo");
                else
                    if ((a + c) == b)
                        Console.WriteLine("Formam um triângulo retângulo");
                    else
                        Console.WriteLine("Não Formam um triângulo retângulo");
                    
                
            
        }
    }
}
        
