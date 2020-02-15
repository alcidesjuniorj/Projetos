using System;
using System.Globalization;

namespace Exercicio_Aula_60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da Conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());

            double valorDeposito = 0;
            if (depositoInicial == 's' || depositoInicial == 'S' || depositoInicial == 'n' || depositoInicial == 'N')
            {

                if (depositoInicial == 's' || depositoInicial == 'S')
                {
                    Console.Write("Entre o valor de depósito inicial: ");
                    valorDeposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                }
            }
            else
            {
                Console.WriteLine("O valor informado deve ser: 's','S','n','N'");
            }

            //Abertura da Contra bancaria
            ContaBancaria cb = new ContaBancaria(numeroConta, nomeTitular, valorDeposito);
            
            Console.WriteLine("\n\nDados da conta:");
            Console.WriteLine(cb.ToString());

            //Depósito na Contra bancaria
            Console.Write("\n\nEntre um valor para depósito: ");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Deposito(valorDeposito);

            Console.WriteLine("\n\nDados da conta atualizados:");
            Console.WriteLine(cb.ToString());

            //Saque na Contra bancaria
            Console.Write("\n\nEntre um valor para saque: ");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Saque(valorDeposito);

            Console.WriteLine("\n\nDados da conta atualizados:");
            Console.WriteLine(cb.ToString());

            Console.Read();

        }
    }
}
