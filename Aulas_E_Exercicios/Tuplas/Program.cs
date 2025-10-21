using System.Globalization;
using Tuplas.Models;
using System;

// Este código funciona porque usa Top-Level Statements (.NET 6+)
namespace Tuplas
{
    public class Program
    {

        public static void Main(string[] args)
        {

            LeituraArquivo arquivo = new LeituraArquivo();

            var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivo/arquivoleitura.txt");

            if (sucesso)
            {
                Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
                foreach (string linha in linhasArquivo) 
                {
                    Console.WriteLine(linha);
                }
            }
            else
            {
                Console.WriteLine("nao foi possivel ler o arquivo");
            }


            (int, string, string, decimal) tupla = (1, "Hellio", "Kadmiel", 10.5M);
            ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Hellio", "Kadmiel", 10.5M);
            var outroExemploTuplaCrate = Tuple.Create(1, "Hellio", "Kadmiel", 10.5M);

            Console.WriteLine($"ID {tupla.Item1}");
            Console.WriteLine($"Nome {tupla.Item2}");
            Console.WriteLine($"Sobrenome {tupla.Item3}");
            Console.WriteLine($"Valor {tupla.Item4}");
        }
    }
}