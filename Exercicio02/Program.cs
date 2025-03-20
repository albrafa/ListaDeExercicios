namespace Exercicio02
{
    internal class Program
    {
        //Crie um programa para calcular o volume de um Cilindro

        ////Identifique o raio da base do cilindro e a altura
        //Substitua os valores na fórmula V = π r² h
        //Calcule o volume

        // Volume = pi * raio * raio * altura
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double PI = Math.PI;

            double volume = PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume do cilindro é {volume:f2} m³.");

            Console.ReadLine();
        }
    }
}
