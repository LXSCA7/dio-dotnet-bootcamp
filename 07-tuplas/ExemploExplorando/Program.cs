using System.ComponentModel;
using ExemploExplorando.Models;
using System.Globalization;
using System;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

internal class Program
{ 
    private static void Main(string[] args)
    {
        bool ehPar = false;
        int numero = 15;

        ehPar = numero % 2 == 0;
        
        Console.Write($"O número {numero} é " + (ehPar ? "Par" : "impar"));



        // if normal
        // if (numero % 2 == 0)
        //     Console.WriteLine($"O numero {numero} é par!");
        // else 
        //     Console.WriteLine($"O numero {numero} é par!");
        
        return;
    }   
}