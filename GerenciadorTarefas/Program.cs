using GerenciadorTarefas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GerenciadorTarefas;

public class Program
{
    const string CaminhoArquivo = "tarefas.json";
    static List<Tarefa> tarefas = new();
    static int proximoId = 1;

    public static void Main()
    {
        CarregarTarefas();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== GERENCIADOR DE TAREFAS ===");
            Console.WriteLine("1 - Listar Tarefas");
            Console.WriteLine("2 - Adicionar Tarefa");
            Console.WriteLine("3 - Marcar como Concluída");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": ListarTarefas(); break;
                case "2": AdicionarTarefa(); break;
                case "3": ConcluirTarefa(); break;
                case "4": RemoverTarefa(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida."); break;
            }

            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
        }
    }

    static void ListarTarefas()
    {
        Console.WriteLine("\n--- Lista de Tarefas ---");
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
        }
        else
        {
            foreach (var tarefa in tarefas)
                tarefa.Exibir();
        }
    }

    static void AdicionarTarefa()
    {
        Console.Write("\nDigite a descrição da tarefa: ");
        string? desc = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(desc))
        {
            tarefas.Add(new Tarefa
            {
                Id = proximoId++,
                Descricao = desc
            });

            SalvarTarefas();

            Console.WriteLine("Tarefa adicionada com sucesso!");
        }
        else
        {
            Console.WriteLine("Descrição inválida.");
        }
    }

    static void ConcluirTarefa()
    {
        Console.Write("\nDigite o ID da tarefa a concluir: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.Concluida = true;
                SalvarTarefas();
                Console.WriteLine("Tarefa marcada como concluída!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido.");
        }
    }

    static void RemoverTarefa()
    {
        Console.Write("\nDigite o ID da tarefa a remover: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                SalvarTarefas();
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido.");
        }
    }

    static void SalvarTarefas()
    {
        var json = JsonSerializer.Serialize(tarefas, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(CaminhoArquivo, json);
    }

    static void CarregarTarefas()
    {
        if (File.Exists(CaminhoArquivo))
        {
            string json = File.ReadAllText(CaminhoArquivo);
            var lista = JsonSerializer.Deserialize<List<Tarefa>>(json);

            if (lista != null)
            {
                tarefas = lista;
                proximoId = tarefas.Count > 0 ? tarefas[^1].Id + 1 : 1;
            }
        }
    }
}
