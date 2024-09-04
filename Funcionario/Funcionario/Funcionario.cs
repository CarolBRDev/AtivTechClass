using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        

        public double CalcularSalarioLiquido()
        {
                     
            double valorImposto = SalarioBruto * Imposto /100;
            
            return SalarioBruto - valorImposto;
        }

        public void AumentarSalario(double porcentagemAumento)
        {
            
            SalarioBruto += (SalarioBruto * porcentagemAumento / 100);
        }


    }
}
