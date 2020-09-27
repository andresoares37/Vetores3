using System;

namespace Vetores3
{
    class Program
    {
        static void Main(string[] args)
        {
            Locatario[] vect = new Locatario[10];

            Console.Write("Quantos quartos serão alugados? ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {


                Console.WriteLine("Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Locatario(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
