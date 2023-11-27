using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_C_Sharp_Questão_2
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public long Telefone { get; set; }
        public Pessoa() { }
        public Pessoa(string nome, long telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}";
        }
    }
}
