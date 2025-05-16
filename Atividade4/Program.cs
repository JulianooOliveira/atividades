using System;

namespace Atividade4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nEscolha uma das opções abaixo:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("0 - Sair");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Digite a temperatura em Celsius:");
                    float celsius = float.Parse(Console.ReadLine());
                    float celsiusToFahrenheit = celsius * (9f / 5f) + 32;
                    Console.WriteLine($"A temperatura em Fahrenheit é {celsiusToFahrenheit:F2}°F.");
                    break;

                case 2:
                    Console.WriteLine("Digite a temperatura em Fahrenheit:");
                    float fahrenheit = float.Parse(Console.ReadLine());
                    float fahrenheitToCelsius = (fahrenheit - 32) * (5f / 9f);
                    Console.WriteLine($"A temperatura em Celsius é {fahrenheitToCelsius:F2}°C.");
                    break;

                case 0:
                    Console.WriteLine("Encerrando o programa. Até mais!");
                    break;

                default:
                    Console.WriteLine("Escolha uma opção válida!");
                    break;
            }
        }
    }
}
