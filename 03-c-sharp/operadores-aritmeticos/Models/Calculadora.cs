using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace operadores_aritmeticos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} × {y} = {x * y}");
        }

        public void Dividir(float x, float y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo} = {Math.Round(cosseno,4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente,4)}");
        }

        public void RaizQuadrada(double x)
        { 
            Console.WriteLine($"Raiz de {x} = {Math.Sqrt(x)}");
        }
    }
}