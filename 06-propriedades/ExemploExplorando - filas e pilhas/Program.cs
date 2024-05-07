using System.ComponentModel;
using ExemploExplorando.Models;
using System.Globalization;
using System;
using System.Net.Mail;

internal class Program
{ 
    private static void Main(string[] args)
    {
        Stack<int> pilha = new Stack<int>();

        pilha.Push(4);
        pilha.Push(6);
        pilha.Push(8);
        pilha.Push(10);

        foreach (int i in pilha)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
        
        pilha.Push(20);
        foreach (int i in pilha)
        {
            Console.WriteLine(i);
        }
    }
}

        // // FILAS
        // Queue<int> fila = new Queue<int>();
        // fila.Enqueue(2);
        // fila.Enqueue(4);
        // fila.Enqueue(6);
        // fila.Enqueue(8);

        // foreach (int i in fila)
        // {
        //     Console.WriteLine(i);
        // }

        // Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
        // fila.Enqueue(10);
        // foreach (int i in fila)
        // {
        //     Console.WriteLine(i);
        // }