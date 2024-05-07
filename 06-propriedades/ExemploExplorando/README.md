# Dictionary:

É uma coleção de chave-valor para armazenar valores ***únicos*** sem uma ordem específica.

` Dictionary<chave, valor> ` 

```cs
    Dictionary<string, string> estados = new Dictionary<string, string>();

    estados.Add("SP", "São Paulo");
    estados.Add("BA", "Bahia");
    estados.Add("RJ", "Rio de Janeiro");
    estados.Add("MG", "Minas Gerais");

    // listando os elementos
    foreach (KeyValuePair<string, string> i in estados)
    {
        Console.WriteLine($"Chave: {i.Key}, Valor: {i.Value}");
    }
```

**Em um Dictionary, as chaves devem ser únicas.**

## Alterando e removendo elementos em um Dictionary:

Para remover algum valor em um Dictionary, usamos `dicionario.Remove(chave);`

```cs
    estados.Remove("BA");

    foreach (KeyValuePair<string, string> i in estados)
    {
        Console.WriteLine($"Chave: {i.Key}, Valor: {i.Value}");
    }
```

Não é possível alterar a **CHAVE**, para isso devemos remover e adicionar o item novamente. Mas é possível alterar o _valor_ dessa forma:

```cs
estados["SP"] = "São Paulo - Valor Alterado";
```

## Verificando existência de uma chave:

```cs
    string chave = "BA";

    Console.WriteLine($"Verificando o elemento: {chave}");
    if (estados.ContainsKey(chave))
    {
        Console.WriteLine("Valor existente.");
    }
    else
    {
        Console.WriteLine("Valor inexistente, é possível adicionar essa chave.");
    }
```