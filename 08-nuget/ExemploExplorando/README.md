# Serialização

## Serializando para um arquivo JSON:

```cs
DateTime dataAtual = DateTime.Now;

        List<Venda> listaVendas = new List<Venda>();

        Venda v1 = new(1, "Material de escritório", 24.99M, dataAtual);
        Venda v2 = new(2, "Licença de Software", 110.00M, dataAtual);

        listaVendas.Add(v1);
        listaVendas.Add(v2);

        string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

        File.WriteAllText("Arquivos/vendas.json", serializado);

        Console.WriteLine(serializado);
```

## Deserializando:

```cs
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}\nProduto: {venda.Produto}\nPreço: {venda.Preco}\nData: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}\n");
}
```