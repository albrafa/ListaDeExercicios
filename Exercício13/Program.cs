namespace Exercício13
{
    internal class Program
    {
        static void Main(string[] args)

        // Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

        {
            Console.WriteLine("LEITURA DE VALORES");
            Console.WriteLine("O objetivo deste programa é saber se o valor final apresentado é válido.");
            Console.WriteLine("O resultado final será considerado válido caso o valor C seja menor do que a soma dos valores A e B.");

            Console.WriteLine("Digite o valor A (apenas números): ");
            double valorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor B (apenas números): ");
            double valorB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor C (apenas números): ");
            double valorC = Convert.ToDouble(Console.ReadLine());

            double resultadoFinal = valorA + valorB;

            if (valorA + valorB < valorC)
            {
                Console.WriteLine($"Os valores informados são válidos: {resultadoFinal} < {valorC}");
            }

            else
            {
                Console.WriteLine($"Os valores informados não são válidos: {resultadoFinal} > {valorC}");
            }

            
            Console.ReadLine();            
            
        }
    }
}
