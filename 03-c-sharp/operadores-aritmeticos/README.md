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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

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

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo} = {Math.Round(cosseno,4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente,4)}");
        }

        public void RaizQuadrada(double x)
        { 
            Console.WriteLine($"Raiz de {x} = {Math.Sqrt(x)}");
        }
    }
}
```

<Br>

Com isso feito, devemos agora realizar as operações dentro de `Program.cs`, inicializando a classe e escrevendo os cálculos desejados:

```cs
using operadores_aritmeticos.Models;

Calculadora calc = new Calculadora();

calc.Somar(15, 5);
calc.Subtrair(10, 3);
calc.Multiplicar(4, 8);
calc.Dividir(25, 2);
calc.Potencia(2, 2);
calc.RaizQuadrada(9);

calc.Seno(30);
calc.Cosseno(60);
calc.Tangente(45);
```