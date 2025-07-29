namespace GerenciadorTarefas;

public class Tarefa
{
    public int Id { get; set; }
    public string Descricao { get; set; } = "";
    public bool Concluida { get; set; } = false;

    public void Exibir()
    {
        string status = Concluida ? "[X]" : "[ ]";
        Console.WriteLine($"{Id}. {status} {Descricao}");
    }
}