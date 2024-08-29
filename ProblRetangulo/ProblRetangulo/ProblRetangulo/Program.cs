using System;

namespace ProblRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. A Classe para esta atividade deve conter: Atributos: Largura e Altura;Métodos: CalcularArea() : doubleCalcularPerimetro() : doubleCalcularDiagonal() : double

            Console.WriteLine("Digite o valor da largura: ");
            double largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());
            
            Retangulo r = new Retangulo(altura, largura);
            
            Console.WriteLine($"O valor da área do retângulo é: {r.CalcularArea()}.");
            Console.WriteLine($"O perímetro do retângulo é: {r.CalcularPerimetro()}.");
            Console.WriteLine($"O valor da diagonal do retângulo é: {r.CalcularDiagonal()}");

        }
    }
}
