using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Maior número---");
            
            Console.Write("\nInforme o primeiro número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 < n2)
            {
                Console.WriteLine($"\nO maior número é o {n2}.\n");
            }
            else 
            {
                Console.WriteLine($"\nO maior número é o {n1}.\n");
            }

        }
    }
}
