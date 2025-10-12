using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays.Models
{
    public static void Main(string[] args)
    {


        int[] arrayInteiros = new int[3];
        arrayInteiros[0] = 72;
        arrayInteiros[1] = 151;
        arrayInteiros[2] = 712;


        int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
        Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);



        // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


        Console.WriteLine("percorrendo o Array com o for");
        for (int contador = 0; contador < arrayInteiros.Length; contador++)
        {
            Console.WriteLine($"Posicao numero {contador}  - {arrayInteiros[contador]}");
        }


        //percorrendo o Array com o Foreach
        Console.WriteLine("percorrendo o Array com o Foreach");


        int contadorForeach = 0;
        foreach (int valor in arrayInteiros)
        {
            Console.WriteLine($"Posicao N° {contadorForeach} -{valor}");
            contadorForeach++;
        }
    }



}









