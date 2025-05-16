using System;

namespace Atividade5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra ou frase: ");
            string entrada = Console.ReadLine();

            string tratado = new string(entrada
                                        .ToLower()
                                        .Where(c => char.IsLetter(c))
                                        .ToArray());

            char[] arrayInvertido = tratado.ToCharArray();
            Array.Reverse(arrayInvertido);
            string invertido = new string(arrayInvertido);

            if (tratado == invertido)
            {
                Console.WriteLine("É um palíndromo!");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo.");
            }
        }
    }
}
