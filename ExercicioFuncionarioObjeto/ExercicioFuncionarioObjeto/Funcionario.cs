using System;
using System.Globalization;

namespace ExercicioFuncionarioObjeto
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto+((SalarioBruto * porcentagem) / 100);
        }

        public override string ToString()
        {
            return Nome 
                + ", salario atualizado é de R$" 
                + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }

    }

    
}
