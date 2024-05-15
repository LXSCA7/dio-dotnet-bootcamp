using ExemploPOO.Models;
using ExemploPOO.Interfaces;
internal class Program
{
    private static void Main(string[] args)
    {
        ICalculadora c = new Calculadora();
        Console.WriteLine(c.Multiplicar(3, 5));
    }
}