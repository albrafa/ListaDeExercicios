namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)

        //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        {
            Console.WriteLine("Algoritmo de classificação de valores por ordem numérica");

            int[] numeros = [5, 2, 3];

            Array.Sort(numeros);
            Array.Reverse(numeros);

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.ReadLine();
        }
    }
}
