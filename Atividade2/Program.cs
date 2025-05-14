using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("Digite um número para fazer a tabuada: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                System.Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }

    }
}