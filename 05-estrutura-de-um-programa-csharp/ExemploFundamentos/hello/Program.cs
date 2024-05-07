using System.Data.Common;
using hello.common.Models; // namespace
namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaString = new List<string>();

            listaString.Add("SP");
            listaString.Add("BA");
            listaString.Add("MG");
            listaString.Add("RJ");

            for (int i = 0; i < listaString.Count; i++) {
                Console.WriteLine($"Posição número {i} = {listaString[i]}");
            }

            int contador = 0;
            foreach (string i in listaString){
                Console.WriteLine($"Posição número {contador} = {i}");
                contador++;
            }
        }   
    }
}









            // int[] arrayInteiros = new int[4];
                        
            //             arrayInteiros[0] = 72;
            //             arrayInteiros[1] = 64;
            //             arrayInteiros[2] = 50;
            //             arrayInteiros[3] = 1;

            //             int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
            //             Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

            //             // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

            //             Console.WriteLine("Percorrendo array com for:");
            //             for (int i = 0; i < arrayInteiros.Length; i++)
            //             {
            //                 Console.WriteLine($"Posição número {i} = {arrayInteirosDobrado[i]}");
            //             }

            // Console.WriteLine("Percorrendo array com foreach:");
            // foreach (int i in arrayInteiros)
            // {
            //     Console.WriteLine($"Posição número {contador} = {i}");
            //     contador++;
            // }


            // Pessoa pessoa1 = new Pessoa();

            // pessoa1.Nome = "lucas";
            // pessoa1.Idade = 18;
            // pessoa1.Apresentar();










// // convertendo tipos de variaveis: 
// // Cast - Casting
// int a = Convert.ToInt32(null);
// // int a = int.Parse(null);
// Console.WriteLine(a);
// // int b = a + 20; 
// // Console.WriteLine(b)

// // soma de variaveis
// // int a = 10;
// // int b = 20;
// // int c = a + b;
// // Console.WriteLine("a + b = " + c);
// // c += 5;
// // Console.WriteLine("c + 5 = " + c);

// /* RESTO ABAIXO: */


// // Pessoa pessoa1 = new Pessoa();

// // DateTime dataAtual = DateTime.Now;

// // Console.WriteLine("Data e Hora no Brasil: " + dataAtual.ToString("dd/MM/yyyy HH:mm"));
// // Console.WriteLine("Data e Hora na inglaterra: " + dataAtual.AddHours(4));

// // string apresentacao = "Olá, seja bem vindo!";
// // int quantidade = 1;

// // Console.WriteLine("Quantidade = " + quantidade);
// // quantidade = 10;
// // Console.WriteLine("Quantidade = " + quantidade);

// // double altura = 1.80;
// // decimal preco = 1.80M;
// // bool condicao = true;

// // Console.WriteLine("altura: " + altura.ToString("0.00") + "\napresentacao: " + apresentacao + "\nquantidade: " + quantidade
// //  + "\npreco: " + preco + "\ncondicao: " + condicao);


// // Console.WriteLine(apresentacao);

// // pessoa1.Nome = "lucas";
// // pessoa1.Idade = 18;
// // pessoa1.Apresentar();

// // // declarando de forma implicita
// // var pessoa2 = new Pessoa();

// // pessoa2.Nome = "aline";
// // pessoa2.Idade = 42;
// // pessoa2.Apresentar();

