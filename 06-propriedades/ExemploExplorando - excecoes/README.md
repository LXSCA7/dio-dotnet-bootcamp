# Exceções e Coleções:

## Exceção genérica:

Exceções sem motivos específicos, exemplo:

```cs
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeit5ura.txt");

    foreach (string i in linhas) {
        Console.WriteLine(i);
    }
} 
catch(Exception ex) // Exceção genérica
{
    Console.WriteLine($"Erro: {ex.Message}");
}
```

Nesse caso acima, é para qualquer erro de código.

## Exceção específica:

```cs
try
{
    string[] linhas = File.ReadAllLines("Arquivo9s/arquivoLeitura.txt");

    foreach (string i in linhas) {
        Console.WriteLine(i);
    }
}
catch (FileNotFoundException ex) // Exceção para arquivo não encontrado.
{
    Console.WriteLine($"Erro: Arquivo não encontrado.\nMensagem: {ex.Message}");
}
catch (DirectoryNotFoundException ex) // Exceção para diretório não encontrado.
{
    Console.WriteLine($"Erro: Caminho da pasta não encontrado.\nMensagem: {ex.Message}");
}
catch (Exception ex) // Exceção genérica
{
    Console.WriteLine($"Erro Genérico: {ex.Message}");
}
```

Já nesse caso, há um tratamento para um erro de arquivo não encontrado, graças ao `FileNotFoundException`, e retornando uma mensagem "Arquivo não encontrado".