/*Faça um programa que implemente uma classe Aluno com os atributos nome, três notas e média.
 * As notas devem ser representadas como um vetor de três posições.
 * Implemente a sobrecarga de construtores e a sobrescrita para a exibição das informações do aluno, além dos gets e sets.
 * Implemente um método na classe Aluno que calcule a média do aluno.

A partir do teclado, o programa deverá ler os dados dos alunos e armazenar em um vetor de Aluno.
A entrada termina quando for digitado o nome igual a “FIM” e a turma pode ter no máximo 50 alunos.
Depois da leitura dos dados, o programa deverá mostrar os alunos com as suas respectivas médias,
a média da turma, o aluno com a maior média e o aluno com a menor média.
*/
namespace TP3_C_Sharp_Questão_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Aluno> listaAlunos = new List<Aluno>();
            bool FIM = false;
            string nome;
            int[] notas;
            int quant = 0;
            double media;
            Aluno melhorAluno;
            Aluno piorAluno;

            Console.Write("Insira as informações de cada aluno ou digite FIM para gerar um resumo");

            while (!FIM)
            {
                nome = PerguntarNome(quant);
                if (VerificarFim(nome))
                {
                    FIM = true;
                }
                else
                {
                    notas = PerguntarNotas(quant);
                    AdcionarAluno(nome, notas, listaAlunos);
                    quant++;
                }
            }
            media = CalcularMediaDaTurma(listaAlunos);
            melhorAluno= MelhorAluno(listaAlunos);
            piorAluno= PiorAluno(listaAlunos);

            MostrarMedias(listaAlunos);
            MostrarMelhorMedia(melhorAluno);
            MostrarPiorMedia(piorAluno);
        }
        public static bool VerificarFim(string entrada)
        {
            if (entrada == "FIM")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string PerguntarNome(int quant)
        {
            Console.Write($"Insira o nome do aluno {quant + 1}: ");
            return Console.ReadLine();
        }
        public static int[] PerguntarNotas(int quant)
        {
            int[] notas = new int[3];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Insira a nota {i + 1} do aluno {quant + 1}: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
            return notas;
        }
        public static List<Aluno> AdcionarAluno(string nome, int[] notas, List<Aluno> listaAlunos)
        {
            Aluno aluno = new Aluno(nome, notas);
            listaAlunos.Add(aluno);
            return listaAlunos;
        }
        public static double CalcularMediaDaTurma(List<Aluno> listaAlunos)
        {
            double soma = 0;
            foreach (Aluno aluno in listaAlunos)
            {
                aluno.CalcularMedias();
                soma += aluno.Media;
            }
            return soma / listaAlunos.Count;
        }
        public static Aluno? MelhorAluno(List<Aluno> listaAlunos)
        {
            double maiorMedia = 0;
            Aluno? melhorAluno = null;
            foreach (Aluno aluno in listaAlunos)
            {
                if (aluno.Media > maiorMedia)
                {
                    maiorMedia = aluno.Media;
                    melhorAluno = aluno;
                }
            }
            return melhorAluno;
        }
        public static Aluno? PiorAluno(List<Aluno> listaAlunos)
        {
            double MenorMedia = double.MaxValue;
            Aluno? piorAluno = null;
            foreach (Aluno aluno in listaAlunos)
            {
                if (aluno.Media < MenorMedia)
                {
                    MenorMedia = aluno.Media;
                    piorAluno = aluno;
                }
            }
            return piorAluno;
        }
        public static void MostrarMedias(List<Aluno> listaAlunos)
        {
            Console.WriteLine("As notas e medias de cada aluno foram: ");
            foreach (var item in listaAlunos)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void MostrarMediaDaTurma(double media)
        {
            Console.Write("A media total da turma foi de: ");
            Console.WriteLine(media);
        }
        public static void MostrarMelhorMedia(Aluno aluno)
        {
            Console.WriteLine($" O aluno com a MELHOR media foi o {aluno.Nome}. Com uma media totald de: {aluno.Media}");
        }
        public static void MostrarPiorMedia(Aluno aluno)
        {
            Console.WriteLine($" O aluno com a PIOR media foi o {aluno.Nome}. Com uma media totald de: {aluno.Media}");
        }
    }
}
