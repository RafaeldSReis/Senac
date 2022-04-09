using System;

namespace loja199
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            // inteiro
            int codigo, quantidade;
            // valor real "float"
            double valorcompra;
            double preco = 1.99;

            Console.WriteLine("Informe o nome do Cliente");
            nome = Console.ReadLine();
            Console.WriteLine("Digite Código do Produto");
            /* Convertendo uma string "texto" para um int "Numero" */
            codigo = Convert.ToInt32(Console.ReadLine());           
            
            Console.WriteLine("Digite Quantidade do Produto");
            quantidade = Convert.ToInt32(Console.ReadLine());

            valorcompra = quantidade * preco;

            Console.WriteLine("Nome cliente: " + nome);
            Console.WriteLine("Quantidade: " + quantidade);
            Console.WriteLine("valor Total: " + valorcompra);
            Console.ReadLine();
           
        }
    }
}
