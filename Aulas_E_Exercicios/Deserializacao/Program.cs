using System.Collections.Generic;
using System;
using System.IO;
using System.Globalization;
using System.Text.Json.Serialization;
using Desereliacao.Models;
using Newtonsoft.Json;


string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach  (  Venda Venda in listaVendas)
{
        Console.WriteLine($"Id: {Venda.Id}, Produto {Venda.Produto} - Preco {Venda.Preco}, Data: {Venda.DataVenda.ToString("dd/MM/yyyy")}");
}