using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }


        public int NumeroConta { get; set; }
        public decimal Saldo { get; private set; }
        public void sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso. Saldo atual: {Saldo}");
            }
        }
        public void exibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo}");
        }


    }
}