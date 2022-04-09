using System;

namespace Media_de_3_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            /* exercicio media de 3 valores */

            double valor1, valor2, valor3, media;

            Console.WriteLine("Calculando Média de 3 Notas");
            Console.WriteLine("Digite Valor da primeira Nota");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite Valor da Segundo Nota");
            valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite Valor da terceira Nota");
            valor3 = Convert.ToDouble(Console.ReadLine());
            media = (valor1 + valor2 + valor3) / 3;
            Console.WriteLine("Sua Média é: " + media);
            Console.ReadLine();
        }
    }
}
