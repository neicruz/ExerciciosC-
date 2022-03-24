using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a tela de cadastro de clientes");
            Console.WriteLine("Por gentileza, comece informando um novo numero de conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora, informe o nome do detentor da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Perfeito!... Agora nos diga, deseja realizar um deposito inicial? S para SIM ou N para não");
            string escolha = Console.ReadLine();
            double valorDeposito;
            if (escolha =="S" || escolha =="s")
            {
                Console.WriteLine("Digite o valor que deseja depositar inicialmente");
                valorDeposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                ContaCorrente Novaconta1 = new ContaCorrente(conta, nome, valorDeposito);
                Console.WriteLine(Novaconta1);
                Console.WriteLine("Entre com um valor para deposito: ");
                Novaconta1.Depositar(valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(Novaconta1);
                Console.WriteLine("Digite o valor para saque: OBS:há desconto de 5 reais de taxa ");
                Novaconta1.Sacar(valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(Novaconta1);
                Console.WriteLine("Altere o Nome: ");
                Novaconta1.AlterarNome(Console.ReadLine());
                Console.WriteLine(Novaconta1);
                
            }
            else
            {
                ContaCorrente Novaconta1 = new ContaCorrente(conta, nome);
                Console.WriteLine(Novaconta1);
                Console.WriteLine("Entre com um valor para deposito: ");
                Novaconta1.Depositar(valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(Novaconta1);
                Console.WriteLine("Digite o valor para saque: OBS:há desconto de 5 reais de taxa ");
                Novaconta1.Sacar(valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(Novaconta1);
            }
            
            
            
          
            

        }
    }

    
}
