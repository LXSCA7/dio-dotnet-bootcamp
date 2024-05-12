using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Sou o Diretor {Nome}, tenho {Idade} anos e recebo {Salario}");
        }
    }
}