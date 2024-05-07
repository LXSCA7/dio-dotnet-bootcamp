using System.ComponentModel;
using ExemploExplorando.Models;
using System.Globalization;
using System;
using System.Net.Mail;

internal class Program
{ 
    private static void Main(string[] args)
    {
        // Dictionary<CHAVE, VALOR>
        Dictionary<string, string> estados = new Dictionary<string, string>();

        estados.Add("SP", "São Paulo");
        estados.Add("BA", "Bahia");
        estados.Add("RJ", "Rio de Janeiro");
        estados.Add("MG", "Minas Gerais");

        foreach (KeyValuePair<string, string> i in estados)
        {
            Console.WriteLine($"Chave: {i.Key}, Valor: {i.Value}");
        }

        Console.WriteLine("----------------");

        // estados.Remove("BA");
        estados["SP"] = "São Paulo - Valor Alterado";

        foreach (KeyValuePair<string, string> i in estados)
        {
            Console.WriteLine($"Chave: {i.Key}, Valor: {i.Value}");
        }

        Console.WriteLine("----------------");

        string chave = "BA";
        Console.WriteLine($"Verificando o elemento: {chave}");
        if (estados.ContainsKey(chave))
        {
            Console.WriteLine("Valor existente.");
        }
        else
        {
            Console.WriteLine("Valor inexistente, é possível adicionar essa chave.");
        }


    }
}