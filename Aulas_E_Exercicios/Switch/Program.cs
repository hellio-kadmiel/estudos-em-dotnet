using System;

namespace Switch
{
    class Program
    {
        
    


public static void Main()
{


Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("VOGAL");
        break;
    default:
        Console.WriteLine("nao eh uma vogal");
        break;
}
}
}
}