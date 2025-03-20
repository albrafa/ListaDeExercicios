namespace Exercicio05
{
    internal class Program
    {

        //Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
        //vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário base do funcionário: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem de comissão sobre a venda: ");
            double comissaoPorVenda = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas realizado pelo funcionário: ");
            double totalVendas = 0;

            double comissaoVendas = totalVendas + comissaoPorVenda;

            double salarioTotal = salarioBase + comissaoVendas;
            
            
            Console.ReadLine();
        }
    }
}
