using CAEFMR.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CAEFMR.Persistence.Configurations;

public class ExampleConfiguration : IEntityTypeConfiguration<Example>
{
    //? Adiciona as consrains e requerimentos da tabela
    public void Configure(EntityTypeBuilder<Example> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Nome).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Preco).HasColumnType("decimal(18,2)");
    }
}