﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_Aula_60
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) :this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            double taxa = 5.00;
            Saldo -= (taxa + quantia);
        }

        public override string ToString()
        {
            return ($"Conta {Numero}, Titular:{Titular}, Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
