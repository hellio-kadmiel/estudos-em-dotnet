using System;

namespace Datas
{
    class Program
    {
        public static void  Main()
        {
            
            DateTime dataAtual = DateTime.Now.AddDays(1);
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

            // esse no AddDays ele adiciona dentro dos paramentros os dias para serem adicionados 
            DateTime amanha = DateTime.Now.AddDays(2);
            //
            DateTime ontem = DateTime.Now.AddDays(-3);
            

            Console.WriteLine($"Amanha: {amanha: dd/MM/yyyy}");
            Console.WriteLine($"Ontem:   {ontem: dd/MM/yyyy}");



        }


    }


}