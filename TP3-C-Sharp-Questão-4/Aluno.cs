using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_C_Sharp_Questão_4
{
    internal class Aluno
    {
        public  string? Nome { get; set; }
        public  int[]? Notas { get; set; }
        public  double Media { get; set; }
        public  Aluno(string nome, int[] notas)
        {
            Nome = nome;
            Notas = notas;
            CalcularMedias();
        }
        public  void CalcularMedias()
        {
            int soma = 0;
            Media = 0;
            foreach (var item in Notas)
            {
                soma += item;
            }
            Media = soma / Notas.Length;
          
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Notas: {string.Join(",",Notas)}, Media: {Media}";
        }
    }
}
