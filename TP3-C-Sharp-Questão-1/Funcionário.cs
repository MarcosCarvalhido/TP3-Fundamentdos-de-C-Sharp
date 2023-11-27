using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Fundamentos_de_C_Sharp
{
    internal class Funcionário
    {
        public string Nome { get; set; }
        public long Telefone { get; set; }
        public string Cargo { get; set; }
        public Funcionário() { }
        public Funcionário(string nome, long telefone, string cargo)
        {
            Nome = nome;
            Telefone = telefone;
            Cargo = cargo;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}, Cargo: {Cargo}.";
        }
    }
}
