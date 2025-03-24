namespace Exercicio09
{
    internal class Program
    {

        //programa para calcular a area de um retangulo
        // para calcular: Area = base x altura
        static void Main(string[] args)

        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("            Calculadora de dimensões de terrenos retangulares");
            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.WriteLine("Digite o tamanho da base do terreno (apenas números): ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o tamanho da altura do terreno (apenas números): ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            double areaRetangulo = alturaRetangulo * baseRetangulo;
            Console.WriteLine($"A área do terreo é {areaRetangulo}m².");


            Console.ReadLine();
        }

    }
}
