namespace TaskManager.Api.Models;

public class Tarefa
{
    public int Id { get; set; }

    public string Titulo { get; set; } = string.Empty;

    public string? Descricao { get; set; }

    public short Status { get; set; }

    /// <summary>
    /// Data e hora de criacao. O Npgsql le e grava esta propriedade em UTC.
    /// </summary>
    public DateTime CriadoEm { get; set; }

    /// <summary>
    /// Relacoes que representam as dependencias desta tarefa.
    /// </summary>
    public ICollection<TarefaDependencia> Dependencias { get; } = new List<TarefaDependencia>();

    /// <summary>
    /// Relacoes das tarefas que dependem desta tarefa.
    /// </summary>
    public ICollection<TarefaDependencia> TarefasDependentes { get; } = new List<TarefaDependencia>();
}
