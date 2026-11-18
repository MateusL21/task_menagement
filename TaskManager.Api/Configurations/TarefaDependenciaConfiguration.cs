using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Api.Models;

namespace TaskManager.Api.Configurations;

public class TarefaDependenciaConfiguration : IEntityTypeConfiguration<TarefaDependencia>
{
    public void Configure(EntityTypeBuilder<TarefaDependencia> builder)
    {
        builder.ToTable("tarefa_dependencias");

        builder.HasKey(dependencia => new
        {
            dependencia.TarefaId,
            dependencia.DependenciaId
        });

        builder.Property(dependencia => dependencia.TarefaId)
            .HasColumnName("tarefa_id");

        builder.Property(dependencia => dependencia.DependenciaId)
            .HasColumnName("dependencia_id");

        builder.HasOne(dependencia => dependencia.Tarefa)
            .WithMany(tarefa => tarefa.Dependencias)
            .HasForeignKey(dependencia => dependencia.TarefaId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(dependencia => dependencia.Dependencia)
            .WithMany(tarefa => tarefa.TarefasDependentes)
            .HasForeignKey(dependencia => dependencia.DependenciaId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
