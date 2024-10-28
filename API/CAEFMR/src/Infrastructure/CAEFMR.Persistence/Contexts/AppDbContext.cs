using CAEFMR.Domain.Entities;
using CAEFMR.Persistence.Configurations;
using CAEFMR.Persistence.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Persistence.Contexts;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    #region Tabelas

    public DbSet<Example> Examples { get; set; }

    #endregion

    #region Configurações

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //? Aplica todas as configurações de tabelas da pasta Configurations que tenham o tipo AppDbContext
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        // Seed data
        ExampleSeed.SeedData(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        DateTime localNow = DateTime.Now;

        ChangeTracker
            .Entries<BaseEntity>()
            .Where(entry => entry.State is EntityState.Added or EntityState.Modified)
            .ToList()
            .ForEach(entry =>
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = localNow;
                    entry.Entity.UpdatedDate = localNow;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedDate = localNow;
                }
            });

        return base.SaveChangesAsync(cancellationToken);
    }

    #endregion
}
