using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_C_Sharp_Questão_3
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int [] Notas { get; set; }
        public Aluno() { }
        public Aluno(string nome, int[] notas)
        {
            Nome = nome;
            Notas = notas;
        }
        public static double CalcularMesdia(int[] notas)
        {
            int soma = 0;
            int media = 0;
            foreach (var item in notas)
            {
                soma += item;
            }
            media = soma / notas.Length;
            return media;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Notas: {Notas}. Media: {CalcularMesdia(Notas)}";
        }
    }
}
