namespace Exercício_07
{
    internal class Program
    {
        //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

        //Para calcular a média ponderada de um aluno,
        //multiplique cada nota pelo seu respectivo peso, some todos os resultados e divida pelo total dos pesos. 
        //Suponha que um aluno tenha as seguintes notas e pesos:
        //Prova 1: 8.0 (peso 2), Prova 2: 7.0 (peso 1), Trabalho: 9.0 (peso 3).

        //Multiplique cada nota pelo seu peso:
        //    8.0 * 2 = 16
        //    7.0 * 1 = 7
        //    9.0 * 3 = 27

        //Some os resultados das multiplicações:
        //    16 + 7 + 27 = 50

        //Some os pesos:
        //    2 + 1 + 3 = 6

        //Divida a soma dos resultados pela soma dos pesos:
        //    50 / 6 = 8.33 (aproximadamente)


        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("                      CALCULADORA DE MÉDIA PONDERADA");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Informe a nota da primeira prova (apenas números): ");
            double notaAluno1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informe a nota da segunda prova (apenas números): ");
            double notaAluno2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informe o peso da primeira prova (apenas números): ");
            double pesoProva1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informe o peso da segunda prova (apenas números): ");
            Console.WriteLine();
            double pesoProva2 = Convert.ToDouble(Console.ReadLine());

            double resultadoProva1 = notaAluno1 * pesoProva1;
            double resultadoProva2 = notaAluno2 * pesoProva2;

            double somaValores = resultadoProva1 + resultadoProva2;           

            double somaPesos = pesoProva1 + pesoProva2;

            double mediaPonderada = somaValores / somaPesos;

            Console.WriteLine($"A média ponderada do aluno é {mediaPonderada}.");

            Console.ReadLine();
        }
    }
}
