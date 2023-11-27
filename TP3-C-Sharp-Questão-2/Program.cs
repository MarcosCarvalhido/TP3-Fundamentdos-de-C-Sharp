/*Faça um programa que crie uma superclasse Pessoa abstrata e três subclasses concretas: Aluno, Professor e Funcionário,
 * a partir das informações do exercício anterior. Implemente o uso do construtor e da sobrescrita da superclasse, além dos gets e sets.
 * Instancie três objetos, um de cada subclasse, inicialize os seus atributos com as informações necessárias e exiba as informações do objeto utilizando a sobrescrita.
 */
namespace TP3_C_Sharp_Questão_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Aluno("Marcos", 9999999999, 00001);
            Console.WriteLine(pessoa.ToString());
            pessoa = new Professor("Lp", 9999999999, "Mestrado");
            Console.WriteLine(pessoa.ToString());
            pessoa = new Funcionario("Andre", 99999999, "Reitor");
            Console.WriteLine(pessoa.ToString());
        }
    }
}