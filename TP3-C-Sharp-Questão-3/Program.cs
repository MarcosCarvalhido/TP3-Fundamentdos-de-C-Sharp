/*Faça um programa que implemente uma classe Aluno com os atributos nome e três notas. 
 * As notas devem ser representadas como vetor de três posições.
 * Implemente a sobrecarga de construtores e a sobrescrita para a exibição das informações do aluno, além dos gets e sets.
 * Implemente um método na classe Aluno que calcule a média do aluno.
 * Crie três objetos, a partir da classe Aluno, inicialize os atributos e exiba as informações de cada objeto, além de sua média.
 */
namespace TP3_C_Sharp_Questão_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno marcos = new Aluno("Marcos", new[] { 8, 5, 3 });
            Console.WriteLine(marcos.ToString());   
            Aluno juan = new Aluno("Juan", new[] { 9, 6, 4 });
            Console.WriteLine(juan.ToString());
            Aluno july = new Aluno("July", new[] { 10, 9, 8 });
            Console.WriteLine(july.ToString()); 
        }
    }
}