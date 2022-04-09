using System;

namespace Desafio_Fabio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Area de um quadrado */
            double l1;             
            Console.WriteLine("Calcule o lado de um Quandrado");
            l1 = Convert.ToDouble(Console.ReadLine());            
            var result = l1 * l1;
            Console.WriteLine("A area de " + l1 + " x " + l1 + " = " + result);
            Console.ReadLine();
        }
    }
}
