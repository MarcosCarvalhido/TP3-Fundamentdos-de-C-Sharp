using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Fundamentos_de_C_Sharp
{
    internal class Professor
    {
        public string Nome { get; set; }
        public long Telefone { get; set; }
        public string Titulação { get; set; }
        public Professor() { }
        public Professor(string nome, long telefone, string titulação)
        {
            Nome = nome;
            Telefone = telefone;
            Titulação = titulação;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}, Titulação: {Titulação}.";
        }
    }
}
