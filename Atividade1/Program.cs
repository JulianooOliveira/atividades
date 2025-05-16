using System;
using System.Linq;

namespace atividades
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string charEspecial = "/-!@#_*";
            string senha;
            bool senhaValida = false;

            do
            {
                Console.WriteLine("\nDigite uma senha:");
                Console.WriteLine("A senha deve ter pelo menos:");
                Console.WriteLine("- 8 caracteres");
                Console.WriteLine("- 1 letra maiúscula");
                Console.WriteLine("- 1 número");
                Console.WriteLine($"- 1 caractere especial ({charEspecial})");
                senha = Console.ReadLine();

                bool temTamanhoMinimo = senha.Length >= 8;
                bool temMaiuscula = senha.Any(char.IsUpper);
                bool temNumero = senha.Any(char.IsDigit);
                bool temEspecial = senha.Any(c => charEspecial.Contains(c));

                // Debug (imprime os critérios)
                Console.WriteLine($"\nVerificando critérios:");
                Console.WriteLine($"✔ Tamanho >= 8 ............: {temTamanhoMinimo}");
                Console.WriteLine($"✔ Contém maiúscula ........: {temMaiuscula}");
                Console.WriteLine($"✔ Contém número ...........: {temNumero}");
                Console.WriteLine($"✔ Contém caractere especial: {temEspecial}");

                senhaValida = temTamanhoMinimo && temMaiuscula && temNumero && temEspecial;

                if (!senhaValida)
                {
                    Console.WriteLine("\n❌ Senha inválida. Verifique os critérios acima e tente novamente.");
                }

            } while (!senhaValida);

            Console.WriteLine($"\n✅ Senha cadastrada com sucesso.");
        }
    }
}
