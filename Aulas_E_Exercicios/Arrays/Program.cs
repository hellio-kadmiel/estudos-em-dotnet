List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("Mg");



Console.WriteLine($"Intens na minha lista: {listaString.Count} - capacidade: {listaString.Capacity}");
listaString.Add("SC");

Console.WriteLine($"Intens na minha lista: {listaString.Count} - capacidade: {listaString.Capacity}");

listaString.Remove("MG");
Console.WriteLine($"Intens na minha lista: {listaString.Count} - capacidade: {listaString.Capacity}");

Console.WriteLine(listaString);





Console.WriteLine("percorrendo a lista com o For");
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posicao N {contador} - {listaString[contador]}");



}

Console.WriteLine("percorrendo a lista com o Foreach");
int contadorForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posicao N {contadorForeach} - {item}");
    contadorForeach++;
}




/* 

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 151;
arrayInteiros[2] = 712;


int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado,arrayInteiros.Length);



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
*/
