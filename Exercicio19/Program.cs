namespace Exercicio19
{
    internal class Program
    {

        // Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
        // encontram no conjunto dos números de 1 até 500.
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA DE MÚLTIPLOS DE 3");
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para iniciar a calculadora...");
            Console.WriteLine();

            int somaNumeros = 0;
            int contador = 0;

            for (int i = 1; i <= 500; i += 2)
            {
                if (i % 3 == 0)
                {
                    somaNumeros += i;
                    contador++;
                }

            }

            Console.WriteLine($"A soma dos números ímpares e múltiplos de 3 entre 1 e 500 é {somaNumeros}.");
            Console.WriteLine();
            Console.WriteLine($"");

            Console.ReadLine();

        }
    }
}
