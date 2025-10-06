using System;

namespace Contador
{


    class Program
    {


        public static void Main()
        {
            
                    double numero = 12.953;
                    int contador = 10;

                    for (double contador = 0; contador <= 10; contador++)
                    {
                        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                    }
                        


            //While verifica se a condicao eh verdadeira

            double numero2 = 12;
            int contador2 = 1;



            while (contador2 <= 15)
            {
                Console.WriteLine($"{contador2} Execucao: {numero2} x {contador2} = {numero2 * contador2}");
                contador2++;
                if (contador2 == 5)
                {
                    break;
                }



            }


            // do While
            int soma = 0, numero = 0;


            do
            {
                Console.WriteLine("Digite um numero: (0 para parar)");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;

                //enquanto o numero for diferente de 0
            } while (numero != 0);

            Console.WriteLine($"O total de soma dos números é: {soma}");
        }




    }





















}

