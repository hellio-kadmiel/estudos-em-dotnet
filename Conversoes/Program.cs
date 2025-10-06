using System;

namespace Conversores
{

    class Program
    {

        static void Main()
        {


            String k = "15";
            int b = 0;
            int.TryParse(k, out b);
            Console.WriteLine(b);
            Console.WriteLine("Conversao realizada com sucesso!");

            // Casting 
            int d = 5;
            double e = d;
            Console.WriteLine($"Casting implícito: {e}");

            // Casting 
            int a = Convert.ToInt32("10");
            Console.WriteLine($"Convert.ToInt32: {a}");

            // Usando ToString
            string c = 5.ToString();
            Console.WriteLine($"ToString: {c}");

        }

    }


}


