namespace Exercicio01
{
    internal class Program
    {

        // crie um programa para calculcar uma caixa retangular
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o comprimento da caixa: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a larguta da caixa: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a altura da caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = comprimento * largura * altura;

            Console.WriteLine($"O volume total da caixa é de {resultado} cm³.");


            Console.ReadLine();

        }
    }
}
