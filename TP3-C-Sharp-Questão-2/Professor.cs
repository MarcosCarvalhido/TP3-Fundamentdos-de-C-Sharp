using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_C_Sharp_Questão_2
{
    public class Professor : Pessoa
    {
        public string Titulação { get; set; }
        public Professor() { }
        public Professor(string nome, long telefone, string titulação)
        : base(nome, telefone)
        {
            Titulação = titulação;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Titulação: {Titulação}.";
        }
    }
}
