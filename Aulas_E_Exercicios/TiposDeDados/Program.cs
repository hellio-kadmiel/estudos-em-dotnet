using System;


namespace TiposDeDados
{
    class Program
    {
       static void Main(){

            String apresentação = "olá, seja bem vindo";
            int quantidade = 1;
            double altura = 1.80;
            decimal preco = 1.14m;
            bool condicao = true;
            // vai aparecer na tela
            Console.WriteLine(apresentação);
            Console.WriteLine("valor das variaveis: " + quantidade);
            Console.WriteLine("valor das variaveis: " + altura.ToString("0.00"));
            Console.WriteLine("valor das variaveis: " + preco);
            Console.WriteLine("valor das variaveis: " + condicao);


       } 
    }




}