using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;


            Console.Write("Insira o primeiro Valor: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o segundo Valor: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Insira o terceiro Valor: ");
            n3 = double.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                if (n1 == n3)
                {
                    Console.WriteLine("Os valores inseridos são idênticos");
                }
                else
                {
                    if (n1 > n3)
                    {
                        Console.WriteLine("O 1° e o 2° valor são os maiores");
                    }
                    else
                    {
                        Console.WriteLine("O maior é o 3° valor");
                    }
                }
            }
            else
            {
                if (n1 == n3)
                {
                    if (n1 > n2)
                    {
                        Console.WriteLine("O 1° e o 3° valor são os maiores");
                    }
                    else
                    {
                        Console.WriteLine("O maior é o 2° valor");
                    }
                }
                else
                {
                    if (n2 == n3)
                    {
                        if (n2 > n1)
                        {
                            Console.WriteLine("O 2° e o 3° valor são os maiores");
                        }
                        else
                        {
                            Console.WriteLine("O maior valor informado é o 1° Valor");
                        }
                    }
                    else
                    {
                        if (n1 > n2)
                        {
                            if (n1 > n3)
                            {
                                Console.WriteLine("O Maior é o 1° Valor");
                            }
                            if (n2 > n3)
                            {
                                Console.WriteLine("O Maior é o 2° Valor");
                            }
                            else
                            if (n3 > n1)
                            {
                                Console.WriteLine("O Maior é o 3° Valor");
                            }
                        }
                    }
                }
            }
        }
    }
}
        
