using System;

namespace Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler os dados de um   funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário (nome e salário líquido). Depois, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário. A Classe para esta atividade deve conter: Atributos: Nome, Salario Bruto, e ImpostoMétodos: CalcularSalarioLiquido() : doubleAumentarSalario() : void​
             */

            Funcionario f = new Funcionario();

            Console.WriteLine("Digite o nome do funcionário: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do imposto (%): ");
            f.Imposto = double.Parse(Console.ReadLine());

            f.CalcularSalarioLiquido();


            //aumentar salario bruto
            Console.WriteLine("Digite a porcentagem de aumento do salario bruto (%): ");
            double porcentagemAumento = double.Parse(Console.ReadLine());

            f.AumentarSalario(porcentagemAumento);
            

            //mostrar dados do funcionario atualizados
            Console.WriteLine($"Nome do funcionário: {f.Nome}, salário líquido após o aumento: {f.CalcularSalarioLiquido()}.");





        }
    }
}
