using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;


            Console.Write("Insira o 1º Valor: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o 2º Valor: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Insira o 3º Valor: ");
            n3 = double.Parse(Console.ReadLine());
            {
                if ((n1 + n2) > n3 || (n1 + n3) > n2 || (n3 + n2) > n1)
                    Console.WriteLine("É um triangulo");
                else
                    Console.WriteLine("Não é um triangulo");
            }
            if (n1 == n2 && n2 == n3 && n1 !=0)
                Console.WriteLine("É equilatero");
                if (n1 == n2 && n2 != n3)
                Console.WriteLine("É isosceles ");
                if(n2== n3 && n3 != n1)
                Console.WriteLine("É isosceles ");
                if(n1 == n3 && n1 !=n2)
                Console.WriteLine("É isosceles ");
                if(n1 !=n2 && n2 != n3 && n3 !=n1)
                Console.WriteLine("É escaleno ");




        }
    }
}
