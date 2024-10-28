using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAEFMR.Domain.Entities;

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