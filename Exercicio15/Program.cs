using System.Runtime.Intrinsics.X86;

namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
            //o imc – índice de massa corporal é um critério da organização mundial de saúde para dar uma indicação sobre
            //a condição de peso de uma pessoa adulta.a fórmula é imc = peso / (altura) ². elabore um algoritmo que leia o
            //peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
            //● imc em adultos condição
            //● abaixo de 18,5
            //● abaixo do peso
            //● entre 18,5 e 25 peso normal
            //● entre 25 e 30
            //● acima do peso
            //● acima de 30 obeso


        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("                     CALCULADORA IMC");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Digite o seu peso atual (em Kg — apenas números): ");
            double pesoPessoal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a sua altura (apenas números): ");
            double alturaPessoal = Convert.ToDouble(Console.ReadLine());

            double resultadoImc = pesoPessoal / Math.Pow(alturaPessoal, 2);

            if (resultadoImc <= 18.5)
            {
                Console.WriteLine($"Você está abaixo do peso ideal. O seu IMC é igual a {resultadoImc}.");
            }

            else if (resultadoImc >= 18.5 && resultadoImc <= 25)
            {
                Console.WriteLine($"Você está com o peso normal. O seu IMC é igual a {resultadoImc}.");
            }

            else if (resultadoImc > 25 && resultadoImc < 30)
            {
                Console.WriteLine($"Você está acima do peso. O seu IMC é igual a {resultadoImc}.");
            }

            else if (resultadoImc >= 30)
            {
                Console.WriteLine($"Cuidado! O seu IMC é igual a {resultadoImc}, o que significa que você já está obeso.");
            }


                Console.ReadLine();
        }
    }
}
