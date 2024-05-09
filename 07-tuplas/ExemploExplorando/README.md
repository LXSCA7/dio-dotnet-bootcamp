# Tuplas

## Criação de uma tupla:

```cs
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1 , "Lucas", "Rocha", 1.80M);
ValueTuple<int, string, string, decimal> outroExemploTupla = (1 , "Lucas", "Rocha", 1.80M);
var outroExemploTuplaCreate = Tuple.Create(1 , "Lucas", "Rocha", 1.80M);

Console.WriteLine("-------------- TUPLA --------------");
Console.WriteLine($"ID = {tupla.Id}");
Console.WriteLine($"NOME COMPLETO = {tupla.Nome} {tupla.Sobrenome}");
Console.WriteLine($"ALTURA = {tupla.Altura}\n");
Console.WriteLine("-------- outroExemploTupla --------");
Console.WriteLine($"ID = {outroExemploTupla.Item1}");
Console.WriteLine($"NOME COMPLETO = {outroExemploTupla.Item2} {outroExemploTupla.Item3}");
Console.WriteLine($"ALTURA = {outroExemploTupla.Item4}\n");
Console.WriteLine("----- outroExemploTuplaCreate -----");
Console.WriteLine($"ID = {outroExemploTuplaCreate.Item1}");
Console.WriteLine($"NOME COMPLETO = {outroExemploTuplaCreate.Item2} {outroExemploTuplaCreate.Item3}");
Console.WriteLine($"ALTURA = {outroExemploTuplaCreate.Item4}\n");
```

Fazendo a leitura de um arquivo e armazenando em uma tupla:

```cs
LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhas, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
if (!sucesso)
{
    Console.WriteLine("Não foi possível ler o arquivo. Favor verificar o caminho.");
    return;
}

Console.WriteLine("Arquivo lido com sucesso.");
Console.WriteLine($"Quantidade de linhas: {quantidadeLinhas}");
Console.WriteLine("Conteúdo do arquivo: ");
foreach (string i in linhas)
{
    Console.WriteLine(i);
}
```

## Desconstrutures:

Classe Pessoa:
```cs
public Pessoa(string nome, string sobrenome)
{
    Nome = nome;
    Sobrenome = sobrenome;
}

public void Deconstruct(out string nome, out string sobrenome)
{
    nome = Nome;
    sobrenome = Sobrenome;
}
```

Program.cs:
```cs 
Pessoa p1 = new Pessoa("Lucas", "Rocha");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");
Console.WriteLine($"{p1.Nome} {p1.Sobrenome}");
```

## IF Ternário

```cs
bool ehPar = false;
int numero = 15;

ehPar = numero % 2 == 0;

Console.Write($"O número {numero} é " + (ehPar ? "Par" : "impar"));
```