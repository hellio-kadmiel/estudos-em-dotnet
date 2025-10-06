


using System;

namespace MenuInterativo
{

    class Program
    {


        public static void Main()
        {


            string opcao;
            bool exibirMenu = true;
            while (true)
            {
                Console.WriteLine("Digite sua opcao");
                Console.WriteLine("1 Cadastrar cliente");
                Console.WriteLine("2 Buscar cliente");
                Console.WriteLine("3 Apagar cliente");
                Console.WriteLine(" 4 Encerrar");

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cliente cadastrado");
                        break;


                    case "2":
                        Console.WriteLine("busca por cliente");
                        break;


                    case "3":
                        Console.WriteLine("Apagar cliente");
                        break;
                    case "4":
                        Console.WriteLine("Encerrar");
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                    }

                        Console.WriteLine("Saiu da tela");

            }




        }

  


}













}




