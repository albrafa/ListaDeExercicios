namespace Exercicio05
{
    internal class Program
    {

        //Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
        //vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
        static void Main(string[] args)
        {
            Console.WriteLine("*----------------------------------*--------------------------------*");
            Console.WriteLine("                         Calculadora de comissão");
            Console.WriteLine("*----------------------------------*--------------------------------*");
            Console.WriteLine();

            Console.WriteLine("Digite o salário base do funcionário: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas realizado pelo funcionário (Em R$): ");
            double totalVendas = Convert.ToDouble(Console.ReadLine()); ;

            Console.WriteLine("Digite a porcentagem de comissão sobre as vendas (apenas números): ");
            double comissaoInformada = Convert.ToDouble(Console.ReadLine());

            double comissaoVendas = (comissaoInformada * totalVendas) / 100;

            double salarioTotal = salarioBase + comissaoVendas;
            Console.WriteLine($"O salário total do funcionário é de {salarioTotal}.");
            
            
            Console.ReadLine();
        }
    }
}
