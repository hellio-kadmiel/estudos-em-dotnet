using System;
using ClasseAbstrata.Models;

class Program
    {
        static void Main(string[] args)
    {

        Corrente c = new Corrente();
        c.Creditar(100);
        c.ExibirSaldo();

        Console.WriteLine("Hello, World!");
     }
    }
