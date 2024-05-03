# Operadores aritméticos:

Lista dos operadores aritméticos em C#:

| Operador | Nome | 
|----------|------|
| + | Adição |
| - | Subtração |
| * | Multiplicação |
| / | Divisão |
| % | Módulo
| ++ | Incremento |
| -- | Decremento |

## Criando uma calculadora em C#:

Primeiramente devemos criar uma classe 'Calculadora' dentro da pasta `Models`, após isso, declaramos as operações de `Calculadora.cs`:

```cs
namespace operadores_aritmeticos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} × {y} = {x * y}");
        }

        public void Dividir(float x, float y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
    }
}
```

<Br>

Com isso feito, devemos agora realizar as operações dentro de `Program.cs`, inicializando a classe e escrevendo os cálculos desejados:

```cs
using operadores_aritmeticos.Models; // namespace (!)

Calculadora calc = new Calculadora(); // inicaliza a classe

calc.Somar(15, 5);
calc.Subtrair(10, 3);
calc.Multiplicar(4, 8);
calc.Dividir(24, 2);
```