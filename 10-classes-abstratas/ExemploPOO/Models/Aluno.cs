using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            
        }
        public Aluno(string nome) : base(nome)
        {

        }
        public double Nota { get; set; }

        public override void Apresentar() {
            Console.WriteLine($"Ola, me chamo {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");
        }
    }
}