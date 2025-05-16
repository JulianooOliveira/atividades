using System;
using System.Collections.Generic;

namespace Atividade10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> tarefas = new List<string>();
            List<bool> concluidas = new List<bool>();

            while (true)
            {
                Console.WriteLine("\n--- Lista de Tarefas ---");
                Console.WriteLine("1 - Adicionar tarefa");
                Console.WriteLine("2 - Marcar tarefa como concluída");
                Console.WriteLine("3 - Mostrar todas as tarefas");
                Console.WriteLine("4 - Excluir tarefa");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                if (opcao == "0")
                {
                    Console.WriteLine("Saindo... Até a próxima!");
                    break;
                }

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite a nova tarefa: ");
                        string novaTarefa = Console.ReadLine();
                        tarefas.Add(novaTarefa);
                        concluidas.Add(false);
                        Console.WriteLine("Tarefa adicionada!");
                        break;

                    case "2":
                        if (tarefas.Count == 0)
                        {
                            Console.WriteLine("Nenhuma tarefa para marcar.");
                            break;
                        }

                        Console.WriteLine("Digite o número da tarefa para marcar como concluída:");
                        MostrarTarefas(tarefas, concluidas);

                        if (int.TryParse(Console.ReadLine(), out int numMarcar) && numMarcar > 0 && numMarcar <= tarefas.Count)
                        {
                            concluidas[numMarcar - 1] = true;
                            Console.WriteLine($"Tarefa {numMarcar} marcada como concluída!");
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case "3":
                        MostrarTarefas(tarefas, concluidas);
                        break;

                    case "4":
                        if (tarefas.Count == 0)
                        {
                            Console.WriteLine("Nenhuma tarefa para excluir.");
                            break;
                        }

                        Console.WriteLine("Digite o número da tarefa que deseja excluir:");
                        MostrarTarefas(tarefas, concluidas);

                        if (int.TryParse(Console.ReadLine(), out int numExcluir) && numExcluir > 0 && numExcluir <= tarefas.Count)
                        {
                            tarefas.RemoveAt(numExcluir - 1);
                            concluidas.RemoveAt(numExcluir - 1);
                            Console.WriteLine($"Tarefa {numExcluir} excluída com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }

        private static void MostrarTarefas(List<string> tarefas, List<bool> concluidas)
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            Console.WriteLine("\nTarefas:");

            for (int i = 0; i < tarefas.Count; i++)
            {
                string status = concluidas[i] ? "[Concluída]" : "[Pendente]";
                Console.WriteLine($"{i + 1}. {tarefas[i]} {status}");
            }
        }
    }
}
