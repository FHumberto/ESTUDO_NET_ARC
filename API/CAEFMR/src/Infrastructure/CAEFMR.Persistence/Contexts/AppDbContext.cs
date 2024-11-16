using CAEFMR.Application.Contracts.Identity;
using CAEFMR.Domain.Entities;
using CAEFMR.Persistence.Seeds;
using Microsoft.EntityFrameworkCore;

namespace CAEFMR.Persistence.Contexts;

public class AppDbContext(DbContextOptions<AppDbContext> options, IUserService userService) : DbContext(options)
{
    #region ===[ TABLES ]===============================================================================================

    public DbSet<Example>? Examples { get; set; }

    #endregion

    #region ===[ CONFIGURATION ]========================================================================================

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
                    entry.Entity.CreatedBy = userService.UserId;
                    entry.Entity.UpdatedDate = localNow;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedDate = localNow;
                    entry.Entity.ModifiedBy = userService.UserId;
                }
            });

        return base.SaveChangesAsync(cancellationToken);
    }

    #endregion
}
