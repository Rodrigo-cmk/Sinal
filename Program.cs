using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            leitura("Digite um número: ");
            numero(Console.ReadLine());
        }

        static void leitura(string leitura)
        {
            Console.WriteLine();
            DateTime agora = DateTime.Now;
            Console.WriteLine($"Olá!    {agora}");
            Console.WriteLine();
            Console.WriteLine("Leitura de um número inteiro e exibição de: 'Negativo', 'Zero' ou 'Positivo', conforme o caso.");
            Console.WriteLine();
            Console.Write(leitura);
        }

        static void numero(string numero)
        {
            int a;
            a = Convert.ToInt32(numero);

            if (a < 0)
            {
                Console.WriteLine("--> Negativo");
            }

            else if (a > 0)
            {
                Console.WriteLine("--> Positivo");
            }

            else if (a == 0)
            {
                Console.WriteLine("--> Zero");
            }
        }
    }
}
