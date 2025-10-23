using System.Reflection;
using System.Security.Cryptography;
using ExemploPOO.Models;


public class Program
{
    public static void Main(string[] args)
  {

    Aluno a1 = new Aluno();
    a1.Nome = "Carlos";
    a1.Idade = 21; 
     a1.Nota = 85;
    a1.Apresentar();
   
      
    Console.WriteLine($"Nota do aluno {a1.Nome}: {a1.Nota}");


    Professor p1 = new Professor();
    p1.Nome = "Ana";
    p1.Idade = 40;
    p1.Salario = 3500.50;
    p1.Apresentar();


    ContaCorrente conta = new ContaCorrente(12345, 1000);
        conta.sacar(500);
        

        conta.exibirSaldo();


      /*  Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "João";
        pessoa1.Idade = 30;
        pessoa1.Apresentar();

        Pessoa pessoa2 = new Pessoa();
        pessoa2.Nome = "Maria";
        pessoa2.Idade = 25;
        pessoa2.Apresentar(); */
    }
}