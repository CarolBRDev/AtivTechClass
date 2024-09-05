﻿using System;

namespace Pedido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crie um programa que receba o pedido de um produto com nome, preço e quantidade. Considere que de acordo com a quantidade solicitada o comprador receberá um desconto sobre o valor total. O programa deve mostrar na tela o valor total do produto após ser registrado o pedido.

                * Até 10 unidades: valor total ​
                * de 11 a 20 unidades: 10% de desconto​
                * de 21 a 50 unidades: 20% de desconto ​
                * acima de 50 unidades: 25% de desconto
             */

            Pedido pedido = new Pedido();
            
            Console.WriteLine("Digite o nome do produto: ");
            pedido.Nome = Console.ReadLine();
            Console.WriteLine("Digite o valor unitario do produto: ");
            pedido.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de produtos: ");
            pedido.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Valor total do pedido: R${pedido.CalcularValorTotal()}.");



        }
    }
}
