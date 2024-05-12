using ExemploPOO.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno a1 = new Aluno();
        a1.Nome = "Lucas";
        a1.Idade = 18;
        a1.Nota = 10;


        Professor p1 = new Professor() {
            Nome = "Cláudio",
            Idade = 44,
            Salario = 1426.14M
        };

        Diretor d1 = new Diretor() {
            Nome = "Márcio",
            Idade = 63,
            Salario = 5156.15M
        };

        a1.Apresentar();
        p1.Apresentar();
        d1.Apresentar();
    }
}