using System;

namespace Atividade9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativas = 0;
            int chute = 0;

            Console.WriteLine("Jogo da Adivinhação");
            Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

            while (chute != numeroSecreto)
            {
                Console.Write("Digite seu palpite: ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out chute))
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                    continue;
                }

                tentativas++;

                if (chute < numeroSecreto)
                {
                    Console.WriteLine("O número é MAIOR. Tente novamente.");
                }
                else if (chute > numeroSecreto)
                {
                    Console.WriteLine("O número é MENOR. Tente novamente.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
                }
            }
        }
    }
}
