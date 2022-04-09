using System;

namespace Estoque_Medio
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdMax, codigo;
            int qtdMin;
            int estmedio;
            string descricao;

            Console.WriteLine("Calculando Quantidade Média de Produtos em Estoque");
            Console.WriteLine("Digite o Código do Produto ");
            codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a Descrição do Produto ");
            descricao = Console.ReadLine();
            Console.WriteLine("Digite a qtd max");
            qtdMax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a qtd min");
            qtdMin = Convert.ToInt32(Console.ReadLine());
            estmedio = (qtdMax + qtdMin) / 2;

            Console.WriteLine("Código Produto: " + codigo);
            Console.WriteLine("Descrição Produto: " + descricao);
            Console.WriteLine("O estoque medio é: " + estmedio);
            Console.ReadLine();


        }
    }
}
