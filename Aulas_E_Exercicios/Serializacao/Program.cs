using System;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Tudo em um arquivo para evitar conflitos
public class Venda
{
    public Venda() { }
    public Venda(int id, string produto, decimal preco, DateTime dataVenda)
    {   
        
        Id = id;
        Produto = produto;
        Preco = preco;
        DataVenda = dataVenda;
    }
    
    public int Id { get; set; }
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }
}

class Program
{
    static void Main()
    {
        DateTime dataAtual = DateTime.Now;
        List<Venda> ListaVendas = new List<Venda>();
        Venda v1 = new Venda(1, "material de escritorio", 10.0M, dataAtual);
        Venda v2 = new Venda(2, "Esgoto", 40.0M, dataAtual);
        ListaVendas.Add(v1);
        ListaVendas.Add(v2);
        string json = JsonSerializer.Serialize(ListaVendas, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText("Arquivos/vendas.json", json);
        
        Console.WriteLine(" Venda serializada:");
        Console.WriteLine(json);
        
       
    }
}