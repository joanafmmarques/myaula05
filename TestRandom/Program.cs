using System;

namespace TestRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int dados;
            int soma = 0;

            Random r = new Random();

            Console.Write("Insira o número de dados: ");
            temp = Console.ReadLine();
            dados = Convert.ToInt32(temp);

            for (int i = 1; i <= dados; i++)
            {
                soma += r.Next(1, 7);

            }
            Console.WriteLine(soma);


             
       }
    }
}
