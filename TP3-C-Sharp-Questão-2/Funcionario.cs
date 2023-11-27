using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_C_Sharp_Questão_2
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public Funcionario() { }
        public Funcionario(string nome, long telefone, string cargo)
        : base(nome, telefone)
        {
            Cargo = cargo;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Cargo: {Cargo}.";
        }
    }
}
