using System;

namespace Atividade3
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo para calcular o fatorial:");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Número inválido! Digite um número inteiro positivo.");
                return;
            }

            long fatorial = 1;

            for (int i = 1; i <= num; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"O fatorial de {num} é: {fatorial}");
        }
    }
}
