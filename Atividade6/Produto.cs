using System;
using System.Collections.Generic;

namespace Atividade6
{
    public class Produto
    {
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, float preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public float ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Console.WriteLine("Cadastro de Produtos\n");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nProduto {i + 1}:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                float preco = float.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produto produto = new Produto(nome, preco, quantidade);
                produtos.Add(produto);
            }

            Console.WriteLine("\nProdutos Cadastrados:");
            float valorTotalEstoque = 0;

            foreach (Produto produto in produtos)
            {
                float totalProduto = produto.ValorTotalEmEstoque();
                valorTotalEstoque += totalProduto;

                Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco:C2}, Quantidade: {produto.Quantidade}, Total: {totalProduto:C2}");
            }

            Console.WriteLine($"\nValor total em estoque: {valorTotalEstoque:C2}");
        }
    }
}
