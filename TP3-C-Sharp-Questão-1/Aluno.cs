using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Fundamentos_de_C_Sharp
{
    internal class Aluno
    {
        public string Nome {  get; set; }
        public long Telefone { get; set; }
        public int Matricula { get; set; }
        public Aluno() { }
        public Aluno(string nome, long telefone, int matricula)
        {
            Nome = nome;
            Telefone = telefone;
            Matricula = matricula;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}, Matricula: {Matricula}.";
        }
    }
}
