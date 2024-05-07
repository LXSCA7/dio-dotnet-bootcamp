using System.ComponentModel;
using ExemploExplorando.Models;
using System.Globalization;
using System;




internal class Program
{ 
    private static void Main(string[] args)
    {
        string dataString = "2022-05-17 18:00";
        bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

        if (sucesso)
        {
            Console.WriteLine($"Conversão feita com sucesso. Data: {data}");
            return;
        }
        
        
        Console.WriteLine($"{dataString} não é uma data válida.");
    

        // Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Elias da Rocha");
        // Pessoa p2 = new Pessoa("Leonardo", "Buta");

        // Curso cursoDeIngles = new Curso();
        // cursoDeIngles.Nome = "Inglês";
        // cursoDeIngles.Alunos = new List<Pessoa>();

        // cursoDeIngles.AdicionarAluno(p1);
        // cursoDeIngles.AdicionarAluno(p2);
        // cursoDeIngles.ListarAlunos();
    }
}