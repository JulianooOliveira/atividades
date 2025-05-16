using System;

namespace Atividade8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de IMC");

            Console.Write("Digite seu peso (kg): ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (m): ");
            float altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            Console.WriteLine($"\nSeu IMC é: {imc:F2}");

            if (imc < 18.5f)
            {
                Console.WriteLine("Classificação: Abaixo do peso");
            }
            else if (imc < 25f)
            {
                Console.WriteLine("Classificação: Peso normal");
            }
            else if (imc < 30f)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade");
            }
        }
    }
}
