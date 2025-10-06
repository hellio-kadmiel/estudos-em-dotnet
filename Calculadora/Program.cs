using System;
using ExemploFundamentos.Models;

namespace ExemploFundamentos
{
    public class Program
    {
        public static void Main()
        {
            // Isso aqui cria um espaço na memoria e é chamado de instancia
            Calculadora calcular = new Calculadora();

            // Operacoes basicas
            calcular.Somar(10, 20);
            calcular.Multiplicar(50, 60);
            calcular.Subtrair(80, 30);
            calcular.Dividir(920, 201);
            calcular.Potencia(3, 3);


            // calculo de triangulo
            calcular.Coseno(60);
            calcular.Seno(30);
            calcular.Tangente(200);
            calcular.RaizQuadrada(9);
            

            // incremento 
            int numero = 10;
            Console.WriteLine(numero);

            Console.WriteLine("Incremetando o 10");
            numero = numero + 1;
            Console.WriteLine(numero);















            /*

    



        

            

            Pessoa p1 = new Pessoa();
            p1.nome = "Buta";
            p1.idade = 30;
            p1.Apresentar();
            p1.MostarIdade(); */
        }

    }
}