using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            Console.Write("Insira o primeiro valor:");
            n1=int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo valor:");
            n2=int.Parse(Console.ReadLine());

            if (n1 > n2)
                Console.Write("O primeiro valor é maior");
            else
                Console.WriteLine("o segundo valor é maior");

        }
    }
}
