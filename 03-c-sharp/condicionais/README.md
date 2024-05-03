# Operadores de Atribuição, Operadores Condicionais e Operadores Lógicos:
## Operadores de Atribuição:

---

## Operadores Condicionais:

Operadores condicionais são linhas de código que rodam dependendo de uma condição ser verdadeira ou falsa:

```
se (sol)
    irPraPraia = verdadeiro
senão
    ficarEmCasa = verdadeiro
fim se
```

Exemplo real:

```csharp
using condicionais.Models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantiadade compra {quantidadeCompra}");
Console.WriteLine($"Venda possível? {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("venda realizada.");
} 
else
{
    Console.WriteLine("desculpe. não temos a quantidade desejada em estoque");
}
```

Exemplo de `if` aninhado:

```csharp
int quantidadeEmEstoque = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra && quantidadeCompra > 0;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantiadade compra {quantidadeCompra}");
Console.WriteLine($"Venda possível? {possivelVenda}\n");

if (quantidadeCompra == 0)
{
    Console.WriteLine("venda invalida.");
}
else if (possivelVenda)
{
    Console.WriteLine("venda realizada.");
}
else
{
    Console.WriteLine("desculpe. não temos a quantidade desejada em estoque");
}
```

Exemplo de `switch`:

```cs
Console.WriteLine("Digite uma letra: ");

string letra = Console.ReadLine();

switch (letra) {
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine($"{letra} é uma vogal");
        break;
    default:
        Console.WriteLine($"{letra} não é uma vogal.");
        break;
}
```

---

## Operadores Lógicos:

### Operador `OR`:

```cs
bool maiorDeIdade = true;
bool autorizacaoDoResponsavel = false;

if (maiorDeIdade || autorizacaoDoResponsavel) {
    Console.WriteLine("ENTRADA AUTORIZADA.");
} else {
    Console.Write("ENTRADA NEGADA.");
}

```
`SAÍDA: ENTRADA AUTORIZADA.`

<br><br>

```cs
bool maiorDeIdade = false;
bool autorizacaoDoResponsavel = false;

if (maiorDeIdade || autorizacaoDoResponsavel) {
    Console.WriteLine("ENTRADA AUTORIZADA.");
} else {
    Console.Write("ENTRADA NEGADA.");
}
```
`SAÍDA: ENTRADA NEGADA.`

### Operador `AND`:

```csharp
bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7) { // presenca minima E nota >= 7
    Console.WriteLine("Aluno APROVADO.");
} else {
    Console.Write("Aluno REPROVADO.");
}
```

`SAÍDA: Aluno APROVADO.`

### Operador `NOT`:
    
```cs
bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde) {
    Console.WriteLine("vou pedalar hoje");
} else {
    Console.Write("vou pedalar outro dia.");
}
```
`SAÍDA: vou pedalar hoje`