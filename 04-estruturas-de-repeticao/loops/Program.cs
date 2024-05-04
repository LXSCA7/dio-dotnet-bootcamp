// loop DO-WHILE

int numero, soma = 0;

do
{
    Console.Write("Digite um numero (0 para parar): ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
} while (numero != 0);

Console.WriteLine($"Soma dos números: {soma}");

// // loop WHILE
// int numero = 5;
// int i = 0;
// while (i < 11)
// {
//     Console.WriteLine($"{numero} × {i} = {numero * i}");
//     i++;

//     if (i == 6)
//         break; // para sair do loop
// }

// // loop FOR
// int numero = 5;

// for (int i = 0; i < 11; i++)
// {
//     Console.WriteLine($"{numero} × {i} = {numero * i}");
// }