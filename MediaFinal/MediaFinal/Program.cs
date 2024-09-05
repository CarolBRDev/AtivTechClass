using System;

namespace MediaFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler o nome de um aluno, e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos).
             */

            Aluno aluno = new Aluno();

            Console.WriteLine("Digite a primeira nota: ");
            aluno.Nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            aluno.Nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            aluno.Nota3 = int.Parse(Console.ReadLine());

            aluno.CalcularMedia();

            if (aluno.CalcularMedia() >= 60)
            {
                Console.WriteLine($"Aluno Aprovado! Média final:{aluno.CalcularMedia()}.");
            }
            else
            {
                int pontosFaltantes = 60 - aluno.CalcularMedia();
                Console.WriteLine($"Aluno Reprovado! Média final:{aluno.CalcularMedia()}. Faltaram {pontosFaltantes} pontos para a aprovação.");
            }


        }
    }
}
