using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)

            // Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
            // Considere sempre anos completos, e que um ano possui 365 dias.Ex: uma pessoa com 19 anos possui 6935 dias
            // de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                 Quantos dias de vida você tem?");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("Escreva o seu nome: ");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("Digite a sua idade (apenas números): ");
            int idadePessoa = Convert.ToInt32(Console.ReadLine());


            int numerosDias = idadePessoa * 365;

            Console.WriteLine($"A quantidade de dias vividos por {nomePessoa} é de {numerosDias}.");


            Console.ReadLine();
        }
    }
}
