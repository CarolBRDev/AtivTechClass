using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Pedido
{
    public class Pedido
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double CalcularValorTotal()
        {


            if (Quantidade <= 10)
            {
                return Quantidade * Preco;
            }
            else if (Quantidade <= 20)
            {
                double desconto = Quantidade * Preco * 10 / 100;
                return Quantidade * Preco - desconto;
            }
            else if (Quantidade <= 50)
            {
                double desconto = Quantidade * Preco * 20 / 100;
                return Quantidade * Preco - desconto;
            }
            else
            {
                double desconto = Quantidade * Preco * 25 / 100;
                return Quantidade * Preco - desconto;

            }



        }


    }
}
