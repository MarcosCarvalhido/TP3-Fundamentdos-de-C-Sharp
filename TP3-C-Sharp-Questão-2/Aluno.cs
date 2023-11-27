using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_C_Sharp_Questão_2
{
    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public Aluno() { }
        public Aluno(string nome, long telefone, int matricula)
        :base(nome,telefone)
        {
            Matricula = matricula;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Matricula: {Matricula}.";
        }
    }
}
