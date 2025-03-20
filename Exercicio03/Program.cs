namespace Exercicio03
{
    internal class Program
    {
        // Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O
        // programa deve solicitar ao usuário:
        //  ● A quilometragem inicial do veículo no início da viagem.
        //  ● A quilometragem final ao término da viagem.
        //  ● A quantidade de combustível consumida durante a viagem(em litros).

        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quilometragem inicial do seu veículo: ");
            double inicioKm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a quilometragem final da viagem: ");
            double finalKm = Convert.ToDouble(Console.ReadLine());

            double distaciaPercorrida = finalKm - inicioKm;

            Console.WriteLine("Digite o consumo de combustível ao término da viagem: ");
            double consumoCombustivel = Convert.ToDouble(Console.ReadLine());

            double consumoPorKm = distaciaPercorrida / consumoCombustivel;

            Console.WriteLine($"O consumo de combustível durante o percurso foi de aproximadamente {consumoPorKm} km/L.");

            


            Console.ReadLine();
        }
    }
}
