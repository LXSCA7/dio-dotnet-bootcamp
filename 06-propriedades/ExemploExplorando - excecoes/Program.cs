using System.ComponentModel;
using ExemploExplorando.Models;
using System.Globalization;
using System;
using System.Net.Mail;




internal class Program
{ 
    private static void Main(string[] args)
    {
        try
        {
            string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

            foreach (string i in linhas) {
                Console.WriteLine(i);
            }
        }
        catch (FileNotFoundException ex) // Exceção para arquivo não encontrado.
        {
            Console.WriteLine($"ERRO: Arquivo não encontrado.\nMensagem: {ex.Message}");
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine($"ERRO: Caminho da pasta não encontrado.\nMensagem: {ex.Message}");
        }
        catch (Exception ex) // Exceção genérica
        {
            Console.WriteLine($"ERRO Genérico.\nMensagem: {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"Fim da leitura.");
        }
    }
}