using operadores_aritmeticos.Models;

Calculadora calc = new Calculadora();

calc.Somar(15, 5);
calc.Subtrair(10, 3);
calc.Multiplicar(4, 8);
calc.Dividir(25, 2);
calc.Potencia(2, 2);

calc.Seno(30);
calc.Cosseno(60);
calc.Tangente(45);

calc.RaizQuadrada(9);

int numero = 10;
Console.WriteLine(numero);

Console.Write("Incrementando o 10: ");
numero++;
Console.WriteLine(numero);
Console.Write("Decrementando o 11: ");
numero--;
Console.WriteLine(numero);


