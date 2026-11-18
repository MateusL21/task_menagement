using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Api.Models;

namespace TaskManager.Api.Configurations;

public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
{
    public void Configure(EntityTypeBuilder<Tarefa> builder)
    {
        builder.ToTable("tarefas");

        builder.HasKey(tarefa => tarefa.Id);

        builder.Property(tarefa => tarefa.Id)
            .HasColumnName("id")
            .UseIdentityAlwaysColumn();

        builder.Property(tarefa => tarefa.Titulo)
            .HasColumnName("titulo")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(tarefa => tarefa.Descricao)
            .HasColumnName("descricao")
            .HasColumnType("text");

        builder.Property(tarefa => tarefa.Status)
            .HasColumnName("status")
            .HasColumnType("smallint")
            .HasDefaultValue((short)0)
            .IsRequired();

        builder.Property(tarefa => tarefa.CriadoEm)
            .HasColumnName("criado_em")
            .HasColumnType("timestamp with time zone")
            .HasDefaultValueSql("NOW()")
            .ValueGeneratedOnAdd();
    }
}
