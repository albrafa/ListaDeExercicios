namespace Exercício12
{
    internal class Program
    {
        static void Main(string[] args)

            // Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
            //  impostos.Imprima o salário inicial, o salário com o aumento e o salário final.
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("             CALCULADORA DE SALÁRIO E DESCONTO");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Informe o salário atual do trabalhador: ");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());

            double aumentoSalarial = salarioAtual * 0.15;
            double salarioComAumento = salarioAtual + aumentoSalarial;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"O salário bruto com aumento de 15% ficou em: R$ {salarioComAumento}.");
            Console.WriteLine("-----------------------------------------------------------------");

            double impostoSalario = salarioComAumento * 0.08;

            double descontoImpostos = salarioComAumento - impostoSalario;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"O valor líquido é de: R$ {descontoImpostos}.");
            Console.WriteLine("-----------------------------------------------------------------");



            Console.ReadLine();
        }
    }
}
