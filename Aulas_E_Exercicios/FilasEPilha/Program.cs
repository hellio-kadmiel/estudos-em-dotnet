
using System.Globalization;
using System.Reflection;



Dictionary<string, string> estados = new Dictionary<string, string>();
//chave para primeiro user
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");


foreach (KeyValuePair<string,string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor {item.Value}"); 
}

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

string chave = "BA";
Console.WriteLine("");
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existe: {chave}");
}
else
{
    Console.WriteLine($"e segura acd a chave");
}

Console.WriteLine("--------------");


foreach (KeyValuePair<string,string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor {item.Value}"); 
}

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}
Console.WriteLine($"removendo objeto do topo{pilha.Pop()}");

pilha.Push(20);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}


Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo elementos: {fila.Dequeue()}");
fila.Enqueue(10);
foreach (int item in fila)
{
    Console.WriteLine(item);
}