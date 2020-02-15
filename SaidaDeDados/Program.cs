using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Seu Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua Idade:");
            byte idade = byte.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome de Três frutas que deseja comprar:");

            //string frutas = Console.ReadLine();
            //string[] vetFrutas = frutas.Split(' ');
            string[] vetFrutas = Console.ReadLine().Split(' ');

            double saldo = 3.123456;

            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));
            
            //placeholders
            Console.WriteLine("{0} tem {1} anos de idade e saldo de {2:F2} reais - {3} - {4} - {5}",nome,idade,saldo, vetFrutas[0],vetFrutas[1],vetFrutas[2]);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos de idade e saldo de {saldo:F2} reais");

            //Concatenação
            Console.WriteLine(nome + " tem "+idade+" anos de idade e saldo de "+saldo.ToString("F2",CultureInfo.InvariantCulture) +" reais");
        }
    }
}
