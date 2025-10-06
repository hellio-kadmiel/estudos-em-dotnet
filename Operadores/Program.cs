
using System;


namespace Operadores
{

    class Program
    {

        public static void Main()
        {
            // operador AND (&&)
            Console.WriteLine("Operador AND:");
            bool presenca = true;
            double media = 6.5;



            if (presenca && media >= 7)
            {
                Console.WriteLine("Aprovado");

            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            //Operador OR (||)
            Console.WriteLine("Operador OR:");
            bool maiorDeIdade = false;
            bool autorizacao = true;


            // se pelo menos uma for verdadeira ele entra
            if (maiorDeIdade || autorizacao)
            {
                Console.WriteLine("Entrada Liberada");

            }
            else
            {
                Console.WriteLine("Entrada não liberada");
            }

            // operador NOT '!'
            Console.WriteLine("Operador NOT:");
            bool bloqueado = false;
            if (!bloqueado)
            {
                Console.WriteLine("Acesso permitido");

            }
            else
            {
                 Console.WriteLine("Acesso negado");
            }



        }


}




}

