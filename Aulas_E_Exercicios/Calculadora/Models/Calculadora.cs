using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"Somar: {x} + {y} = {x + y}");

        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"Subtracao: {x} - {y} = {x - y}");

        }


        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"Multiplicao:{x} * {y} = {x * y}");

        }

        // um tratamento para a divisao por 0
        public void Dividir(int x, int y){
            if (int y == 0)
            {
                 Console.WriteLine("Erro: Divisão por zero");
            return;
            }

        }


          public void Dividir(int x, int y)
        {
            Console.WriteLine($"Divisao: {x} / {y} = {x / y}");

        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y); // Potencia em uma variavel e coloquei no console
            Console.WriteLine($"POTENCIA:  {x}^{y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"seno:  {angulo}° = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno:  {angulo}° = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"tangente:  {angulo}° = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} é igual a {raiz}");

            
        }

        

    }
}