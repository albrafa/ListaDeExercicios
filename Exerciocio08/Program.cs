namespace Exerciocio08
{
    internal class Program
    {

        //Crie um programa para verificar se um número é primo.

        static void Main(string[] args)
        {
            Console.WriteLine("*--------------------------------*---------------------------------*");
            Console.WriteLine("                  ESSE NÚMERO É UM NÚMERO PRIMO?");
            Console.WriteLine("*--------------------------------*---------------------------------*");
            Console.WriteLine();

            Console.WriteLine("Digite o número desejado ");
            int numeroInformado = Convert.ToInt32(Console.ReadLine());

            bool numeroEhPrimo = true;

            if (numeroInformado < 2)
                numeroEhPrimo = false;

            if (numeroInformado == 2)
                numeroEhPrimo = true;

            else if (numeroInformado % 2 == 0)
                numeroEhPrimo = false;

            for (int i = 3; i * i <= numeroInformado; i+=2)
            {
                if (numeroInformado % i == 0)
                    numeroEhPrimo = false;
            }

            if (numeroEhPrimo)                               
            Console.WriteLine("O número informado é um número primo.");

            else
            Console.WriteLine("O número informado não é um número primo.");

                Console.ReadLine();
        }
    }
}
