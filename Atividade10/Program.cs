using System.Runtime.ConstrainedExecution;

namespace Atividade10
{
    internal class Program
    {

      // A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
      // pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
       //   venda dos pães e broas(juntos), e quanto deve guardar numa conta de poupança(10% do total arrecadado).
        // Você foi contratado para fazer os cálculos para o dono.Com base nestes fatos, faça um algoritmo para ler as
        //  quantidades de pães e de broas, e depois calcular os dados solicitados.

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("                         CALCULADORA DE PADARIA");
            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.WriteLine("Informe a quantidade de vendas de pão: ");
            double custoPao = 0.12;
            double vendasPao = Convert.ToDouble(Console.ReadLine());
            
            double totalPaes = custoPao * vendasPao;
            Console.WriteLine($"O valor arrecadado com as vendas de pão é de: R$ {totalPaes}.");

            Console.WriteLine("Informe a quantidade de vendas de broa: ");
            double custoBroa = 1.50;
            double vendasBroa = Convert.ToDouble(Console.ReadLine());            

            double totalBroas = custoBroa * vendasBroa;
            Console.WriteLine($"O valor arrecadado com  as vendas de broa é de R$ {totalBroas}.");

            double arrecadacaoTotal = totalPaes + totalBroas;

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine($"O arrecadação total da padaria foi de: R${arrecadacaoTotal}.");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine();

            double poupanca = arrecadacaoTotal * 0.10;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine($"O montante a ser depositado em poupoança é de: R$ {poupanca}");
            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
