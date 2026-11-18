namespace TaskManager.Api.Models;

public class TarefaDependencia
{
    public int TarefaId { get; set; }

    public int DependenciaId { get; set; }

    /// <summary>
    /// Tarefa que possui a dependencia.
    /// </summary>
    public Tarefa Tarefa { get; set; } = null!;

    /// <summary>
    /// Tarefa que precisa ser concluida primeiro.
    /// </summary>
    public Tarefa Dependencia { get; set; } = null!;
}
