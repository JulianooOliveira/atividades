using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividades
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Digite uma senha: ");
            Console.WriteLine("Essa senha deve possuir 8 caracteres, pelo menos uma letra maiúscula, um número, e um caracter especial");
            string senha = Console.ReadLine();

            string charEspecial = "/-!@#_*";

            Boolean senhaConfirmada = senha.Any(c => charEspecial.Contains(c));
            

            System.Console.WriteLine($"Você digitou a senha: {senhaConfirmada}");

        }

    }
}