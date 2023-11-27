/*Faça um programa que crie três classes: Aluno, Professor e Funcionário. 
* A classe Aluno tem como atributos nome, telefone e matrícula,
* a classe Professor tem como atributos nome, telefone e titulação
* e a classe Funcionário tem como atributos nome, telefone e cargo.
* As classes devem ter sobrecarga de construtor e uma sobrescrita para exibir as suas informações,
* além dos gets e sets.
* Instancie três objetos, um de cada cada classe, inicialize os seus atributos com as informações necessárias e exiba as informações do objeto utilizando a sobrescrita implementada nas classes.
*/
namespace TP1_Fundamentos_de_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno marcos = new Aluno("Marcos",9999999999,00001);
            Console.WriteLine(marcos.ToString());   
            Professor lp = new Professor("Lp", 9999999999, "Mestrado");
            Console.WriteLine(lp.ToString());
            Funcionário andre = new Funcionário("Andre",99999999,"Reitor");
            Console.WriteLine(andre.ToString());

        }
    }
}