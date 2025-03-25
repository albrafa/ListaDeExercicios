namespace Exercicio06
{
    internal class Program
    {

        //Crie um programa para calcular a média harmônica das notas de um Aluno

        static void Main(string[] args)
        {

            decimal nota1, nota2, nota3, nota4;
            Console.WriteLine("Digite as 4 notas do aluno: ");

            nota1 = Convert.ToDecimal(Console.ReadLine());
            nota2 = Convert.ToDecimal(Console.ReadLine());
            nota3 = Convert.ToDecimal(Console.ReadLine());
            nota4 = Convert.ToDecimal(Console.ReadLine());


            decimal mediaHarmonica = 4 / ((1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4));

            Console.WriteLine($"A média harmônica do aluno é de {mediaHarmonica}.");


            Console.ReadLine();
        }
    }
}
