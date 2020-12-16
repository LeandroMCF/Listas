using System;
using System.Collections.Generic;
using Listas.Classes;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            Console.Write($"quantos produtos voce deseja adicionar?: ");
            int quant = int.Parse(Console.ReadLine());
            for (var i = 0; i < quant; i++)
            {
                Console.Write($"Digite o codigo do produto: ");
                int cod = int.Parse(Console.ReadLine());
                Console.Write($"Digite o nome do produto: ");
                string name = (Console.ReadLine());
                Console.Write($"Digite o preço do produto: ");
                float preco = float.Parse(Console.ReadLine());
                produtos.Add(new Produto(cod, name, preco));
                Console.WriteLine($"--------------------");
            }

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Codigo - {item.Codigo}\nProduto - {item.Nome}\nPreço - {item.Preco}\n-------------------");
                
            }

            //numeros.Add(200);//0
            //numeros.Add(55);//1
            //numeros.Add(3);//2
            //numeros.Add(2);//3

            //numeros.Sort();

            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(numeros.Count);
            

            //bool resposta = numeros.Contains(5);
            //if (resposta)
            //{
            //    Console.WriteLine($"Número encontrado");
            //}
            //else
            //{
            //    Console.WriteLine($"Número não encontrado");
            //    
            //}
        }
    }
}