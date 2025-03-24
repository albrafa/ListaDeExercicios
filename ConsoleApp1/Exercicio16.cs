namespace Exercicio16
{
    internal class Program
    {

        //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("                            PAR OU ÍMPAR");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Digite um número.");
            int numeroInformado = Convert.ToInt32(Console.ReadLine());

            if (numeroInformado % 2 == 0)
            {
                Console.WriteLine($"O número {numeroInformado} é um número par!");
            }

            else
            {
                Console.WriteLine($"O número {numeroInformado} é um número ímpar!");
            }

            Console.ReadLine();

        }
    }
}
