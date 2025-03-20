namespace Exercicio04
{
    internal class Program
    {

        //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

        //Para converter graus Celsius (°C) para graus Fahrenheit (°F), multiplique
        //a temperatura em °C por 1,8 e some 32 ao resultado

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura (Celsius): ");
            double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());            

            double temperaturaFahrenheit = temperaturaCelsius * 1.8 + 32;

            double resultado = temperaturaFahrenheit;

            Console.WriteLine();
            Console.WriteLine($"{temperaturaCelsius}° Celsius equivale a {resultado}° Fahrenheit.");

            Console.ReadLine();
        }
    }
}
