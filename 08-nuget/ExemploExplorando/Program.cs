using System.ComponentModel;
using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

internal class Program
{ 
    private static void Main(string[] args)
    {

        
        string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
        List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

        foreach (Venda venda in listaVenda)
        {
            Console.WriteLine($"Id: {venda.Id}\nProduto: {venda.Produto}\nPreço: {venda.Preco}\nData: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}\n");
        }
    }
}