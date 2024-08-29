using System;
using System.Collections.Generic;
using System.Text;

namespace ProblRetangulo
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public Retangulo (double altura, double largura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double CalcularArea()
        {
            double area = Largura * Altura;
            return area;
        }

        public double CalcularPerimetro()
        {
           
            double perimetro = 2 * (Largura + Altura);
            return perimetro;
        }

        public double CalcularDiagonal()
        {
            
            double diagonal = Math.Sqrt((Largura * Largura) + (Altura * Altura));

            return diagonal;
        }
    }
}
