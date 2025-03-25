namespace Exercicio17
{
    internal class Program
    {

       //  faça um algoritmo que leia dois valores inteiros a e b, se os valores forem iguais deverá se somar os dois, caso
       // contrário multiplique a por b. ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
       //   variável c e mostrar seu conteúdo na tela.
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                   Calculo de valores");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Digite o primeiro valor (apenas numeros inteiros): ");
            int primeiroValorInformado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor (apenas numeros inteiros): ");
            int segundoValorInformado = Convert.ToInt32(Console.ReadLine());


            int resultadoDosValores; 

            if (primeiroValorInformado == segundoValorInformado)
            {
                resultadoDosValores = primeiroValorInformado + segundoValorInformado;
                Console.WriteLine($"O resultado da operação é: {resultadoDosValores}.");
            }

            else
            {
                resultadoDosValores = primeiroValorInformado * segundoValorInformado;
                Console.WriteLine($"O resultado da operação é: {resultadoDosValores}.");
            }

            Console.ReadLine();
        }
    }
}
