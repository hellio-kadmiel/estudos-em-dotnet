using System.Globalization;



int numero = 15;
bool ehPar = false;
// % resto da divisão 
ehPar = numero % 2 == 0;

// o if ternario é o ? "verdadeiro" "falso"
Console.WriteLine($"o numero {numero} é " + (ehPar ? "par" : "impar"));